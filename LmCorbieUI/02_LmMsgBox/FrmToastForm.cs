using LmCorbieUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LmCorbieUI {
  public partial class FrmToastForm : Form {
    private Timer _timer;
    private Color _foreColor;
    public FrmToastForm(string message, Color backColor,Color foreColor, Image icon) {
      InitializeComponent();

      _foreColor = foreColor;
      this.BackColor = backColor;
      ptbIcon.Image = icon;
      lblMessage.ForeColor = foreColor;
      lblMessage.Text = message;
      btnClose.ForeColor = foreColor;
      ptbIcon.Image =  icon.ApplyColor(foreColor);
      
      //// Ajustando o tamanho do Form
      this.Width = lblMessage.Width + ptbIcon.Width + btnClose.Width + 22;
      this.Height = lblMessage.Height;

      // Temporizador para fechar automaticamente
      _timer = new Timer();
      _timer.Interval = 3000; // 3 segundos
      _timer.Tick += (s, e) => this.Close();
      _timer.Start();

      this.MouseEnter += ModernToastForm_MouseEnter;
      this.MouseLeave += ModernToastForm_MouseLeave;
      foreach (Control control in this.Controls) {
        control.MouseEnter += ModernToastForm_MouseEnter;
        control.MouseLeave += ModernToastForm_MouseLeave;
      }
    }

    private void ModernToastForm_MouseEnter(object sender, EventArgs e) {
      _timer.Stop();
    }

    private void ModernToastForm_MouseLeave(object sender, EventArgs e) {
      _timer.Start();
    }

    private void BtnClose_Click(object sender, System.EventArgs e) {
      this.Close();
    }

    private void BtnClose_MouseEnter(object sender, System.EventArgs e) {
      btnClose.ForeColor = Color.Red;
    }

    private void BtnClose_MouseLeave(object sender, System.EventArgs e) {
      btnClose.ForeColor = _foreColor;
    }
  }
}
