namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    partial class Frmdetalhes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmdetalhes));
            this.pnlTituloPagDetalhes = new System.Windows.Forms.Panel();
            this.lblTituloDetalhes = new System.Windows.Forms.Label();
            this.grpDadosVenda = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.txtDataVenda = new System.Windows.Forms.TextBox();
            this.lblDataVenda = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.dgvDadosVenda = new System.Windows.Forms.DataGridView();
            this.pnlTituloPagDetalhes.SuspendLayout();
            this.grpDadosVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTituloPagDetalhes
            // 
            this.pnlTituloPagDetalhes.BackColor = System.Drawing.Color.Purple;
            this.pnlTituloPagDetalhes.Controls.Add(this.lblTituloDetalhes);
            this.pnlTituloPagDetalhes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloPagDetalhes.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloPagDetalhes.Margin = new System.Windows.Forms.Padding(6);
            this.pnlTituloPagDetalhes.Name = "pnlTituloPagDetalhes";
            this.pnlTituloPagDetalhes.Size = new System.Drawing.Size(896, 100);
            this.pnlTituloPagDetalhes.TabIndex = 5;
            // 
            // lblTituloDetalhes
            // 
            this.lblTituloDetalhes.AutoSize = true;
            this.lblTituloDetalhes.Font = new System.Drawing.Font("Cascadia Code", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDetalhes.Location = new System.Drawing.Point(273, 40);
            this.lblTituloDetalhes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTituloDetalhes.Name = "lblTituloDetalhes";
            this.lblTituloDetalhes.Size = new System.Drawing.Size(374, 49);
            this.lblTituloDetalhes.TabIndex = 1;
            this.lblTituloDetalhes.Text = "Detalhe da Venda";
            // 
            // grpDadosVenda
            // 
            this.grpDadosVenda.Controls.Add(this.txtObs);
            this.grpDadosVenda.Controls.Add(this.lblObs);
            this.grpDadosVenda.Controls.Add(this.txtTotalVenda);
            this.grpDadosVenda.Controls.Add(this.lblTotalVenda);
            this.grpDadosVenda.Controls.Add(this.txtDataVenda);
            this.grpDadosVenda.Controls.Add(this.lblDataVenda);
            this.grpDadosVenda.Controls.Add(this.txtNomeCliente);
            this.grpDadosVenda.Controls.Add(this.lblNomeCliente);
            this.grpDadosVenda.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDadosVenda.ForeColor = System.Drawing.Color.White;
            this.grpDadosVenda.Location = new System.Drawing.Point(13, 124);
            this.grpDadosVenda.Name = "grpDadosVenda";
            this.grpDadosVenda.Size = new System.Drawing.Size(866, 285);
            this.grpDadosVenda.TabIndex = 6;
            this.grpDadosVenda.TabStop = false;
            this.grpDadosVenda.Text = "Dados da Venda";
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(506, 133);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ReadOnly = true;
            this.txtObs.Size = new System.Drawing.Size(330, 134);
            this.txtObs.TabIndex = 13;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.ForeColor = System.Drawing.Color.White;
            this.lblObs.Location = new System.Drawing.Point(424, 136);
            this.lblObs.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(60, 28);
            this.lblObs.TabIndex = 12;
            this.lblObs.Text = "Obs:";
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVenda.Location = new System.Drawing.Point(634, 64);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.ReadOnly = true;
            this.txtTotalVenda.Size = new System.Drawing.Size(202, 32);
            this.txtTotalVenda.TabIndex = 11;
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.AutoSize = true;
            this.lblTotalVenda.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenda.ForeColor = System.Drawing.Color.White;
            this.lblTotalVenda.Location = new System.Drawing.Point(424, 68);
            this.lblTotalVenda.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(192, 28);
            this.lblTotalVenda.TabIndex = 10;
            this.lblTotalVenda.Text = "Total da Venda:";
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataVenda.Location = new System.Drawing.Point(160, 120);
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.ReadOnly = true;
            this.txtDataVenda.Size = new System.Drawing.Size(223, 32);
            this.txtDataVenda.TabIndex = 9;
            // 
            // lblDataVenda
            // 
            this.lblDataVenda.AutoSize = true;
            this.lblDataVenda.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataVenda.ForeColor = System.Drawing.Color.White;
            this.lblDataVenda.Location = new System.Drawing.Point(23, 120);
            this.lblDataVenda.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDataVenda.Name = "lblDataVenda";
            this.lblDataVenda.Size = new System.Drawing.Size(72, 28);
            this.lblDataVenda.TabIndex = 8;
            this.lblDataVenda.Text = "Data:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(160, 65);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(223, 32);
            this.txtNomeCliente.TabIndex = 7;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.ForeColor = System.Drawing.Color.White;
            this.lblNomeCliente.Location = new System.Drawing.Point(23, 69);
            this.lblNomeCliente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(108, 28);
            this.lblNomeCliente.TabIndex = 6;
            this.lblNomeCliente.Text = "Cliente:";
            // 
            // dgvDadosVenda
            // 
            this.dgvDadosVenda.AllowUserToAddRows = false;
            this.dgvDadosVenda.AllowUserToDeleteRows = false;
            this.dgvDadosVenda.BackgroundColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDadosVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDadosVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDadosVenda.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDadosVenda.GridColor = System.Drawing.Color.Fuchsia;
            this.dgvDadosVenda.Location = new System.Drawing.Point(13, 424);
            this.dgvDadosVenda.Name = "dgvDadosVenda";
            this.dgvDadosVenda.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDadosVenda.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDadosVenda.Size = new System.Drawing.Size(871, 214);
            this.dgvDadosVenda.TabIndex = 24;
            // 
            // Frmdetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(896, 650);
            this.Controls.Add(this.dgvDadosVenda);
            this.Controls.Add(this.grpDadosVenda);
            this.Controls.Add(this.pnlTituloPagDetalhes);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frmdetalhes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes";
            this.Load += new System.EventHandler(this.Frmdetalhes_Load);
            this.pnlTituloPagDetalhes.ResumeLayout(false);
            this.pnlTituloPagDetalhes.PerformLayout();
            this.grpDadosVenda.ResumeLayout(false);
            this.grpDadosVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTituloPagDetalhes;
        private System.Windows.Forms.Label lblTituloDetalhes;
        private System.Windows.Forms.GroupBox grpDadosVenda;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.Label lblTotalVenda;
        private System.Windows.Forms.TextBox txtDataVenda;
        private System.Windows.Forms.Label lblDataVenda;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.DataGridView dgvDadosVenda;
    }
}