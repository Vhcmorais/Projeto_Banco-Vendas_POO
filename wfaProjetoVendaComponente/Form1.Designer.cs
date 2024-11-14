namespace wfaProjetoVendaComponente
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tC1 = new TabControl();
            tbP1 = new TabPage();
            btnRelatorioCliente = new Button();
            dGvClientes = new DataGridView();
            btnNext = new Button();
            btSair = new Button();
            btDeletar = new Button();
            btAtualizarCl = new Button();
            btAdicionar = new Button();
            pictureBox2 = new PictureBox();
            tbDataCadastro = new TextBox();
            tbCPF = new TextBox();
            tbIDCl = new TextBox();
            label3 = new Label();
            lbl3 = new Label();
            lbl2 = new Label();
            tbNomeCl = new TextBox();
            lbl1 = new Label();
            tbP2 = new TabPage();
            btnRelatorioComponentes = new Button();
            dGVComp = new DataGridView();
            btnVoltar = new Button();
            btnNext1 = new Button();
            button4 = new Button();
            brDelComp = new Button();
            btAtComp = new Button();
            btAdComp = new Button();
            pictureBox1 = new PictureBox();
            tbSetor = new TextBox();
            label2 = new Label();
            tbQuantidade = new TextBox();
            label1 = new Label();
            tbIDComp = new TextBox();
            lblIDComp = new Label();
            tbNomeComp = new TextBox();
            lblNomeComp = new Label();
            tbP3 = new TabPage();
            tbNomeVendedor = new TextBox();
            lblNomeVendedor = new Label();
            button9 = new Button();
            button8 = new Button();
            dGVendas = new DataGridView();
            btnRelatorio = new Button();
            btDeleteVendas = new Button();
            btAtVendas = new Button();
            btAdVenda = new Button();
            tbValorTotal = new TextBox();
            tbIDVendas = new TextBox();
            tbDataVenda = new TextBox();
            lblValor = new Label();
            lblDataVenda = new Label();
            lblIDVenda = new Label();
            tC1.SuspendLayout();
            tbP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tbP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVComp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tbP3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVendas).BeginInit();
            SuspendLayout();
            // 
            // tC1
            // 
            tC1.Controls.Add(tbP1);
            tC1.Controls.Add(tbP2);
            tC1.Controls.Add(tbP3);
            tC1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tC1.Location = new Point(1, 0);
            tC1.Name = "tC1";
            tC1.SelectedIndex = 0;
            tC1.Size = new Size(957, 417);
            tC1.TabIndex = 0;
            tC1.Tag = "";
            // 
            // tbP1
            // 
            tbP1.Controls.Add(btnRelatorioCliente);
            tbP1.Controls.Add(dGvClientes);
            tbP1.Controls.Add(btnNext);
            tbP1.Controls.Add(btSair);
            tbP1.Controls.Add(btDeletar);
            tbP1.Controls.Add(btAtualizarCl);
            tbP1.Controls.Add(btAdicionar);
            tbP1.Controls.Add(pictureBox2);
            tbP1.Controls.Add(tbDataCadastro);
            tbP1.Controls.Add(tbCPF);
            tbP1.Controls.Add(tbIDCl);
            tbP1.Controls.Add(label3);
            tbP1.Controls.Add(lbl3);
            tbP1.Controls.Add(lbl2);
            tbP1.Controls.Add(tbNomeCl);
            tbP1.Controls.Add(lbl1);
            tbP1.Location = new Point(4, 29);
            tbP1.Name = "tbP1";
            tbP1.Padding = new Padding(3);
            tbP1.Size = new Size(949, 384);
            tbP1.TabIndex = 0;
            tbP1.Text = "Clientes";
            tbP1.UseVisualStyleBackColor = true;
            // 
            // btnRelatorioCliente
            // 
            btnRelatorioCliente.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRelatorioCliente.Location = new Point(634, 6);
            btnRelatorioCliente.Name = "btnRelatorioCliente";
            btnRelatorioCliente.Size = new Size(309, 32);
            btnRelatorioCliente.TabIndex = 16;
            btnRelatorioCliente.Text = "RELATÓRIO";
            btnRelatorioCliente.UseVisualStyleBackColor = true;
            btnRelatorioCliente.Click += btnRelatorioCliente_Click;
            // 
            // dGvClientes
            // 
            dGvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGvClientes.Location = new Point(634, 44);
            dGvClientes.Name = "dGvClientes";
            dGvClientes.RowHeadersWidth = 62;
            dGvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGvClientes.Size = new Size(309, 329);
            dGvClientes.TabIndex = 15;
            dGvClientes.CellMouseDoubleClick += dGvClientes_CellMouseDoubleClick;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(426, 302);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(122, 35);
            btnNext.TabIndex = 14;
            btnNext.Text = "Próximo";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btSair
            // 
            btSair.Location = new Point(426, 343);
            btSair.Name = "btSair";
            btSair.Size = new Size(122, 35);
            btSair.TabIndex = 13;
            btSair.Text = "Sair";
            btSair.UseVisualStyleBackColor = true;
            btSair.Click += btSair_Click;
            // 
            // btDeletar
            // 
            btDeletar.Location = new Point(264, 324);
            btDeletar.Name = "btDeletar";
            btDeletar.Size = new Size(132, 49);
            btDeletar.TabIndex = 12;
            btDeletar.Text = "Deletar";
            btDeletar.UseVisualStyleBackColor = true;
            btDeletar.Click += btDeletar_Click;
            // 
            // btAtualizarCl
            // 
            btAtualizarCl.Location = new Point(129, 324);
            btAtualizarCl.Name = "btAtualizarCl";
            btAtualizarCl.Size = new Size(129, 49);
            btAtualizarCl.TabIndex = 11;
            btAtualizarCl.Text = "Atualizar";
            btAtualizarCl.UseVisualStyleBackColor = true;
            btAtualizarCl.Click += btAtualizarCl_Click;
            // 
            // btAdicionar
            // 
            btAdicionar.Location = new Point(11, 324);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(112, 49);
            btAdicionar.TabIndex = 10;
            btAdicionar.Text = "Adicionar";
            btAdicionar.UseVisualStyleBackColor = true;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(554, 302);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // tbDataCadastro
            // 
            tbDataCadastro.Location = new Point(196, 151);
            tbDataCadastro.Name = "tbDataCadastro";
            tbDataCadastro.Size = new Size(178, 28);
            tbDataCadastro.TabIndex = 7;
            // 
            // tbCPF
            // 
            tbCPF.Location = new Point(196, 110);
            tbCPF.Name = "tbCPF";
            tbCPF.Size = new Size(241, 28);
            tbCPF.TabIndex = 6;
            // 
            // tbIDCl
            // 
            tbIDCl.Location = new Point(196, 76);
            tbIDCl.Name = "tbIDCl";
            tbIDCl.Size = new Size(103, 28);
            tbIDCl.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 154);
            label3.Name = "label3";
            label3.Size = new Size(188, 20);
            label3.TabIndex = 4;
            label3.Text = "DATA DE CADASTRO:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(144, 113);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(46, 20);
            lbl3.TabIndex = 3;
            lbl3.Text = "CPF:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(80, 79);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(113, 20);
            lbl2.TabIndex = 2;
            lbl2.Text = "ID CLIENTE:";
            // 
            // tbNomeCl
            // 
            tbNomeCl.Location = new Point(196, 42);
            tbNomeCl.Name = "tbNomeCl";
            tbNomeCl.Size = new Size(300, 28);
            tbNomeCl.TabIndex = 1;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(11, 44);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(182, 22);
            lbl1.TabIndex = 0;
            lbl1.Text = "NOME COMPLETO:";
            // 
            // tbP2
            // 
            tbP2.Controls.Add(btnRelatorioComponentes);
            tbP2.Controls.Add(dGVComp);
            tbP2.Controls.Add(btnVoltar);
            tbP2.Controls.Add(btnNext1);
            tbP2.Controls.Add(button4);
            tbP2.Controls.Add(brDelComp);
            tbP2.Controls.Add(btAtComp);
            tbP2.Controls.Add(btAdComp);
            tbP2.Controls.Add(pictureBox1);
            tbP2.Controls.Add(tbSetor);
            tbP2.Controls.Add(label2);
            tbP2.Controls.Add(tbQuantidade);
            tbP2.Controls.Add(label1);
            tbP2.Controls.Add(tbIDComp);
            tbP2.Controls.Add(lblIDComp);
            tbP2.Controls.Add(tbNomeComp);
            tbP2.Controls.Add(lblNomeComp);
            tbP2.Location = new Point(4, 29);
            tbP2.Name = "tbP2";
            tbP2.Padding = new Padding(3);
            tbP2.Size = new Size(949, 384);
            tbP2.TabIndex = 1;
            tbP2.Text = "Componentes";
            tbP2.UseVisualStyleBackColor = true;
            // 
            // btnRelatorioComponentes
            // 
            btnRelatorioComponentes.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRelatorioComponentes.Location = new Point(619, 6);
            btnRelatorioComponentes.Name = "btnRelatorioComponentes";
            btnRelatorioComponentes.Size = new Size(313, 34);
            btnRelatorioComponentes.TabIndex = 19;
            btnRelatorioComponentes.Text = "RELATÓRIO";
            btnRelatorioComponentes.UseVisualStyleBackColor = true;
            btnRelatorioComponentes.Click += btnRelatorioComponentes_Click;
            // 
            // dGVComp
            // 
            dGVComp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVComp.Location = new Point(619, 46);
            dGVComp.Name = "dGVComp";
            dGVComp.RowHeadersWidth = 62;
            dGVComp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVComp.Size = new Size(313, 327);
            dGVComp.TabIndex = 18;
            dGVComp.CellMouseDoubleClick += dGVComp_CellMouseDoubleClick;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(186, 355);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(101, 28);
            btnVoltar.TabIndex = 17;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += button6_Click_1;
            // 
            // btnNext1
            // 
            btnNext1.Location = new Point(79, 355);
            btnNext1.Name = "btnNext1";
            btnNext1.Size = new Size(101, 26);
            btnNext1.TabIndex = 16;
            btnNext1.Text = "Próximo";
            btnNext1.UseVisualStyleBackColor = true;
            btnNext1.Click += btnNext1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(299, 354);
            button4.Name = "button4";
            button4.Size = new Size(101, 28);
            button4.TabIndex = 15;
            button4.Text = "Sair";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btSair_Click;
            // 
            // brDelComp
            // 
            brDelComp.Location = new Point(372, 284);
            brDelComp.Name = "brDelComp";
            brDelComp.Size = new Size(138, 49);
            brDelComp.TabIndex = 14;
            brDelComp.Text = "Deletar";
            brDelComp.UseVisualStyleBackColor = true;
            brDelComp.Click += brDelComp_Click;
            // 
            // btAtComp
            // 
            btAtComp.Location = new Point(228, 284);
            btAtComp.Name = "btAtComp";
            btAtComp.Size = new Size(138, 49);
            btAtComp.TabIndex = 13;
            btAtComp.Text = "Atualizar";
            btAtComp.UseVisualStyleBackColor = true;
            btAtComp.Click += btAtComp_Click;
            // 
            // btAdComp
            // 
            btAdComp.Location = new Point(84, 284);
            btAdComp.Name = "btAdComp";
            btAdComp.Size = new Size(138, 49);
            btAdComp.TabIndex = 12;
            btAdComp.Text = "Adicionar";
            btAdComp.UseVisualStyleBackColor = true;
            btAdComp.Click += btAdComp_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 309);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // tbSetor
            // 
            tbSetor.Location = new Point(228, 173);
            tbSetor.Name = "tbSetor";
            tbSetor.Size = new Size(104, 28);
            tbSetor.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(144, 179);
            label2.Name = "label2";
            label2.Size = new Size(78, 22);
            label2.TabIndex = 9;
            label2.Text = "SETOR:";
            // 
            // tbQuantidade
            // 
            tbQuantidade.Location = new Point(228, 139);
            tbQuantidade.Name = "tbQuantidade";
            tbQuantidade.Size = new Size(104, 28);
            tbQuantidade.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 141);
            label1.Name = "label1";
            label1.Size = new Size(143, 22);
            label1.TabIndex = 7;
            label1.Text = "QUANTIDADE:";
            // 
            // tbIDComp
            // 
            tbIDComp.Location = new Point(228, 105);
            tbIDComp.Name = "tbIDComp";
            tbIDComp.Size = new Size(103, 28);
            tbIDComp.TabIndex = 6;
            // 
            // lblIDComp
            // 
            lblIDComp.AutoSize = true;
            lblIDComp.Location = new Point(60, 108);
            lblIDComp.Name = "lblIDComp";
            lblIDComp.Size = new Size(162, 20);
            lblIDComp.TabIndex = 3;
            lblIDComp.Text = "ID COMPONENTE:";
            // 
            // tbNomeComp
            // 
            tbNomeComp.Location = new Point(228, 71);
            tbNomeComp.Name = "tbNomeComp";
            tbNomeComp.Size = new Size(227, 28);
            tbNomeComp.TabIndex = 2;
            // 
            // lblNomeComp
            // 
            lblNomeComp.AutoSize = true;
            lblNomeComp.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeComp.Location = new Point(11, 71);
            lblNomeComp.Name = "lblNomeComp";
            lblNomeComp.Size = new Size(211, 22);
            lblNomeComp.TabIndex = 1;
            lblNomeComp.Text = "NOME COMPONENTE:";
            // 
            // tbP3
            // 
            tbP3.Controls.Add(tbNomeVendedor);
            tbP3.Controls.Add(lblNomeVendedor);
            tbP3.Controls.Add(button9);
            tbP3.Controls.Add(button8);
            tbP3.Controls.Add(dGVendas);
            tbP3.Controls.Add(btnRelatorio);
            tbP3.Controls.Add(btDeleteVendas);
            tbP3.Controls.Add(btAtVendas);
            tbP3.Controls.Add(btAdVenda);
            tbP3.Controls.Add(tbValorTotal);
            tbP3.Controls.Add(tbIDVendas);
            tbP3.Controls.Add(tbDataVenda);
            tbP3.Controls.Add(lblValor);
            tbP3.Controls.Add(lblDataVenda);
            tbP3.Controls.Add(lblIDVenda);
            tbP3.Location = new Point(4, 29);
            tbP3.Name = "tbP3";
            tbP3.Padding = new Padding(3);
            tbP3.Size = new Size(949, 384);
            tbP3.TabIndex = 2;
            tbP3.Text = "Vendas Realizadas";
            tbP3.UseVisualStyleBackColor = true;
            // 
            // tbNomeVendedor
            // 
            tbNomeVendedor.Location = new Point(233, 155);
            tbNomeVendedor.Name = "tbNomeVendedor";
            tbNomeVendedor.Size = new Size(207, 28);
            tbNomeVendedor.TabIndex = 21;
            // 
            // lblNomeVendedor
            // 
            lblNomeVendedor.AutoSize = true;
            lblNomeVendedor.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeVendedor.Location = new Point(10, 152);
            lblNomeVendedor.Name = "lblNomeVendedor";
            lblNomeVendedor.Size = new Size(217, 22);
            lblNomeVendedor.TabIndex = 20;
            lblNomeVendedor.Text = "NOME DO VENDEDOR:";
            // 
            // button9
            // 
            button9.Location = new Point(131, 343);
            button9.Name = "button9";
            button9.Size = new Size(122, 35);
            button9.TabIndex = 19;
            button9.Text = "Sair";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btSair_Click;
            // 
            // button8
            // 
            button8.Location = new Point(3, 343);
            button8.Name = "button8";
            button8.Size = new Size(122, 35);
            button8.TabIndex = 18;
            button8.Text = "Voltar";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button6_Click_1;
            // 
            // dGVendas
            // 
            dGVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVendas.Location = new Point(549, 42);
            dGVendas.Name = "dGVendas";
            dGVendas.RowHeadersWidth = 62;
            dGVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVendas.Size = new Size(394, 331);
            dGVendas.TabIndex = 17;
            dGVendas.CellMouseDoubleClick += dGVendas_CellMouseDoubleClick;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Location = new Point(549, 6);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(394, 30);
            btnRelatorio.TabIndex = 16;
            btnRelatorio.Text = "Relatório";
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btDeleteVendas
            // 
            btDeleteVendas.Location = new Point(334, 253);
            btDeleteVendas.Name = "btDeleteVendas";
            btDeleteVendas.Size = new Size(138, 49);
            btDeleteVendas.TabIndex = 15;
            btDeleteVendas.Text = "Deletar";
            btDeleteVendas.UseVisualStyleBackColor = true;
            btDeleteVendas.Click += btDeleteVendas_Click;
            // 
            // btAtVendas
            // 
            btAtVendas.Location = new Point(167, 253);
            btAtVendas.Name = "btAtVendas";
            btAtVendas.Size = new Size(138, 49);
            btAtVendas.TabIndex = 14;
            btAtVendas.Text = "Atualizar";
            btAtVendas.UseVisualStyleBackColor = true;
            btAtVendas.Click += btAtVendas_Click;
            // 
            // btAdVenda
            // 
            btAdVenda.Location = new Point(7, 253);
            btAdVenda.Name = "btAdVenda";
            btAdVenda.Size = new Size(138, 49);
            btAdVenda.TabIndex = 13;
            btAdVenda.Text = "Adicionar";
            btAdVenda.UseVisualStyleBackColor = true;
            btAdVenda.Click += btAdVenda_Click;
            // 
            // tbValorTotal
            // 
            tbValorTotal.Location = new Point(233, 121);
            tbValorTotal.Name = "tbValorTotal";
            tbValorTotal.Size = new Size(207, 28);
            tbValorTotal.TabIndex = 7;
            // 
            // tbIDVendas
            // 
            tbIDVendas.Location = new Point(233, 51);
            tbIDVendas.Name = "tbIDVendas";
            tbIDVendas.Size = new Size(102, 28);
            tbIDVendas.TabIndex = 6;
            // 
            // tbDataVenda
            // 
            tbDataVenda.Location = new Point(233, 85);
            tbDataVenda.Name = "tbDataVenda";
            tbDataVenda.Size = new Size(207, 28);
            tbDataVenda.TabIndex = 5;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(42, 121);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(185, 22);
            lblValor.TabIndex = 3;
            lblValor.Text = "VALOR TOTAL (R$):";
            // 
            // lblDataVenda
            // 
            lblDataVenda.AutoSize = true;
            lblDataVenda.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataVenda.Location = new Point(58, 87);
            lblDataVenda.Name = "lblDataVenda";
            lblDataVenda.Size = new Size(169, 22);
            lblDataVenda.TabIndex = 1;
            lblDataVenda.Text = "DATA DA VENDA:";
            // 
            // lblIDVenda
            // 
            lblIDVenda.AutoSize = true;
            lblIDVenda.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIDVenda.Location = new Point(119, 53);
            lblIDVenda.Name = "lblIDVenda";
            lblIDVenda.Size = new Size(108, 22);
            lblIDVenda.TabIndex = 0;
            lblIDVenda.Text = "ID VENDA:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 414);
            Controls.Add(tC1);
            Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Controle de Vendas - Vitebas Eletrônicos";
            tC1.ResumeLayout(false);
            tbP1.ResumeLayout(false);
            tbP1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tbP2.ResumeLayout(false);
            tbP2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGVComp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tbP3.ResumeLayout(false);
            tbP3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGVendas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tC1;
        private TabPage tbP1;
        private TabPage tbP2;
        private TabPage tbP3;
        private Label lbl1;
        private TextBox tbNomeCl;
        private Label label3;
        private Label lbl3;
        private Label lbl2;
        private TextBox tbDataCadastro;
        private TextBox tbCPF;
        private TextBox tbIDCl;
        private PictureBox pictureBox2;
        private Button btSair;
        private Button btDeletar;
        private Button btAtualizarCl;
        private Button btAdicionar;
        private Label lblNomeComp;
        private TextBox tbNomeComp;
        private Label lblIDComp;
        private TextBox tbIDComp;
        private TextBox tbQuantidade;
        private Label label1;
        private TextBox tbSetor;
        private Label label2;
        private Button button4;
        private Button brDelComp;
        private Button btAtComp;
        private Button btAdComp;
        private PictureBox pictureBox1;
        private Button btnNext;
        private Button btnNext1;
        private Label lblDataVenda;
        private Label lblIDVenda;
        private Label lblValor;
        private TextBox tbValorTotal;
        private TextBox tbIDVendas;
        private TextBox tbDataVenda;
        private Button btDeleteVendas;
        private Button btAtVendas;
        private Button btAdVenda;
        private Button btnRelatorio;
        private DataGridView dGVendas;
        private Button btnVoltar;
        private Button button9;
        private Button button8;
        private DataGridView dGvClientes;
        private TextBox tbNomeVendedor;
        private Label lblNomeVendedor;
        private Button btnRelatorioCliente;
        private Button btnRelatorioComponentes;
        private DataGridView dGVComp;
    }
}
