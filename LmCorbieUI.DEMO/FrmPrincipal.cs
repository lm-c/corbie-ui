using LmCorbieUI.LmForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LmCorbieUI.DEMO {
  public partial class FrmPrincipal : LmMainForm {
    public FrmPrincipal() {
      InitializeComponent();
    }

    private void lmMenuItem3_Click(object sender, EventArgs e) {

    }

    private void Form1_Load(object sender, EventArgs e) {
    }

    private void menuSistema_Click(object sender, EventArgs e) {
    }

    private void menuDadosEmpresa_Click(object sender, EventArgs e) {
      FrmSingle frm = new FrmSingle();
      frm.ShowDialog();
    }

    private void menuUsuarioCad_Click(object sender, EventArgs e) {
      this.OpenFormChild(new FrmChild());

    }

    private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e) {

    }

    int cont = 1;
    private void menuProcessoCad_Click(object sender, EventArgs e) {
      switch (cont) {
        case 1:
        Toast.Error("Teste de Sistema.\r\nasfdasda sdas ads\r\n´poitoy´tiyp´tyitpor\r\n409387534890347594857  43574357349087 53490\r\nfdff sdf sdsdf sdf sdf\r\nxxxxxxxxxxxxxxxxxxx\r\nccccccccccccc");
        cont = 2;
        break;
        case 2:
        Toast.Warning("Apenas um Olá!\r\nApenas um Olá!");
        cont = 3;
        break;
        case 3:
        Toast.Success("Apenas um Olá 2! Apenas um Olá! Apenas um Olá!");
        cont = 4;
        break;
        case 4:
        Toast.Info("Apenas um Olá 3!");
        cont = 5;
        break;
        case 5:
        Toast.Black("Apenas um Olá 4!");
        cont = 1;
        break;
        default:
        break;
      }
    }
  }
}
