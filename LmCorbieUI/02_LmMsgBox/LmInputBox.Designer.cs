
namespace LmCorbieUI
{
    partial class LmInputBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LmInputBox));
      this.lblTitulo = new LmCorbieUI.Controls.LmLabel();
      this.lblDesc = new LmCorbieUI.Controls.LmLabel();
      this.btnCancelar = new LmCorbieUI.Controls.LmButton();
      this.btnConfirmar = new LmCorbieUI.Controls.LmButton();
      this.txt = new LmCorbieUI.Controls.LmTextBox();
      this.SuspendLayout();
      // 
      // lblTitulo
      // 
      this.lblTitulo.AutoSize = true;
      this.lblTitulo.Location = new System.Drawing.Point(15, 5);
      this.lblTitulo.Margin = new System.Windows.Forms.Padding(3);
      this.lblTitulo.Name = "lblTitulo";
      this.lblTitulo.Size = new System.Drawing.Size(64, 19);
      this.lblTitulo.TabIndex = 0;
      this.lblTitulo.Text = "lmLabel1";
      // 
      // lblDesc
      // 
      this.lblDesc.AutoSize = true;
      this.lblDesc.Location = new System.Drawing.Point(44, 28);
      this.lblDesc.Margin = new System.Windows.Forms.Padding(3);
      this.lblDesc.Name = "lblDesc";
      this.lblDesc.Size = new System.Drawing.Size(64, 19);
      this.lblDesc.TabIndex = 1;
      this.lblDesc.Text = "lmLabel2";
      // 
      // btnCancelar
      // 
      this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.btnCancelar.BorderRadius = 15;
      this.btnCancelar.BorderSize = 0;
      this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
      this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnCancelar.Location = new System.Drawing.Point(227, 81);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(94, 26);
      this.btnCancelar.TabIndex = 2;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnCancelar.UseVisualStyleBackColor = false;
      this.btnCancelar.Visible = false;
      this.btnCancelar.Click += new System.EventHandler(this.Txt_ButtonClickF8);
      // 
      // btnConfirmar
      // 
      this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnConfirmar.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.btnConfirmar.BorderRadius = 15;
      this.btnConfirmar.BorderSize = 0;
      this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
      this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnConfirmar.Location = new System.Drawing.Point(127, 81);
      this.btnConfirmar.Name = "btnConfirmar";
      this.btnConfirmar.Size = new System.Drawing.Size(94, 26);
      this.btnConfirmar.TabIndex = 1;
      this.btnConfirmar.Text = " Confirmar";
      this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnConfirmar.UseVisualStyleBackColor = false;
      this.btnConfirmar.Visible = false;
      this.btnConfirmar.Click += new System.EventHandler(this.Txt_ButtonClickF7);
      // 
      // txt
      // 
      this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
      this.txt.BorderRadius = 14;
      this.txt.BorderSize = 2;
      this.txt.F7ToolTipText = null;
      this.txt.F8ToolTipText = null;
      this.txt.F9ToolTipText = null;
      this.txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.txt.IconF7 = ((System.Drawing.Image)(resources.GetObject("txt.IconF7")));
      this.txt.IconF8 = ((System.Drawing.Image)(resources.GetObject("txt.IconF8")));
      this.txt.IconToolTipText = null;
      this.txt.Lines = new string[0];
      this.txt.Location = new System.Drawing.Point(44, 46);
      this.txt.MaxLength = 32767;
      this.txt.Name = "txt";
      this.txt.PasswordChar = '\0';
      this.txt.Propriedade = null;
      this.txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.txt.SelectedText = "";
      this.txt.SelectionLength = 0;
      this.txt.SelectionStart = 0;
      this.txt.ShortcutsEnabled = true;
      this.txt.ShowButtonF7 = true;
      this.txt.ShowButtonF8 = true;
      this.txt.Size = new System.Drawing.Size(277, 29);
      this.txt.TabIndex = 0;
      this.txt.UnderlinedStyle = false;
      this.txt.UseSelectable = true;
      this.txt.Valor_Decimais = ((short)(0));
      this.txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
      this.txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
      this.txt.ButtonClickF7 += new LmCorbieUI.Controls.LmTextBox.ButClick(this.Txt_ButtonClickF7);
      this.txt.ButtonClickF8 += new LmCorbieUI.Controls.LmTextBox.ButClick(this.Txt_ButtonClickF8);
      this.txt.SelectedValueChanched += new LmCorbieUI.Controls.LmTextBox.ValChange(this.Txt_SelectedValueChanched);
      this.txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
      // 
      // LmInputBox
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(365, 86);
      this.ControlBox = false;
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnConfirmar);
      this.Controls.Add(this.txt);
      this.Controls.Add(this.lblDesc);
      this.Controls.Add(this.lblTitulo);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Location = new System.Drawing.Point(0, 0);
      this.Name = "LmInputBox";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "FrmImputBox";
      this.SizeChanged += new System.EventHandler(this.LmImputBox_SizeChanged);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private Controls.LmLabel lblTitulo;
        private Controls.LmLabel lblDesc;
        private Controls.LmButton btnConfirmar;
        private Controls.LmButton btnCancelar;
        internal Controls.LmTextBox txt;
    }
}