﻿namespace LmMessageBox
{
    partial class FrmMsgWait
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMsgWait));
      this.lblMessage = new System.Windows.Forms.Label();
      this.timer = new System.Windows.Forms.Timer(this.components);
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.lblClose = new System.Windows.Forms.Label();
      this.contextMenuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.SuspendLayout();
      // 
      // lblMessage
      // 
      this.lblMessage.BackColor = System.Drawing.Color.Transparent;
      this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F);
      this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
      this.lblMessage.Location = new System.Drawing.Point(20, 1);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.Size = new System.Drawing.Size(270, 35);
      this.lblMessage.TabIndex = 9;
      this.lblMessage.Text = "Aguarde...";
      this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblMessage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMsgWait_MouseDown);
      this.lblMessage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMsgWait_MouseMove);
      this.lblMessage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMsgWait_MouseUp);
      // 
      // timer
      // 
      this.timer.Enabled = true;
      this.timer.Tag = "0,0";
      this.timer.Tick += new System.EventHandler(this.Timer_Tick);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(110, 26);
      // 
      // fecharToolStripMenuItem
      // 
      this.fecharToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fecharToolStripMenuItem.Image")));
      this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
      this.fecharToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
      this.fecharToolStripMenuItem.Text = "Fechar";
      this.fecharToolStripMenuItem.Click += new System.EventHandler(this.FecharToolStripMenuItem_Click);
      // 
      // pictureBox2
      // 
      this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
      this.pictureBox2.Location = new System.Drawing.Point(20, 36);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(270, 15);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox2.TabIndex = 40;
      this.pictureBox2.TabStop = false;
      this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMsgWait_MouseDown);
      this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMsgWait_MouseMove);
      this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMsgWait_MouseUp);
      // 
      // lblClose
      // 
      this.lblClose.AutoSize = true;
      this.lblClose.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblClose.ForeColor = System.Drawing.Color.Firebrick;
      this.lblClose.Location = new System.Drawing.Point(286, 2);
      this.lblClose.Name = "lblClose";
      this.lblClose.Size = new System.Drawing.Size(21, 18);
      this.lblClose.TabIndex = 41;
      this.lblClose.Text = "X";
      this.lblClose.Visible = false;
      this.lblClose.Click += new System.EventHandler(this.LblClose_Click);
      this.lblClose.MouseEnter += new System.EventHandler(this.LblClose_MouseEnter);
      this.lblClose.MouseLeave += new System.EventHandler(this.LblClose_MouseLeave);
      // 
      // FrmMsgWait
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
      this.ClientSize = new System.Drawing.Size(310, 61);
      this.ContextMenuStrip = this.contextMenuStrip1;
      this.ControlBox = false;
      this.Controls.Add(this.lblClose);
      this.Controls.Add(this.lblMessage);
      this.Controls.Add(this.pictureBox2);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmMsgWait";
      this.Padding = new System.Windows.Forms.Padding(20, 1, 20, 10);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "frmMsgWait";
      this.Load += new System.EventHandler(this.FrmMsgWait_Load);
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMsgWait_MouseDown);
      this.MouseEnter += new System.EventHandler(this.FrmMsgWait_MouseEnter);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMsgWait_MouseMove);
      this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMsgWait_MouseUp);
      this.contextMenuStrip1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.Label lblClose;
  }
}

