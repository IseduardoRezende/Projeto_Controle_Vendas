namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    partial class Frmpagamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmpagamentos));
            this.pnlTituloPagProd = new System.Windows.Forms.Panel();
            this.lblTituloCadFunc = new System.Windows.Forms.Label();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.txtCartao = new System.Windows.Forms.TextBox();
            this.lblCartao = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.pnlTituloPagProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTituloPagProd
            // 
            this.pnlTituloPagProd.BackColor = System.Drawing.Color.Purple;
            this.pnlTituloPagProd.Controls.Add(this.lblTituloCadFunc);
            this.pnlTituloPagProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloPagProd.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloPagProd.Margin = new System.Windows.Forms.Padding(6);
            this.pnlTituloPagProd.Name = "pnlTituloPagProd";
            this.pnlTituloPagProd.Size = new System.Drawing.Size(1050, 100);
            this.pnlTituloPagProd.TabIndex = 3;
            // 
            // lblTituloCadFunc
            // 
            this.lblTituloCadFunc.AutoSize = true;
            this.lblTituloCadFunc.Font = new System.Drawing.Font("Cascadia Code", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadFunc.Location = new System.Drawing.Point(460, 33);
            this.lblTituloCadFunc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTituloCadFunc.Name = "lblTituloCadFunc";
            this.lblTituloCadFunc.Size = new System.Drawing.Size(220, 49);
            this.lblTituloCadFunc.TabIndex = 1;
            this.lblTituloCadFunc.Text = "Pagamento";
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinheiro.ForeColor = System.Drawing.Color.Black;
            this.txtDinheiro.Location = new System.Drawing.Point(331, 159);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(239, 32);
            this.txtDinheiro.TabIndex = 17;
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinheiro.ForeColor = System.Drawing.Color.White;
            this.lblDinheiro.Location = new System.Drawing.Point(28, 148);
            this.lblDinheiro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(285, 43);
            this.lblDinheiro.TabIndex = 16;
            this.lblDinheiro.Text = "Dinheiro (R$):";
            // 
            // txtCartao
            // 
            this.txtCartao.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartao.ForeColor = System.Drawing.Color.Black;
            this.txtCartao.Location = new System.Drawing.Point(739, 109);
            this.txtCartao.Name = "txtCartao";
            this.txtCartao.Size = new System.Drawing.Size(239, 32);
            this.txtCartao.TabIndex = 19;
            this.txtCartao.Visible = false;
            // 
            // lblCartao
            // 
            this.lblCartao.AutoSize = true;
            this.lblCartao.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartao.ForeColor = System.Drawing.Color.White;
            this.lblCartao.Location = new System.Drawing.Point(557, 100);
            this.lblCartao.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCartao.Name = "lblCartao";
            this.lblCartao.Size = new System.Drawing.Size(152, 43);
            this.lblCartao.TabIndex = 18;
            this.lblCartao.Text = "Cartão:";
            this.lblCartao.Visible = false;
            // 
            // txtTroco
            // 
            this.txtTroco.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.ForeColor = System.Drawing.Color.Black;
            this.txtTroco.Location = new System.Drawing.Point(331, 230);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(239, 32);
            this.txtTroco.TabIndex = 21;
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.ForeColor = System.Drawing.Color.White;
            this.lblTroco.Location = new System.Drawing.Point(85, 219);
            this.lblTroco.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(228, 43);
            this.lblTroco.TabIndex = 20;
            this.lblTroco.Text = "Troco (R$):";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Location = new System.Drawing.Point(331, 298);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(239, 32);
            this.txtTotal.TabIndex = 23;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(180, 287);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(133, 43);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Total:";
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(148, 370);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(359, 67);
            this.btnPagar.TabIndex = 24;
            this.btnPagar.Text = "Finalizar Venda";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.ForeColor = System.Drawing.Color.Black;
            this.txtObservacoes.Location = new System.Drawing.Point(617, 201);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(407, 236);
            this.txtObservacoes.TabIndex = 26;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacoes.ForeColor = System.Drawing.Color.White;
            this.lblObservacoes.Location = new System.Drawing.Point(702, 146);
            this.lblObservacoes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(247, 43);
            this.lblObservacoes.TabIndex = 25;
            this.lblObservacoes.Text = "Observações:";
            // 
            // Frmpagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1050, 471);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.lblObservacoes);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.txtCartao);
            this.Controls.Add(this.lblCartao);
            this.Controls.Add(this.txtDinheiro);
            this.Controls.Add(this.lblDinheiro);
            this.Controls.Add(this.pnlTituloPagProd);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frmpagamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.Frmpagamentos_Load);
            this.pnlTituloPagProd.ResumeLayout(false);
            this.pnlTituloPagProd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTituloPagProd;
        private System.Windows.Forms.Label lblTituloCadFunc;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.TextBox txtCartao;
        private System.Windows.Forms.Label lblCartao;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label lblObservacoes;
    }
}