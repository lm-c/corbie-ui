using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmCorbieUI {
  public class DefaultObject { 
    [DisplayName("Código")]
    [DataObjectField(true, false)]
    public int Codigo { get; set; }

    [DisplayName("Descrição")]
    [DataObjectField(false, true)]
    public string Descricao { get; set; }
  }
}
