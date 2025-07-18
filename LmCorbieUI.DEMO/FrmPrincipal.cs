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

    private void menuSequenciaCad_Click(object sender, EventArgs e) {
      TestIndeterminateProgress();
    }

    public static async Task TestIndeterminateProgress() {
      // Teste 1: Progresso Indeterminado Simples
      await Loader.ShowDuringOperation(async (progress) => {
        progress.Report("Iniciando operação...");
        await Task.Delay(1000);

        progress.Report("Processando dados...");
        await Task.Delay(5000);

        if (!Loader._isWorking) {
          Toast.Info("Operação cancelada pelo usuário.");
          return;
        }

        progress.Report("Finalizando...");
        await Task.Delay(3000);
      });

      // Teste 2: Progresso Determinado com Passos
      await Loader.ShowDuringOperation(
          "Iniciando download...",
          async (progress) => {
            var total = 8;
            for (int i = 0; i <= total; i += 1) {
              if (!Loader._isWorking) {
                Toast.Info("Operação cancelada pelo usuário.");
                return "Cancelado";
              }
              progress.Report(($"Baixando arquivo... {i}", i, total));
              await Task.Delay(500);
            }
            return "Download concluído";
          },
          100
      );

      // Teste 3: Mensagens Longas
      await Loader.ShowDuringOperation(async (progress) => {
        progress.Report("Mensagem curta");
        await Task.Delay(2000);

        progress.Report("Esta é uma mensagem um pouco mais longa para testar o redimensionamento");
        await Task.Delay(3000);

        progress.Report("Esta é uma mensagem extremamente longa que vai testar como o componente se comporta com textos muito extensos e se o redimensionamento funciona corretamente em todas as situações possíveis!");
        await Task.Delay(4000);

        if (!Loader._isWorking) {
          Toast.Info("Operação cancelada pelo usuário.");
          return;
        }

        progress.Report("Volta ao normal");
        await Task.Delay(1000);
      });

      // Teste 4: Progresso Rápido (Stress Test)
      await Loader.ShowDuringOperation(
          "Teste de velocidade...",
          async (progress) => {
            for (int i = 0; i <= 1000; i++) {
              if (!Loader._isWorking) {
                Toast.Info("Operação cancelada pelo usuário.");
                return "Cancelado";
              }

                progress.Report(($"Processando item {i}", i, 1000));
              await Task.Delay(10); // Muito rápido
            }
            return "Teste concluído";
          },
          1000
      );

      // Teste 5: Simulação de Erro
      try {
        await Loader.ShowDuringOperation(async (progress) => {
          progress.Report("Iniciando operação...");
          await Task.Delay(1000);

          progress.Report("Processando...");
          await Task.Delay(2000);

          progress.Report("Erro detectado!");
          await Task.Delay(1000);

          throw new Exception("Erro simulado para teste");
        });
      } catch (Exception ex) {
        Toast.Error($"Erro capturado: {ex.Message}");
      }

      // Teste 6: Teste de Cancelamento Manual
      Loader.Show("Operação manual iniciada...");

      // Simular trabalho com timer
      var timer = new System.Windows.Forms.Timer();
      int counter = 0;

      timer.Interval = 1000;
      timer.Tick += (s, e) => {
        counter++;
        if (counter <= 5) {
          Loader.Show($"Processando... {counter}/5", counter, 5);
        } else {
          timer.Stop();
          timer.Dispose();
          Loader.Hide();
          Toast.Info("Operação manual concluída!");
        }
      };

      timer.Start();

      // Teste 7: Progresso com UpdateProgress
      Loader.Show("Iniciando processamento...", 0, 100);

      for (int i = 0; i <= 100; i += 5) {
        if (!Loader._isWorking) {
          Toast.Info("Operação cancelada pelo usuário.");
          return;
        }
        await Task.Delay(200);
        Loader.UpdateProgress(i, 100, $"Progresso: {i}%");
      }

      await Task.Delay(1000);
      Loader.Hide();

      // Teste 8: Simulação de Download com Velocidade Variável
      await Loader.ShowDuringOperation(
        "Simulando download...",
        async (progress) => {
          int totalSize = 1000;
          int downloaded = 0;

          while (downloaded < totalSize) {
            if (!Loader._isWorking) {
              Toast.Info("Operação cancelada pelo usuário.");
              return "Cancelado";
            }
            // Simular velocidade variável
            int chunk = new Random().Next(10, 50);
            downloaded = Math.Min(downloaded + chunk, totalSize);

            double percentage = (double)downloaded / totalSize * 100;
            string speedText = $"{downloaded}/{totalSize} KB ({percentage:F1}%)";

            progress.Report(($"Download em progresso...", downloaded, totalSize));

            // Velocidade variável de delay
            await Task.Delay(new Random().Next(100, 500));
          }

          return "Download concluído";
        },
        1000
        );

    }
  }
}
