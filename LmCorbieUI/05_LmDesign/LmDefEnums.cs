using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmCorbieUI.Design {
  public enum LmValueType {
    [Description("Texto")]
    Alfanumerico = 0,
    [Description("Número Inteiro")]
    Num_Inteiro = 1,
    [Description("Número Decimal")]
    Num_Real = 2,
    [Description("Data")]
    Data = 3,
    [Description("Fone")]
    Fone = 4,
    [Description("Monetário")]
    Monetario = 5,
    [Description("E-mail")]
    Email = 6,
    [Description("CPF/CNPJ")]
    Cpf_Cnpj = 7,
    [Description("Hora")]
    Hora = 8,
    ComboBox = 9,
    ComboBox_Enum = 10,
    Senha = 11,
  }

  public enum LmTransactionType {
    Novo = 0,
    Alterar = 1,
    Excluir = 2,
    Login = 3,
    Diversos = 99,
  }

  public enum LmControlStatus {
    Normal = 0,
    Selected = 1,
    Disabled = 2,
  }

  public enum ButtonStyle {
    Default = 0,
    Information = 1,
    Question = 2,
    Warning = 3,
    Error = 4,
    Gray = 5,
  }

}
