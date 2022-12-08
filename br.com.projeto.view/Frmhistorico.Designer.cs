namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    partial class Frmhistorico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmhistorico));
            this.pnlTituloPagHis = new System.Windows.Forms.Panel();
            this.lblTituloHistorico = new System.Windows.Forms.Label();
            this.grpDatas = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFim = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.pnlTituloPagHis.SuspendLayout();
            this.grpDatas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTituloPagHis
            // 
            this.pnlTituloPagHis.BackColor = System.Drawing.Color.Purple;
            this.pnlTituloPagHis.Controls.Add(this.lblTituloHistorico);
            this.pnlTituloPagHis.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloPagHis.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloPagHis.Margin = new System.Windows.Forms.Padding(6);
            this.pnlTituloPagHis.Name = "pnlTituloPagHis";
            this.pnlTituloPagHis.Size = new System.Drawing.Size(1024, 100);
            this.pnlTituloPagHis.TabIndex = 4;
            // 
            // lblTituloHistorico
            // 
            this.lblTituloHistorico.AutoSize = true;
            this.lblTituloHistorico.Font = new System.Drawing.Font("Cascadia Code", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHistorico.Location = new System.Drawing.Point(315, 37);
            this.lblTituloHistorico.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTituloHistorico.Name = "lblTituloHistorico";
            this.lblTituloHistorico.Size = new System.Drawing.Size(462, 49);
            this.lblTituloHistorico.TabIndex = 1;
            this.lblTituloHistorico.Text = "Histórico de Vendas ";
            // 
            // grpDatas
            // 
            this.grpDatas.Controls.Add(this.btnPesquisar);
            this.grpDatas.Controls.Add(this.dtpFim);
            this.grpDatas.Controls.Add(this.dtpInicio);
            this.grpDatas.Controls.Add(this.lblFim);
            this.grpDatas.Controls.Add(this.lblDataInicio);
            this.grpDatas.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatas.ForeColor = System.Drawing.Color.White;
            this.grpDatas.Location = new System.Drawing.Point(14, 109);
            this.grpDatas.Name = "grpDatas";
            this.grpDatas.Size = new System.Drawing.Size(995, 130);
            this.grpDatas.TabIndex = 5;
            this.grpDatas.TabStop = false;
            this.grpDatas.Text = "Consultar";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(780, 49);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(162, 49);
            this.btnPesquisar.TabIndex = 24;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtpFim
            // 
            this.dtpFim.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(557, 53);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(165, 35);
            this.dtpFim.TabIndex = 9;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(191, 54);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(165, 35);
            this.dtpInicio.TabIndex = 8;
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFim.ForeColor = System.Drawing.Color.White;
            this.lblFim.Location = new System.Drawing.Point(424, 59);
            this.lblFim.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(108, 28);
            this.lblFim.TabIndex = 7;
            this.lblFim.Text = "Data Fim";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicio.ForeColor = System.Drawing.Color.White;
            this.lblDataInicio.Location = new System.Drawing.Point(23, 60);
            this.lblDataInicio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(144, 28);
            this.lblDataInicio.TabIndex = 6;
            this.lblDataInicio.Text = "Data Início";
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.AllowUserToAddRows = false;
            this.dgvHistorico.AllowUserToDeleteRows = false;
            this.dgvHistorico.BackgroundColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorico.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorico.GridColor = System.Drawing.Color.Silver;
            this.dgvHistorico.Location = new System.Drawing.Point(15, 254);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorico.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistorico.Size = new System.Drawing.Size(994, 307);
            this.dgvHistorico.TabIndex = 23;
            this.dgvHistorico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorico_CellClick);
            // 
            // Frmhistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1024, 573);
            this.Controls.Add(this.dgvHistorico);
            this.Controls.Add(this.grpDatas);
            this.Controls.Add(this.pnlTituloPagHis);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frmhistorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico";
            this.Load += new System.EventHandler(this.Frmhistorico_Load);
            this.pnlTituloPagHis.ResumeLayout(false);
            this.pnlTituloPagHis.PerformLayout();
            this.grpDatas.ResumeLayout(false);
            this.grpDatas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTituloPagHis;
        private System.Windows.Forms.Label lblTituloHistorico;
        private System.Windows.Forms.GroupBox grpDatas;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.DataGridView dgvHistorico;
        private System.Windows.Forms.Button btnPesquisar;
    }
}