using System;
using System.Drawing;
using System.Windows.Forms;

namespace LmCorbieUI {
  public partial class FrmToastForm : Form {
    private Timer _timer;
    private Color _foreColor;
    private int _currentValue = 0;
    private int _maxValue = 3000; // 3 segundos em milissegundos
    private bool _isMouseOver = false;

    public FrmToastForm(string message, Color backColor,Color foreColor, Image icon) {
      InitializeComponent();

      _foreColor = foreColor;
      this.BackColor = backColor;
      ptbIcon.Image = icon;
      lblMessage.ForeColor = foreColor;
      lblMessage.Text = message;
      btnClose.ForeColor = foreColor;
      ptbIcon.Image =  icon.ApplyColor(foreColor);

      // Configurar o panel de progresso
      SetupProgressPanel(backColor, foreColor);

      //// Ajustando o tamanho do Form
      this.Width = lblMessage.Width + ptbIcon.Width + btnClose.Width + 22;
      this.Height = lblMessage.Height + pnlProgress.Height;

      // Timer único para controlar tanto o progresso quanto o fechamento
      _timer = new Timer();
      _timer.Interval = 30; // 30ms
      _timer.Tick += Timer_Tick;
      _timer.Start();

      pnlBackground.MouseEnter += ModernToastForm_MouseEnter;
      pnlBackground.MouseLeave += ModernToastForm_MouseLeave;
      foreach (Control control in pnlBackground.Controls) {
        control.MouseEnter += ModernToastForm_MouseEnter;
        control.MouseLeave += ModernToastForm_MouseLeave;
      }
    }

    private void SetupProgressPanel(Color backColor, Color foreColor) {
      // Configurar o panel para desenho personalizado
      pnlProgress.Paint += PnlProgress_Paint;

      // Habilitar double buffering para evitar piscadas
      typeof(Panel).InvokeMember("DoubleBuffered",
        System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
        null, pnlProgress, new object[] { true });

      // Definir cor de fundo similar ao form (mais escura)
      pnlProgress.BackColor = ControlPaint.Dark(backColor, 0.1f);
    }

    private void Timer_Tick(object sender, EventArgs e) {
      // Só incrementa se o mouse não estiver sobre o controle
      if (!_isMouseOver) {
        _currentValue += _timer.Interval;

        Console.WriteLine($"Current Value: {_currentValue}");
        // Atualizar progress bar
        pnlProgress.Invalidate();

        // Fechar quando atingir o valor máximo
        if (_currentValue >= _maxValue) {
          this.Close();
        }
      }
    }

    private void PnlProgress_Paint(object sender, PaintEventArgs e) {
      Panel panel = sender as Panel;
      Graphics g = e.Graphics;

      // Melhorar qualidade do desenho
      g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      // Calcular largura da barra de progresso
      int progressWidth = (int)((float)_currentValue / _maxValue * panel.Width);

      // Desenhar fundo (cor mais escura que o form)
      using (SolidBrush backgroundBrush = new SolidBrush(ControlPaint.Dark(this.BackColor, 0.1f))) {
        g.FillRectangle(backgroundBrush, 0, 0, panel.Width, panel.Height);
      }

      // Desenhar barra de progresso (cor do foreground com transparência)
      if (progressWidth > 0) {
        using (SolidBrush progressBrush = new SolidBrush(Color.FromArgb(100, _foreColor))) {
          g.FillRectangle(progressBrush, 0, 0, progressWidth, panel.Height);
        }
      }

      //// Opcional: desenhar borda
      //using (Pen borderPen = new Pen(ControlPaint.Dark(_foreColor, 0.3f), 1)) {
      //  g.DrawRectangle(borderPen, 0, 0, panel.Width - 1, panel.Height - 1);
      //}
    }

    private void ModernToastForm_MouseEnter(object sender, EventArgs e) {
      Toast.PauseAllToasts();
    }

    private void ModernToastForm_MouseLeave(object sender, EventArgs e) {
      Toast.ResumeAllToasts();
    }
    public void SetMouseOver(bool isMouseOver) {
      _isMouseOver = isMouseOver;
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

    private void FrmToastForm_FormClosing(object sender, FormClosingEventArgs e) {
      StopTimer(); // Garantir que o timer pare quando o form fechar
    }

    private void StopTimer() {
      if (_timer != null) {
        _timer.Stop();
        _timer.Tick -= Timer_Tick;
        _timer.Dispose();
        _timer = null;
      }
    }
  }
}
