namespace LmCorbieUI {
  partial class FrmToastForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmToastForm));
      this.ptbIcon = new System.Windows.Forms.PictureBox();
      this.lblMessage = new System.Windows.Forms.Label();
      this.btnClose = new System.Windows.Forms.Button();
      this.pnlBackground = new System.Windows.Forms.Panel();
      this.pnlProgress = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
      this.pnlBackground.SuspendLayout();
      this.SuspendLayout();
      // 
      // ptbIcon
      // 
      this.ptbIcon.BackColor = System.Drawing.Color.Transparent;
      this.ptbIcon.Dock = System.Windows.Forms.DockStyle.Left;
      this.ptbIcon.Location = new System.Drawing.Point(6, 0);
      this.ptbIcon.Name = "ptbIcon";
      this.ptbIcon.Padding = new System.Windows.Forms.Padding(3);
      this.ptbIcon.Size = new System.Drawing.Size(18, 60);
      this.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.ptbIcon.TabIndex = 0;
      this.ptbIcon.TabStop = false;
      // 
      // lblMessage
      // 
      this.lblMessage.AutoSize = true;
      this.lblMessage.BackColor = System.Drawing.Color.Transparent;
      this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMessage.Location = new System.Drawing.Point(24, 0);
      this.lblMessage.MaximumSize = new System.Drawing.Size(450, 250);
      this.lblMessage.MinimumSize = new System.Drawing.Size(160, 60);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.Padding = new System.Windows.Forms.Padding(6);
      this.lblMessage.Size = new System.Drawing.Size(160, 60);
      this.lblMessage.TabIndex = 0;
      this.lblMessage.Text = "Sucesso!";
      this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.Transparent;
      this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
      this.btnClose.FlatAppearance.BorderSize = 0;
      this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Location = new System.Drawing.Point(189, 0);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(21, 60);
      this.btnClose.TabIndex = 1;
      this.btnClose.TabStop = false;
      this.btnClose.Text = "X";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
      this.btnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
      this.btnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
      // 
      // pnlBackground
      // 
      this.pnlBackground.Controls.Add(this.lblMessage);
      this.pnlBackground.Controls.Add(this.ptbIcon);
      this.pnlBackground.Controls.Add(this.btnClose);
      this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlBackground.Location = new System.Drawing.Point(0, 6);
      this.pnlBackground.Name = "pnlBackground";
      this.pnlBackground.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
      this.pnlBackground.Size = new System.Drawing.Size(210, 60);
      this.pnlBackground.TabIndex = 2;
      // 
      // pnlProgress
      // 
      this.pnlProgress.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.pnlProgress.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlProgress.Location = new System.Drawing.Point(0, 0);
      this.pnlProgress.Name = "pnlProgress";
      this.pnlProgress.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
      this.pnlProgress.Size = new System.Drawing.Size(210, 6);
      this.pnlProgress.TabIndex = 3;
      // 
      // FrmToastForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlDark;
      this.ClientSize = new System.Drawing.Size(210, 66);
      this.Controls.Add(this.pnlBackground);
      this.Controls.Add(this.pnlProgress);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmToastForm";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "FrmToastForm";
      this.TopMost = true;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmToastForm_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
      this.pnlBackground.ResumeLayout(false);
      this.pnlBackground.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox ptbIcon;
    private System.Windows.Forms.Label lblMessage;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Panel pnlBackground;
    private System.Windows.Forms.Panel pnlProgress;
  }
}