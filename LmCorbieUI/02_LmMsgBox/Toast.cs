using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LmCorbieUI {
  public class Toast {
    private static List<FrmToastForm> activeToasts = new List<FrmToastForm>();

    public static void Show(string message) {
      var backColor = Color.FromArgb(250, 248, 240);
      var foreColor = Color.FromArgb(20, 22, 30);
      var icon = new Bitmap(15, 15);
      FrmToastForm toast = new FrmToastForm(message, backColor, foreColor, icon);
      ShowToast(toast);
    }

    public static void Success(string message) {
      var backColor = Color.FromArgb(76, 175, 80);
      var foreColor = Color.FromArgb(250, 248, 240);
      var icon = Properties.Resources.toast_sucess;
      FrmToastForm toast = new FrmToastForm(message, backColor, foreColor, icon);
      ShowToast(toast);
    }

    public static void Info(string message) {
      var backColor = Color.FromArgb(33, 150, 243);
      var foreColor = Color.FromArgb(250, 248, 240);
      var icon = Properties.Resources.toast_info;
      FrmToastForm toast = new FrmToastForm(message, backColor, foreColor, icon);
      ShowToast(toast);
    }

    public static void Warning(string message) {
      var backColor = Color.FromArgb(255, 152, 0);
      var foreColor = Color.FromArgb(250, 248, 240);
      var icon = Properties.Resources.toast_warning;
      FrmToastForm toast = new FrmToastForm(message, backColor, foreColor, icon);
      ShowToast(toast);
    }

    public static void Error(string message) {
      var backColor = Color.FromArgb(244, 67, 54);
      var foreColor = Color.FromArgb(250, 248, 240);
      var icon = Properties.Resources.toast_error;
      FrmToastForm toast = new FrmToastForm(message, backColor, foreColor, icon);
      ShowToast(toast);
    }

    public static void Black(string message) {
      var backColor = Color.FromArgb(50, 48, 40);
      var foreColor = Color.FromArgb(250, 248, 240);
      var icon = new Bitmap(15, 15);
      FrmToastForm toast = new FrmToastForm(message, backColor, foreColor, icon);
      ShowToast(toast);
    }

    public static void PauseAllToasts() {
      foreach (var activeToast in activeToasts.Where(t => !t.IsDisposed && t.Visible)) {
        activeToast.SetMouseOver(true);
      }
    }

    public static void ResumeAllToasts() {
      foreach (var activeToast in activeToasts.Where(t => !t.IsDisposed && t.Visible)) {
        activeToast.SetMouseOver(false);
      }
    }

    private static void ShowToast(FrmToastForm toast) {
      // Remove toasts que já foram fechados da lista
      activeToasts.RemoveAll(t => t.IsDisposed || !t.Visible);

      GetPosition(toast);
      activeToasts.Add(toast);

      // Adiciona evento para remover o toast da lista quando for fechado
      toast.FormClosed += (sender, e) => {
        activeToasts.Remove(toast);
        RepositionToasts();
      };

      toast.Show();
    }

    private static void GetPosition(FrmToastForm toast) {
      Point mousePosition = Cursor.Position;
      Screen currentScreen = Screen.FromPoint(mousePosition);

      int yOffset = 10; // Posição inicial do topo

      // Calcula o offset vertical baseado nos toasts ativos
      foreach (var activeToast in activeToasts.Where(t => !t.IsDisposed && t.Visible)) {
        yOffset += activeToast.Height + 5; // 5px de espaçamento entre toasts
      }

      toast.Location = new Point(
        currentScreen.WorkingArea.Right - toast.Width - 10,
        currentScreen.WorkingArea.Top + yOffset
    );
    }

    private static void RepositionToasts() {
      // Reposiciona todos os toasts ativos quando um é removido
      Point mousePosition = Cursor.Position;
      Screen currentScreen = Screen.FromPoint(mousePosition);

      int yOffset = 10;

      foreach (var activeToast in activeToasts.Where(t => !t.IsDisposed && t.Visible)) {
        activeToast.Location = new Point(
          currentScreen.WorkingArea.Right - activeToast.Width - 10,
          currentScreen.WorkingArea.Top + yOffset
        );
        yOffset += activeToast.Height + 5;
      }
    }
  }
}

