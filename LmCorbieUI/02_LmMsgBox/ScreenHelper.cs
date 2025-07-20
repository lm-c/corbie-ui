using System;
using System.Drawing;
using System.Windows.Forms;

namespace LmCorbieUI {
  public static class ScreenHelper {
    /// <summary>
    /// Obtém a tela onde o mouse está posicionado
    /// </summary>
    /// <returns>Screen onde o mouse está localizado</returns>
    public static Screen GetScreenFromMouse() {
      Point mousePosition = Control.MousePosition;
      return Screen.FromPoint(mousePosition);
    }

    /// <summary>
    /// Centraliza um formulário na tela especificada
    /// </summary>
    /// <param name="form">Formulário a ser centralizado</param>
    /// <param name="screen">Tela onde centralizar</param>
    public static void CenterFormOnScreen(Form form, Screen screen) {
      Rectangle workingArea = screen.WorkingArea;

      int x = workingArea.X + (workingArea.Width - form.Width) / 2;
      int y = workingArea.Y + (workingArea.Height - form.Height) / 2;

      form.Location = new Point(x, y);
    }

    /// <summary>
    /// Posiciona o formulário próximo ao mouse, mas garantindo que fique visível
    /// </summary>
    /// <param name="form">Formulário a ser posicionado</param>
    public static void PositionFormNearMouse(Form form) {
      Point mousePosition = Control.MousePosition;
      Screen currentScreen = Screen.FromPoint(mousePosition);
      Rectangle workingArea = currentScreen.WorkingArea;

      // Offset do mouse para evitar que o formulário cubra o cursor
      int offsetX = 20;
      int offsetY = 20;

      int x = mousePosition.X + offsetX;
      int y = mousePosition.Y + offsetY;

      // Verifica se o formulário cabe na tela a partir da posição calculada
      if (x + form.Width > workingArea.Right)
        x = workingArea.Right - form.Width;

      if (y + form.Height > workingArea.Bottom)
        y = workingArea.Bottom - form.Height;

      // Garante que não saia da área de trabalho
      if (x < workingArea.Left)
        x = workingArea.Left;

      if (y < workingArea.Top)
        y = workingArea.Top;

      form.Location = new Point(x, y);
    }
  }
}
