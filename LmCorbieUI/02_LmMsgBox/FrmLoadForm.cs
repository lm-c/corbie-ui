using LmCorbieUI;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace LmCorbieUI {
  public partial class FrmLoadForm : Form {
    private Color _foreColor;
    private int _currentProgressValue = 0;
    private int _maxProgressValue = 0;
    private bool _isWorking = true;
    private Timer _animationTimer;
    private float _animationOffset = 0f;
    private bool _isDeterminateProgress = false;
    private string _progressText = "";

    public FrmLoadForm(string message, Color backColor, Color foreColor, Image icon) {

      InitializeComponent();

      this.Opacity = 0.9;

      _foreColor = foreColor;
      this.BackColor = backColor;
      this.TopMost = true;
      this.ShowInTaskbar = false;
      this.FormBorderStyle = FormBorderStyle.None;

      ptbIcon.Image = icon;
      lblMessage.ForeColor = foreColor;
      lblMessage.Text = message;
      btnClose.ForeColor = foreColor;

      if (icon != null) {
        ptbIcon.Image = icon.ApplyColor(foreColor);
      }

      SetupProgressPanel(backColor, foreColor);
      AdjustFormSize();
      StartAnimation(); // Iniciar animação uma única vez
      RecenterForm();
    }

    private void StartAnimation() {
      if (_animationTimer != null) {
        _animationTimer.Stop();
        _animationTimer.Dispose();
      }

      _animationTimer = new Timer();
      _animationTimer.Interval = 50; // 20 FPS
      _animationTimer.Tick += AnimationTimer_Tick;
      _animationTimer.Start();
    }

    private void AnimationTimer_Tick(object sender, EventArgs e) {
      if (!_isWorking || !Loader._isWorking || this.IsDisposed) {
        StopAnimation();
        return;
      }

      // Só animar se for progresso indeterminado
      if (!_isDeterminateProgress) {
        _animationOffset += 0.1f;
        if (_animationOffset > Math.PI * 2) {
          _animationOffset = 0f;
        }
      }

      // Invalidar apenas se o painel ainda existir e estiver visível
      if (pnlProgress != null && !pnlProgress.IsDisposed && pnlProgress.Visible) {
        pnlProgress.Invalidate();
      }
    }

    private void StopAnimation() {
      if (_animationTimer != null) {
        _animationTimer.Stop();
        _animationTimer.Dispose();
        _animationTimer = null;
      }
    }

    private void SetupProgressPanel(Color backColor, Color foreColor) {
      pnlProgress.Paint += PnlProgress_Paint;

      // Habilitar double buffering
      typeof(Panel).InvokeMember("DoubleBuffered",
          System.Reflection.BindingFlags.SetProperty |
          System.Reflection.BindingFlags.Instance |
          System.Reflection.BindingFlags.NonPublic,
          null, pnlProgress, new object[] { true });

      pnlProgress.BackColor = ControlPaint.Dark(backColor, 0.1f);
    }

    private void PnlProgress_Paint(object sender, PaintEventArgs e) {
      Panel panel = sender as Panel;
      Graphics g = e.Graphics;

      g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      // Desenhar fundo
      using (SolidBrush backgroundBrush = new SolidBrush(ControlPaint.Dark(this.BackColor, 0.1f))) {
        g.FillRectangle(backgroundBrush, 0, 0, panel.Width, panel.Height);
      }

      if (_isWorking) {
        if (_isDeterminateProgress && _maxProgressValue > 0) {
          // Progresso determinado - barra baseada na porcentagem
          DrawDeterminateProgress(g, panel);
        } else {
          // Progresso indeterminado - animação contínua
          DrawIndeterminateProgress(g, panel);
        }
      }
    }

    private void DrawDeterminateProgress(Graphics g, Panel panel) {
      // Calcular porcentagem
      float percentage = (float)_currentProgressValue / _maxProgressValue;
      int progressWidth = (int)(percentage * panel.Width);

      // Desenhar barra de progresso
      using (SolidBrush progressBrush = new SolidBrush(Color.FromArgb(150, _foreColor))) {
        g.FillRectangle(progressBrush, 0, 0, progressWidth, panel.Height);
      }

      // Desenhar texto de porcentagem
      if (!string.IsNullOrEmpty(_progressText)) {
        using (SolidBrush textBrush = new SolidBrush(_foreColor)) {
          using (Font font = new Font("Segoe UI", 8, FontStyle.Bold)) {
            SizeF textSize = g.MeasureString(_progressText, font);
            float textX = (panel.Width - textSize.Width) / 2;
            float textY = (panel.Height - textSize.Height) / 2;

            // Desenhar sombra do texto
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(100, Color.Black))) {
              g.DrawString(_progressText, font, shadowBrush, textX + 1, textY + 1);
            }

            // Desenhar texto principal
            g.DrawString(_progressText, font, textBrush, textX, textY);
          }
        }
      }
    }

    private void DrawIndeterminateProgress(Graphics g, Panel panel) {
      int progressWidth = (int)(panel.Width * 0.3f);
      float normalizedPosition = (float)(Math.Sin(_animationOffset) + 1) / 2;
      int position = (int)(normalizedPosition * (panel.Width - progressWidth));

      using (SolidBrush progressBrush = new SolidBrush(Color.FromArgb(150, _foreColor))) {
        g.FillRectangle(progressBrush, position, 0, progressWidth, panel.Height);
      }
    }

    internal void SetMessage(string message) {
      if (this.InvokeRequired) {
        this.Invoke(new Action<string>(SetMessage), message);
        return;
      }

      lblMessage.Text = message;
      AdjustFormSize();
      RecenterForm();
      this.Refresh();
    }

    internal void RecenterForm() {
      Screen currentScreen = Screen.FromPoint(this.Location);
      Rectangle workingArea = currentScreen.WorkingArea;

      this.Location = new Point(
          workingArea.Right - this.Width - 10,  // 10px de margem da borda direita
          workingArea.Bottom - this.Height - 10 // 10px de margem da borda inferior
      );
    }

    private void AdjustFormSize() {
      this.Width = lblMessage.Width + ptbIcon.Width + btnClose.Width + 40;
      this.Height = lblMessage.Height + pnlProgress.Height + 20;
    }

    // método para definir progresso determinado
    internal void SetProgress(int currentValue, int maxValue, string customText = null) {
      if (this.InvokeRequired) {
        this.Invoke(new Action<int, int, string>(SetProgress), currentValue, maxValue, customText);
        return;
      }

      _currentProgressValue = Math.Max(0, currentValue);
      _maxProgressValue = Math.Max(1, maxValue);
      _isDeterminateProgress = true;

      // Calcular porcentagem
      float percentage = (float)_currentProgressValue / _maxProgressValue * 100;

      // Definir texto de progresso
      if (!string.IsNullOrEmpty(customText)) {
        _progressText = customText;
      } else {
        _progressText = $"{_currentProgressValue}/{_maxProgressValue} ({percentage:F1}%)";
      }

      pnlProgress?.Invalidate();
    }

    // método para voltar ao progresso indeterminado
    internal void SetIndeterminateProgress() {
      if (this.InvokeRequired) {
        this.Invoke(new Action(SetIndeterminateProgress));
        return;
      }

      _isDeterminateProgress = false;
      _progressText = "";
      pnlProgress?.Invalidate();
    }

    private void BtnClose_Click(object sender, EventArgs e) {
      _isWorking = false;
      Loader._isWorking = false;
      StopAnimation();
      this.Close();
    }

    private void BtnClose_MouseEnter(object sender, EventArgs e) {
      btnClose.ForeColor = Color.Red;
    }

    private void BtnClose_MouseLeave(object sender, EventArgs e) {
      btnClose.ForeColor = _foreColor;
    }

    private void FrmLoadForm_FormClosing(object sender, FormClosingEventArgs e) {
      _isWorking = false;
      StopAnimation();
    }

    protected override void SetVisibleCore(bool value) {
      base.SetVisibleCore(value);
      if (value) {
        this.BringToFront();
      }
    }

  }
}
