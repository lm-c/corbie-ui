using System.Drawing;
using System.Windows.Forms;

namespace LmCorbieUI {
  public class Toast {
    static Point mousePosition = Cursor.Position;
    static Screen currentScreen = Screen.FromPoint(mousePosition);
    static Bitmap defImage = new Bitmap(15, 15);
    public static void Show(string message) {
      var backColor = Color.FromArgb(250, 248, 240);
      var foreColor = Color.FromArgb(20, 22, 30);
      var icon = defImage;
      FrmToastForm toast = new FrmToastForm(message, backColor, foreColor, icon);
      toast.Location = new Point(
        currentScreen.WorkingArea.Right - toast.Width - 10,
        currentScreen.WorkingArea.Top + 10
        );
      toast.Show();
    }

    public static void Success(string message) {
      var backColor = Color.FromArgb(76, 175, 80);
      var foreColor = Color.FromArgb(250, 248, 240);
      var icon = Properties.Resources.toast_sucess;
      FrmToastForm toast = new FrmToastForm(message, backColor, foreColor, icon);
      toast.Location = new Point(
        currentScreen.WorkingArea.Right - toast.Width - 10,
        currentScreen.WorkingArea.Top + 10
        );
      toast.Show();
    }

    public static void Info(string message) {
      var backColor = Color.FromArgb(33, 150, 243);
      var foreColor = Color.FromArgb(250, 248, 240);
      var icon = Properties.Resources.toast_info;
      FrmToastForm toast = new FrmToastForm(message, backColor, foreColor, icon);
      toast.Location = new Point(
        currentScreen.WorkingArea.Right - toast.Width - 10,
        currentScreen.WorkingArea.Top + 10
        );
      toast.Show();
    }

    public static void Warning(string message) {
      var backColor = Color.FromArgb(255, 152, 0);
      var foreColor = Color.FromArgb(250, 248, 240);
      var icon = Properties.Resources.toast_warning;
      FrmToastForm toast = new FrmToastForm(message, backColor, foreColor, icon);
      toast.Location = new Point(
        currentScreen.WorkingArea.Right - toast.Width - 10,
        currentScreen.WorkingArea.Top + 10
        );
      toast.Show();
    }

    public static void Error(string message) {
      var backColor = Color.FromArgb(244, 67, 54);
      var foreColor = Color.FromArgb(250, 248, 240);
      var icon = Properties.Resources.toast_error;
      FrmToastForm toast = new FrmToastForm(message, backColor, foreColor, icon);
      toast.Location = new Point(
        currentScreen.WorkingArea.Right - toast.Width - 10,
        currentScreen.WorkingArea.Top + 10
        );
      toast.Show();
    }

    public static void Black(string message) {
      var backColor = Color.FromArgb(50, 48, 40);
      var foreColor = Color.FromArgb(250, 248, 240);
      var icon = defImage;
      FrmToastForm toast = new FrmToastForm(message, backColor, foreColor, icon);
      toast.Location = new Point(
        currentScreen.WorkingArea.Right - toast.Width - 10,
        currentScreen.WorkingArea.Top + 10
        );
      toast.Show();
    }

  }
}

