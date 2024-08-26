namespace LmCorbieUI.DEMO
{
    partial class FrmSingle
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
      this.lmGroupBox1 = new LmCorbieUI.Controls.LmGroupBox();
      this.SuspendLayout();
      // 
      // lmGroupBox1
      // 
      this.lmGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
      this.lmGroupBox1.Location = new System.Drawing.Point(35, 53);
      this.lmGroupBox1.Name = "lmGroupBox1";
      this.lmGroupBox1.Size = new System.Drawing.Size(272, 244);
      this.lmGroupBox1.TabIndex = 0;
      this.lmGroupBox1.TabStop = false;
      this.lmGroupBox1.Text = "lmGroupBox1";
      // 
      // FrmSingle
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 328);
      this.Controls.Add(this.lmGroupBox1);
      this.Location = new System.Drawing.Point(0, 0);
      this.Name = "FrmSingle";
      this.Padding = new System.Windows.Forms.Padding(2, 30, 2, 2);
      this.Text = "Formulário Simples";
      this.ResumeLayout(false);

        }

    #endregion

    private Controls.LmGroupBox lmGroupBox1;
  }
}