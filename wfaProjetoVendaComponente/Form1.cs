using System.Windows.Forms;
using System.Data;
using System;
using Npgsql;
using System.Xml.Linq;

namespace wfaProjetoVendaComponente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // INICIALIZA A DATAGRIDVIEW NA CLASSE CLIENTE -----------------------------------
        private void dGvClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbNomeCl.Text = Convert.ToString(dGvClientes.Rows[e.RowIndex].Cells[0].Value);
            tbIDCl.Text = Convert.ToString(dGvClientes.Rows[e.RowIndex].Cells[1].Value);
            tbCPF.Text = Convert.ToString(dGvClientes.Rows[e.RowIndex].Cells[2].Value);
            tbDataCadastro.Text = Convert.ToString(dGvClientes.Rows[e.RowIndex].Cells[3].Value);
        }

        // CRIA O MÉTODO LIMPAR TEXT BOX -------------------------------------------
        public void limparTextBox()
        {
            tbNomeCl.Text = String.Empty;
            tbIDCl.Text = String.Empty;
            tbCPF.Text = String.Empty;
            tbDataCadastro.Text = String.Empty;
        }

        // FUNÇÃO PARA BOTÃO PRÓXIMO ------------------------------------------------
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (tC1.SelectedIndex < tC1.TabCount - 1)
            {
                tC1.SelectedIndex++;
            }
            else
            {
                MessageBox.Show("Você já está na última aba.");
            }
        }

        // FUNÇÃO PARA BOTÃO PRÓXIMO CASO JA ESTEJA NA ULTIMA ABA ----------------------
        private void btnNext1_Click(object sender, EventArgs e)
        {
            if (tC1.SelectedIndex < tC1.TabCount - 1)
            {
                tC1.SelectedIndex++;
            }
            else
            {
                MessageBox.Show("Você já está na última aba.");
            }
        }

        // FUNÇÃO BOTÃO SAIR DO PROGRAMA ----------------------------------------------
        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // FUNÇÃO BOTÃO VOLTAR E SE JA ESTA NA ULTIMA ABA ----------------------------
        private void button6_Click_1(object sender, EventArgs e)
        {
            if (tC1.SelectedIndex > 0)
            {
                // Volta para a aba anterior
                tC1.SelectedIndex--;
            }
            else
            {
                MessageBox.Show("Você já está na primeira aba.");
            }
        }

        // FUNÇÃO BOTÃO ADICIONAR "CLIENTE" -------------------------------------------
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Clientes objCliente = new Clientes(tbNomeCl.Text, tbIDCl.Text, tbCPF.Text, tbDataCadastro.Text);

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = String.Format("INSERT INTO Clientes(nome_cliente, id_cliente, cpf_cliente, data_cadastro) " +
                "values ('{0}', '{1}', '{2}', '{3}')", objCliente.Nome_cliente, objCliente.Id_cliente, objCliente.Cpf_cliente, objCliente.Data_cadastro);

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Cadastro Inserido com Sucesso! ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparTextBox();
        }

        // BOTÃO ATUALIZAR "CLIENTE" --------------------------------------------------
        private void btAtualizarCl_Click(object sender, EventArgs e)
        {
            int id_cliente;
            if (!int.TryParse(tbIDCl.Text, out id_cliente))
            {
                MessageBox.Show("O ID do cliente deve ser um número inteiro.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cria um objeto Clientes com os dados dos TextBoxes
            Clientes objCliente = new Clientes(tbNomeCl.Text, tbIDCl.Text, tbCPF.Text, tbDataCadastro.Text);

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();

            using (NpgsqlConnection con = new NpgsqlConnection(conexao))
            {
                con.Open();

                // Comando SQL para atualizar os dados do cliente
                string commandText = "UPDATE clientes SET nome_cliente = @nome_cliente, cpf_cliente = @cpf_cliente, data_cadastro = @data_cadastro WHERE id_cliente = @id_cliente"; // Verifique se o nome está correto

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {
                    // Adiciona os parâmetros ao comando
                    pgsqlcommand.Parameters.AddWithValue("nome_cliente", objCliente.Nome_cliente);
                    pgsqlcommand.Parameters.AddWithValue("cpf_cliente", objCliente.Cpf_cliente);
                    pgsqlcommand.Parameters.AddWithValue("data_cadastro", objCliente.Data_cadastro);
                    pgsqlcommand.Parameters.AddWithValue("id_cliente", id_cliente); // Usando o nome correto

                    try
                    {
                        // Executa o comando
                        int rowsAffected = pgsqlcommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cadastro Atualizado com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma atualização foi realizada. Verifique se o ID do cliente está correto.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                con.Close();
            }

            // Limpa os campos após a atualização
            limparTextBox();
        }

        // BOTÃO EXCLUIR "CLIENTE" ----------------------------------------------------
        private void btDeletar_Click(object sender, EventArgs e)
        {
            string cpf = tbCPF.Text;

            Clientes objCliente = new Clientes(tbNomeCl.Text, tbIDCl.Text, tbCPF.Text, tbDataCadastro.Text);

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = String.Format("DELETE from clientes where cpf_cliente = '{0}'", cpf);

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("Cadastro Excluído com Sucesso! ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            limparTextBox();
        }

        // BOTÃO RELATÓRIO "CLIENTE" --------------------------------------------------
        private void btnRelatorioCliente_Click(object sender, EventArgs e)
        {
            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            DataTable dt = new DataTable();

            string commandText = "SELECT * FROM clientes ORDER BY id_cliente";

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con))
            {
                Adpt.Fill(dt);
            }

            dGvClientes.DataSource = dt;

            con.Close();
        }

        // INICIA DATAGRIDVIEW COMPONENTES --------------------------------------------
        private void dGVComp_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbNomeComp.Text = Convert.ToString(dGVComp.Rows[e.RowIndex].Cells[0].Value);
            tbIDComp.Text = Convert.ToString(dGVComp.Rows[e.RowIndex].Cells[1].Value);
            tbQuantidade.Text = Convert.ToString(dGVComp.Rows[e.RowIndex].Cells[2].Value);
            tbSetor.Text = Convert.ToString(dGVComp.Rows[e.RowIndex].Cells[3].Value);
        }

        // FUNÇÃO ADICIONA COMPONENTE ---------------------------------------------------
        private void btAdComp_Click(object sender, EventArgs e)
        {
            // Tente criar o objeto Componentes, assumindo que o construtor aceita strings
            string nomeComponente = tbNomeComp.Text;
            string idComponenteStr = tbIDComp.Text; // ID como string inicialmente
            string quantidadeStr = tbQuantidade.Text; // Quantidade como string inicialmente
            string setor = tbSetor.Text;

            // Validação e conversão dos tipos
            if (int.TryParse(idComponenteStr, out int idComponente) && int.TryParse(quantidadeStr, out int quantidade))
            {
                // Obtenha a string de conexão
                ConexaoString stringConexao = new ConexaoString();
                string conexao = stringConexao.ConnString();

                using (NpgsqlConnection con = new NpgsqlConnection(conexao))
                {
                    con.Open();

                    // Comando SQL com parametrização
                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand("INSERT INTO Componentes(componente, id_componente, quantidade, setor) " +
                        "VALUES (@componente, @id_componente, @quantidade, @setor)", con))
                    {
                        // Adicione os parâmetros corretamente
                        pgsqlcommand.Parameters.AddWithValue("@componente", nomeComponente); // Nome do componente
                        pgsqlcommand.Parameters.AddWithValue("@id_componente", idComponente); // ID do componente (inteiro)
                        pgsqlcommand.Parameters.AddWithValue("@quantidade", quantidade); // Quantidade (inteiro)
                        pgsqlcommand.Parameters.AddWithValue("@setor", setor); // Setor como string

                        // Execute o comando
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cadastro Inserido com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparTextBox();
            }
            else
            {
                MessageBox.Show("O ID do componente e a quantidade devem ser números inteiros.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // FUNÇÃO ATUALIZA COMPONENTE ---------------------------------------------------
        private void btAtComp_Click(object sender, EventArgs e)
        {
            // Validação e conversão do ID do componente
            int idComponente;
            if (!int.TryParse(tbIDComp.Text, out idComponente))
            {
                MessageBox.Show("O ID do componente deve ser um número inteiro.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se o nome do componente não é vazio
            string nomeComponente = tbNomeComp.Text.Trim();
            if (string.IsNullOrWhiteSpace(nomeComponente))
            {
                MessageBox.Show("O nome do componente não pode ser vazio.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cria um objeto Componentes com os dados dos TextBoxes
            Componentes objComp = new Componentes(nomeComponente, idComponente.ToString(), tbQuantidade.Text, tbSetor.Text);

            // Cria uma nova conexão
            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();

            using (NpgsqlConnection con = new NpgsqlConnection(conexao))
            {
                con.Open();

                // Comando SQL para atualizar os dados na tabela componentes
                string commandText = "UPDATE componentes SET componente = @componente, quantidade = @quantidade, setor = @setor WHERE id_componente = @id_componente";

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {
                    // Adiciona os parâmetros ao comando
                    pgsqlcommand.Parameters.AddWithValue("id_componente", idComponente); // Passando como int
                    pgsqlcommand.Parameters.AddWithValue("componente", nomeComponente); // Passando o nome do componente como string
                    pgsqlcommand.Parameters.AddWithValue("quantidade", tbQuantidade.Text); // Certifique-se que o tipo de quantidade é correto
                    pgsqlcommand.Parameters.AddWithValue("setor", tbSetor.Text); // Setor como string

                    try
                    {
                        // Executa o comando
                        int rowsAffected = pgsqlcommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Componente atualizado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma atualização foi realizada. Verifique se o ID do componente está correto.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            limparTextBox();
        }

        // FUNÇÃO EXCLUIR COMPONENTE -----------------------------------------------------
        private void brDelComp_Click(object sender, EventArgs e)
        {
            string componente = tbNomeComp.Text;

            Componentes objComponente = new Componentes(tbNomeComp.Text, tbIDComp.Text, tbQuantidade.Text, tbSetor.Text);

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = String.Format("DELETE from componentes where componente = '{0}'", componente);

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("Cadastro Excluído com Sucesso! ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            limparTextBox();
        }

        // FUNÇÃO RELATÓRIO COMPONENTE ---------------------------------------------------
        private void btnRelatorioComponentes_Click(object sender, EventArgs e)
        {
            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            DataTable dt = new DataTable();

            string commandText = "SELECT * FROM componentes ORDER BY id_componente";

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con))
            {
                Adpt.Fill(dt);
            }

            dGVComp.DataSource = dt;

            con.Close();
        }

        // INICIA O DATAGRIDVIEW DE VENDAS -------------------------------------------
        private void dGVendas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbIDVendas.Text = Convert.ToString(dGVendas.Rows[e.RowIndex].Cells[0].Value);
            tbDataVenda.Text = Convert.ToString(dGVendas.Rows[e.RowIndex].Cells[1].Value);
            tbValorTotal.Text = Convert.ToString(dGVendas.Rows[e.RowIndex].Cells[2].Value);
            tbNomeVendedor.Text = Convert.ToString(dGVendas.Rows[e.RowIndex].Cells[3].Value);
        }

        // FUNÇÃO ADICIONA VENDA -----------------------------------------------------
        private void btAdVenda_Click(object sender, EventArgs e)
        {
            Vendas objVenda = new Vendas(tbIDVendas.Text, tbDataVenda.Text, tbValorTotal.Text, tbNomeVendedor.Text);

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();

            using (NpgsqlConnection con = new NpgsqlConnection(conexao))
            {
                con.Open();

                string commandText = "INSERT INTO Vendas(id_venda, dia_venda, valor_total, nome_vendedor) " +
                                     "VALUES (@id_venda, @dia_venda, @valor_total, @nome_vendedor)";

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {
          
                    pgsqlcommand.Parameters.AddWithValue("id_venda", objVenda.Id_venda);
                    pgsqlcommand.Parameters.AddWithValue("dia_venda", objVenda.Dia_venda);
                    pgsqlcommand.Parameters.AddWithValue("valor_total", objVenda.Valor_total);
                    pgsqlcommand.Parameters.AddWithValue("nome_vendedor", objVenda.Nome_vendedor);

                    pgsqlcommand.ExecuteNonQuery();
                }
            }

  
            MessageBox.Show("Cadastro Inserido com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparTextBox();
        }

        // FUNÇÃO ATUALIZA VENDA -----------------------------------------------------
        private void btAtVendas_Click(object sender, EventArgs e)
        {
            string id_venda = tbIDVendas.Text;

            Vendas objVenda = new Vendas(tbIDVendas.Text, tbDataVenda.Text, tbValorTotal.Text, tbNomeVendedor.Text);

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();

            using (NpgsqlConnection con = new NpgsqlConnection(conexao))
            {
                con.Open();

                string commandText = "UPDATE vendas SET id_venda = @id_venda, dia_venda = @dia_venda, valor_total = @valor_total, nome_vendedor = @nome_vendedor WHERE id_venda = @id_venda";

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {
                    pgsqlcommand.Parameters.AddWithValue("id_venda", objVenda.Id_venda);
                    pgsqlcommand.Parameters.AddWithValue("dia_venda",objVenda.Dia_venda);
                    pgsqlcommand.Parameters.AddWithValue("valor_total", objVenda.Valor_total);
                    pgsqlcommand.Parameters.AddWithValue("nome_vendedor", objVenda.Nome_vendedor);
                    pgsqlcommand.Parameters.AddWithValue("id_venda", id_venda);

                    pgsqlcommand.ExecuteNonQuery();
                }
                con.Close();
            }

            MessageBox.Show("Cadastro Atualizado com Sucesso! ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            limparTextBox();
        }

        // FUNÇÃO DELETAR VENDA -------------------------------------------------------

        private void btDeleteVendas_Click(object sender, EventArgs e)
        {
            string id_venda = tbIDVendas.Text;

            Componentes objComponente = new Componentes(tbNomeComp.Text, tbIDComp.Text, tbQuantidade.Text, tbSetor.Text);

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = String.Format("DELETE from vendas where id_venda = '{0}'", id_venda);

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("Cadastro Excluído com Sucesso! ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            limparTextBox();
        }

        // FUNÇÃO RELATÓRIO DE VENDA --------------------------------------------------
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            DataTable dt = new DataTable();

            string commandText = "SELECT * FROM vendas ORDER BY id_venda";

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con))
            {
                Adpt.Fill(dt);
            }

            dGVendas.DataSource = dt;

            con.Close();
        }
    }
}