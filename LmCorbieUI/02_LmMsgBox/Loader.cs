using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LmCorbieUI {
  public class Loader {
    private static FrmLoadForm activeLoader = null;
    private static readonly object lockObject = new object();
    public static bool _isWorking = true;

    // Definição de cores principais
    private static readonly Color PrimaryBackColor = Color.FromArgb(26, 54, 71); // cor solicitada
    private static readonly Color PrimaryForeColor = Color.FromArgb(245, 245, 245); // texto claro para contraste
    private static readonly Bitmap DefaultIcon = new Bitmap(15, 15);

    // método para mostrar com progresso indeterminado
    public static void Show(string message) {
      if (InvokeRequired()) {
        Application.OpenForms[0]?.Invoke(new Action(() => Show(message)));
        return;
      }

      lock (lockObject) {
        if (activeLoader != null && !activeLoader.IsDisposed && activeLoader.Visible) {
          activeLoader.SetMessage(message);
        } else {
          _isWorking = true; // Resetar para true quando mostrar
          FrmLoadForm loader = new FrmLoadForm(message, PrimaryBackColor, PrimaryForeColor, DefaultIcon);
          ShowLoader(loader);
        }
      }
    }

    // método para mostrar com progresso determinado
    public static void Show(string message, int currentValue, int maxValue, string customProgressText = null) {
      if (InvokeRequired()) {
        Application.OpenForms[0]?.Invoke(new Action(() => Show(message, currentValue, maxValue, customProgressText)));
        return;
      }

      lock (lockObject) {
        if (activeLoader != null && !activeLoader.IsDisposed && activeLoader.Visible) {
          activeLoader.SetMessage(message);
          activeLoader.SetProgress(currentValue, maxValue, customProgressText);
        } else {
          _isWorking = true;
          FrmLoadForm loader = new FrmLoadForm(message, PrimaryBackColor, PrimaryForeColor, DefaultIcon);
          loader.SetProgress(currentValue, maxValue, customProgressText);
          ShowLoader(loader);
        }
      }
    }

    // Método para atualizar apenas o progresso
    public static void UpdateProgress(int currentValue, int maxValue, string customProgressText = null) {
      if (InvokeRequired()) {
        Application.OpenForms[0]?.Invoke(new Action(() => UpdateProgress(currentValue, maxValue, customProgressText)));
        return;
      }

      lock (lockObject) {
        if (activeLoader != null && !activeLoader.IsDisposed && activeLoader.Visible) {
          activeLoader.SetProgress(currentValue, maxValue, customProgressText);
        }
      }
    }

    public static void Hide() {
      if (InvokeRequired()) {
        Application.OpenForms[0]?.Invoke(new Action(Hide));
        return;
      }

      lock (lockObject) {
        if (activeLoader != null && !activeLoader.IsDisposed) {
          activeLoader.Close();
          activeLoader = null;
        }
      }
    }

    // Método para cancelar operações
    public static void Cancel() {
      _isWorking = false;
      Hide();
    }

    private static void ShowLoader(FrmLoadForm frmLoader) {
      GetPosition(frmLoader);
      activeLoader = frmLoader;
      frmLoader.RecenterForm();
      frmLoader.Show();
      frmLoader.BringToFront();
    }

    private static void GetPosition(FrmLoadForm loader) {
      Point mousePosition = Cursor.Position;
      Screen currentScreen = Screen.FromPoint(mousePosition);
      loader.StartPosition = FormStartPosition.Manual;
      loader.Location = new Point(
          currentScreen.WorkingArea.Left + (currentScreen.WorkingArea.Width - loader.Width) / 2,
          currentScreen.WorkingArea.Top + (currentScreen.WorkingArea.Height - loader.Height) / 2
      );
    }

    private static bool InvokeRequired() {
      return Application.OpenForms.Count > 0 && Application.OpenForms[0].InvokeRequired;
    }

    // Método para operações com progresso determinado
    public static async Task ShowDuringOperation<T>(
        string initialMessage,
        Func<IProgress<(string message, int current, int max)>, Task<T>> operation,
        int totalSteps) {

      var progress = new Progress<(string message, int current, int max)>(update => {
        if (_isWorking) {
          Show(update.message, update.current, update.max);
        }
      });

      try {
        Show(initialMessage, 0, totalSteps);
        await Task.Run(() => operation(progress));
      } finally {
        Hide();
      }
    }

    // Método original para progresso indeterminado
    public static async Task ShowDuringOperation(Func<IProgress<string>, Task> operation) {
      var progress = new Progress<string>(message => {
        if (_isWorking) {
          Show(message);
        }
      });

      try {
        Show("Iniciando...");
        await Task.Run(() => operation(progress));
      } finally {
        Hide();
      }
    }
  }
}
