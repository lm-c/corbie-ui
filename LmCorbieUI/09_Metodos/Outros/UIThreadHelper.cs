using System;
using System.Windows.Forms;

namespace LmCorbieUI {
  public static class UIThreadHelper {
    /// <summary>
    /// Executa a ação no thread da UI, se necessário.
    /// </summary>
    /// <param name="control">Controle usado como referência para thread da UI.</param>
    /// <param name="action">Ação a ser executada.</param>
    public static void Invoke(Control control, Action action) {
      if (control.InvokeRequired)
        control.Invoke(action);
      else
        action();
    }

    /// <summary>
    /// Executa a função no thread da UI, se necessário, e retorna valor.
    /// </summary>
    /// <typeparam name="T">Tipo de retorno</typeparam>
    /// <param name="control">Controle usado como referência para thread da UI.</param>
    /// <param name="func">Função a ser executada.</param>
    /// <returns>Resultado da função</returns>
    public static T Invoke<T>(Control control, Func<T> func) {
      if (control.InvokeRequired)
        return (T)control.Invoke(func);
      else
        return func();
    }
  }
}
