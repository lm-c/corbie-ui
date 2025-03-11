
namespace LmCorbieUI.Controls
{
    partial class LmDataGridView
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LmDataGridView));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.lnkCsv = new System.Windows.Forms.PictureBox();
      this.lnkPdf = new System.Windows.Forms.PictureBox();
      this.lnkColunas = new System.Windows.Forms.PictureBox();
      this.lnkResraurarGrid = new System.Windows.Forms.PictureBox();
      this.tmrInicioLocalizar = new System.Windows.Forms.Timer(this.components);
      this.tmrInternal = new System.Windows.Forms.Timer(this.components);
      this.pnlGrid = new LmCorbieUI.Controls.LmPanel();
      this.lblMessage = new LmCorbieUI.Controls.LmLabel();
      this.Grid = new LmCorbieUI.Controls.LmDataGridMini();
      this.flpRodape = new LmCorbieUI.Controls.LmPanelFlow();
      this.flpBotoes = new LmCorbieUI.Controls.LmPanelFlow();
      this.lmDivisor = new LmCorbieUI.Controls.LmLabel();
      this.txtProcurar = new LmCorbieUI.Controls.LmTextBox();
      this.lblSep3 = new LmCorbieUI.Controls.LmLabel();
      this.lblTotal = new LmCorbieUI.Controls.LmLabel();
      ((System.ComponentModel.ISupportInitialize)(this.lnkCsv)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lnkPdf)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lnkColunas)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lnkResraurarGrid)).BeginInit();
      this.pnlGrid.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
      this.flpBotoes.SuspendLayout();
      this.SuspendLayout();
      // 
      // lnkCsv
      // 
      this.lnkCsv.BackColor = System.Drawing.Color.Transparent;
      this.lnkCsv.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lnkCsv.Image = ((System.Drawing.Image)(resources.GetObject("lnkCsv.Image")));
      this.lnkCsv.Location = new System.Drawing.Point(3, 3);
      this.lnkCsv.Margin = new System.Windows.Forms.Padding(3, 3, 1, 4);
      this.lnkCsv.Name = "lnkCsv";
      this.lnkCsv.Size = new System.Drawing.Size(20, 27);
      this.lnkCsv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.lnkCsv.TabIndex = 5;
      this.lnkCsv.TabStop = false;
      this.toolTip1.SetToolTip(this.lnkCsv, "Salvar Arquivo CSV da tabela atual");
      this.lnkCsv.Click += new System.EventHandler(this.LnkCsv_Click);
      this.lnkCsv.MouseEnter += new System.EventHandler(this.Ptb_MouseEnter);
      this.lnkCsv.MouseLeave += new System.EventHandler(this.Ptb_MouseLeave);
      // 
      // lnkPdf
      // 
      this.lnkPdf.BackColor = System.Drawing.Color.Transparent;
      this.lnkPdf.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lnkPdf.Image = ((System.Drawing.Image)(resources.GetObject("lnkPdf.Image")));
      this.lnkPdf.Location = new System.Drawing.Point(25, 3);
      this.lnkPdf.Margin = new System.Windows.Forms.Padding(1, 3, 1, 4);
      this.lnkPdf.Name = "lnkPdf";
      this.lnkPdf.Size = new System.Drawing.Size(20, 27);
      this.lnkPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.lnkPdf.TabIndex = 6;
      this.lnkPdf.TabStop = false;
      this.toolTip1.SetToolTip(this.lnkPdf, "Gerar PDF da tabela atual");
      this.lnkPdf.Click += new System.EventHandler(this.LnkPdf_Click);
      this.lnkPdf.MouseEnter += new System.EventHandler(this.Ptb_MouseEnter);
      this.lnkPdf.MouseLeave += new System.EventHandler(this.Ptb_MouseLeave);
      // 
      // lnkColunas
      // 
      this.lnkColunas.BackColor = System.Drawing.Color.Transparent;
      this.lnkColunas.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lnkColunas.Image = ((System.Drawing.Image)(resources.GetObject("lnkColunas.Image")));
      this.lnkColunas.Location = new System.Drawing.Point(60, 3);
      this.lnkColunas.Margin = new System.Windows.Forms.Padding(0, 3, 1, 4);
      this.lnkColunas.Name = "lnkColunas";
      this.lnkColunas.Size = new System.Drawing.Size(20, 27);
      this.lnkColunas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.lnkColunas.TabIndex = 8;
      this.lnkColunas.TabStop = false;
      this.toolTip1.SetToolTip(this.lnkColunas, "Configurações gerais do Grid");
      this.lnkColunas.Click += new System.EventHandler(this.LnkColunas_Click);
      this.lnkColunas.MouseEnter += new System.EventHandler(this.Ptb_MouseEnter);
      this.lnkColunas.MouseLeave += new System.EventHandler(this.Ptb_MouseLeave);
      // 
      // lnkResraurarGrid
      // 
      this.lnkResraurarGrid.BackColor = System.Drawing.Color.Transparent;
      this.lnkResraurarGrid.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lnkResraurarGrid.Image = ((System.Drawing.Image)(resources.GetObject("lnkResraurarGrid.Image")));
      this.lnkResraurarGrid.Location = new System.Drawing.Point(82, 3);
      this.lnkResraurarGrid.Margin = new System.Windows.Forms.Padding(1, 3, 3, 4);
      this.lnkResraurarGrid.Name = "lnkResraurarGrid";
      this.lnkResraurarGrid.Size = new System.Drawing.Size(20, 27);
      this.lnkResraurarGrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.lnkResraurarGrid.TabIndex = 13;
      this.lnkResraurarGrid.TabStop = false;
      this.toolTip1.SetToolTip(this.lnkResraurarGrid, "Restaurar formatação original");
      this.lnkResraurarGrid.Click += new System.EventHandler(this.LnkResraurarGrid_Click);
      this.lnkResraurarGrid.MouseEnter += new System.EventHandler(this.Ptb_MouseEnter);
      this.lnkResraurarGrid.MouseLeave += new System.EventHandler(this.Ptb_MouseLeave);
      // 
      // tmrInicioLocalizar
      // 
      this.tmrInicioLocalizar.Tag = "0";
      this.tmrInicioLocalizar.Tick += new System.EventHandler(this.TmrInicioLocalizar_Tick);
      // 
      // tmrInternal
      // 
      this.tmrInternal.Enabled = true;
      this.tmrInternal.Interval = 500;
      this.tmrInternal.Tag = "-1";
      this.tmrInternal.Tick += new System.EventHandler(this.TmrInternal_Tick);
      // 
      // pnlGrid
      // 
      this.pnlGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
      this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnlGrid.Controls.Add(this.lblMessage);
      this.pnlGrid.Controls.Add(this.Grid);
      this.pnlGrid.Controls.Add(this.flpRodape);
      this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlGrid.IsPanelMenu = false;
      this.pnlGrid.Location = new System.Drawing.Point(0, 0);
      this.pnlGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.pnlGrid.Name = "pnlGrid";
      this.pnlGrid.Size = new System.Drawing.Size(391, 207);
      this.pnlGrid.TabIndex = 0;
      // 
      // lblMessage
      // 
      this.lblMessage.BackColor = System.Drawing.Color.Transparent;
      this.lblMessage.FontSize = LmCorbieUI.Design.LmLabelSize.Tall;
      this.lblMessage.Location = new System.Drawing.Point(0, 0);
      this.lblMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.Size = new System.Drawing.Size(447, 49);
      this.lblMessage.TabIndex = 3;
      this.lblMessage.Text = "A consulta não retornou nenhum registro!";
      this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblMessage.Visible = false;
      this.lblMessage.WrapToLine = true;
      // 
      // Grid
      // 
      this.Grid.AllowUserToAddRows = false;
      this.Grid.AllowUserToDeleteRows = false;
      this.Grid.AllowUserToOrderColumns = true;
      this.Grid.AllowUserToResizeRows = false;
      this.Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
      this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
      this.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(18)))));
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.Grid.DefaultCellStyle = dataGridViewCellStyle2;
      this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Grid.EnableHeadersVisualStyles = false;
      this.Grid.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
      this.Grid.Location = new System.Drawing.Point(0, 0);
      this.Grid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Grid.MultiSelect = false;
      this.Grid.Name = "Grid";
      this.Grid.ReadOnly = true;
      this.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.Grid.RowHeadersVisible = false;
      this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.Grid.RowTemplate.Height = 25;
      this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.Grid.Size = new System.Drawing.Size(389, 183);
      this.Grid.TabIndex = 1;
      this.Grid.UseSelectable = true;
      this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
      this.Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
      this.Grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellEnter);
      this.Grid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_CellMouseUp);
      this.Grid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Grid_CellPainting);
      this.Grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellValueChanged);
      this.Grid.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.Grid_ColumnWidthChanged);
      this.Grid.Enter += new System.EventHandler(this.Grid_Enter);
      this.Grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Grid_KeyDown);
      this.Grid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Grid_MouseDown);
      // 
      // flpRodape
      // 
      this.flpRodape.AutoScroll = true;
      this.flpRodape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(215)))), ((int)(((byte)(242)))));
      this.flpRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.flpRodape.Location = new System.Drawing.Point(0, 183);
      this.flpRodape.Name = "flpRodape";
      this.flpRodape.Size = new System.Drawing.Size(389, 22);
      this.flpRodape.TabIndex = 4;
      this.flpRodape.UseCustomBackColor = true;
      this.flpRodape.WrapContents = false;
      // 
      // flpBotoes
      // 
      this.flpBotoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
      this.flpBotoes.Controls.Add(this.lnkCsv);
      this.flpBotoes.Controls.Add(this.lnkPdf);
      this.flpBotoes.Controls.Add(this.lmDivisor);
      this.flpBotoes.Controls.Add(this.lnkColunas);
      this.flpBotoes.Controls.Add(this.lnkResraurarGrid);
      this.flpBotoes.Controls.Add(this.txtProcurar);
      this.flpBotoes.Controls.Add(this.lblSep3);
      this.flpBotoes.Controls.Add(this.lblTotal);
      this.flpBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.flpBotoes.Location = new System.Drawing.Point(0, 207);
      this.flpBotoes.Name = "flpBotoes";
      this.flpBotoes.Size = new System.Drawing.Size(391, 33);
      this.flpBotoes.TabIndex = 0;
      // 
      // lmDivisor
      // 
      this.lmDivisor.AutoSize = true;
      this.lmDivisor.FontWeight = LmCorbieUI.Design.LmLabelWeight.Bold;
      this.lmDivisor.Location = new System.Drawing.Point(46, 7);
      this.lmDivisor.Margin = new System.Windows.Forms.Padding(0, 7, 0, 4);
      this.lmDivisor.Name = "lmDivisor";
      this.lmDivisor.Size = new System.Drawing.Size(14, 19);
      this.lmDivisor.TabIndex = 12;
      this.lmDivisor.Text = "|";
      // 
      // txtProcurar
      // 
      this.txtProcurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
      this.txtProcurar.BorderRadius = 0;
      this.txtProcurar.BorderSize = 2;
      this.txtProcurar.Dock = System.Windows.Forms.DockStyle.Top;
      this.txtProcurar.F7ToolTipText = null;
      this.txtProcurar.F8ToolTipText = null;
      this.txtProcurar.F9ToolTipText = null;
      this.txtProcurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.txtProcurar.Icon = ((System.Drawing.Image)(resources.GetObject("txtProcurar.Icon")));
      this.txtProcurar.IconF7 = null;
      this.txtProcurar.IconToolTipText = null;
      this.txtProcurar.Lines = new string[0];
      this.txtProcurar.Location = new System.Drawing.Point(108, 3);
      this.txtProcurar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
      this.txtProcurar.MaxLength = 32767;
      this.txtProcurar.Name = "txtProcurar";
      this.txtProcurar.PasswordChar = '\0';
      this.txtProcurar.Propriedade = null;
      this.txtProcurar.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.txtProcurar.SelectedText = "";
      this.txtProcurar.SelectionLength = 0;
      this.txtProcurar.SelectionStart = 0;
      this.txtProcurar.ShortcutsEnabled = true;
      this.txtProcurar.ShowClearButton = true;
      this.txtProcurar.ShowIcon = true;
      this.txtProcurar.Size = new System.Drawing.Size(130, 27);
      this.txtProcurar.TabIndex = 9;
      this.txtProcurar.UnderlinedStyle = true;
      this.txtProcurar.UseSelectable = true;
      this.txtProcurar.Valor_Decimais = ((short)(0));
      this.txtProcurar.WaterMark = "Procurar Por...";
      this.txtProcurar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
      this.txtProcurar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
      this.txtProcurar.TextChanged += new System.EventHandler(this.TxtProcurar_TextChanged);
      this.txtProcurar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtProcurar_KeyDown);
      // 
      // lblSep3
      // 
      this.lblSep3.AutoSize = true;
      this.lblSep3.FontWeight = LmCorbieUI.Design.LmLabelWeight.Bold;
      this.lblSep3.Location = new System.Drawing.Point(241, 7);
      this.lblSep3.Margin = new System.Windows.Forms.Padding(0, 7, 0, 4);
      this.lblSep3.Name = "lblSep3";
      this.lblSep3.Size = new System.Drawing.Size(14, 19);
      this.lblSep3.TabIndex = 11;
      this.lblSep3.Text = "|";
      // 
      // lblTotal
      // 
      this.lblTotal.AutoSize = true;
      this.lblTotal.Location = new System.Drawing.Point(255, 7);
      this.lblTotal.Margin = new System.Windows.Forms.Padding(0, 7, 3, 4);
      this.lblTotal.Name = "lblTotal";
      this.lblTotal.Size = new System.Drawing.Size(105, 19);
      this.lblTotal.TabIndex = 10;
      this.lblTotal.Text = "Registro: 0 de 0";
      // 
      // LmDataGridView
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.Controls.Add(this.pnlGrid);
      this.Controls.Add(this.flpBotoes);
      this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.Margin = new System.Windows.Forms.Padding(0);
      this.Name = "LmDataGridView";
      this.Size = new System.Drawing.Size(391, 240);
      this.Load += new System.EventHandler(this.LmDataGridView_Load);
      ((System.ComponentModel.ISupportInitialize)(this.lnkCsv)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lnkPdf)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lnkColunas)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lnkResraurarGrid)).EndInit();
      this.pnlGrid.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
      this.flpBotoes.ResumeLayout(false);
      this.flpBotoes.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private Controls.LmPanel pnlGrid;
        private Controls.LmPanelFlow flpBotoes;
        public LmDataGridMini Grid;
        private LmLabel lblMessage;
        private System.Windows.Forms.PictureBox lnkCsv;
        private System.Windows.Forms.PictureBox lnkPdf;
        private System.Windows.Forms.PictureBox lnkColunas;
        private LmTextBox txtProcurar;
        private LmLabel lmDivisor;
        private System.Windows.Forms.PictureBox lnkResraurarGrid;
        private LmLabel lblSep3;
        private LmLabel lblTotal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer tmrInicioLocalizar;
        private System.Windows.Forms.Timer tmrInternal;
    public LmPanelFlow flpRodape;
  }
}
