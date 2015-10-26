using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistBancario
{
    public partial class cliente : Form
    {
        public cliente()
        {
            InitializeComponent();
        }

        private void cliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zCliente.clientesviewidentificacao' table. You can move, or remove it, as needed.
            this.clientesviewidentificacaoTableAdapter.Fill(this.zCliente.clientesviewidentificacao);
            int boundWidth = Screen.PrimaryScreen.Bounds.Width;
            int boundHeight = Screen.PrimaryScreen.Bounds.Height;
            int x = boundWidth - this.Width;
            int y = boundHeight - this.Height;
            this.Location = new Point(x / 2, y / 2);

            // TODO: This line of code loads data into the 'zBalcao.balcaoview' table. You can move, or remove it, as needed.
            this.balcaoviewTableAdapter.Fill(this.zBalcao.balcaoview);

        }



        private void butMenuInicial_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuInicial inicial = new menuInicial();
            inicial.Show();

        }

        private void Inserir_Click(object sender, EventArgs e)
        {
            if (panelCaixasTexto.Enabled)
            {
                if (verificaCaixasTexto(sender, e) == false)
                {
                    MessageBox.Show("Todos os campos devem estar preenchidos!", "Verificação");
                    return;
                }
                
                if (Global.exists(sender, e, "identificacao", "NIF", nIFTextBox.Text))
                {
                    MessageBox.Show("O campo NIF deve ser único!", "Verificação");
                    return;
                }

                int newIDCliente = Global.getLastID(sender, e, "cliente", "idCliente");

                SqlConnection conn = Global.Conn;
                SqlCommand cmd = new SqlCommand("Spinsertidentificacao", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NIF", int.Parse(nIFTextBox.Text));
                cmd.Parameters.AddWithValue("nTelefone", int.Parse(nTelefoneTextBox.Text));
                cmd.Parameters.AddWithValue("nome", nomeTextBox.Text);
                cmd.Parameters.AddWithValue("dataNascimento", DateTime.Parse(dataNascimentoDateTimePicker.Text));
                cmd.Parameters.AddWithValue("país", paísTextBox.Text);
                cmd.Parameters.AddWithValue("localidade", localidadeTextBox.Text);
                cmd.Parameters.AddWithValue("endereco", enderecoTextBox.Text);
                cmd.Parameters.AddWithValue("codPostal", codPostalTextBox.Text);
                cmd.Parameters.AddWithValue("gênero", gêneroTextBox.Text);
                cmd.Parameters.AddWithValue("idade", int.Parse(idadeTextBox.Text));

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir identificação!\n " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }

                conn = Global.Conn;
                cmd = new SqlCommand("Spinsertcliente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NIF", int.Parse(nIFTextBox.Text));
                cmd.Parameters.AddWithValue("idCliente", newIDCliente);
                cmd.Parameters.AddWithValue("nBalcao", int.Parse(nBalcaoTextBox.Text));
                cmd.Parameters.AddWithValue("nConta", int.Parse(nContaTextBox.Text));
                cmd.Parameters.AddWithValue("paísResidenciaFiscal", paísResidenciaFiscalTextBox.Text);
                cmd.Parameters.AddWithValue("codReparticaoFiscal", int.Parse(codReparticaoFiscalTextBox.Text));
                cmd.Parameters.AddWithValue("estadoActual", estadoActualTextBox.Text);
                cmd.Parameters.AddWithValue("profissao", profissaoTextBox.Text);
                cmd.Parameters.AddWithValue("balcaoOrigem", balcaoOrigemTextBox.Text);
                cmd.Parameters.AddWithValue("estadoCivil", estadoCivilTextBox.Text);
                cmd.Parameters.AddWithValue("tipodocumento", tipodocumentoTextBox.Text);
                cmd.Parameters.AddWithValue("nIdentificacao", int.Parse(nIdentificacaoTextBox.Text));
                cmd.Parameters.AddWithValue("PaísEmissao", paísEmissaoTextBox.Text);
                cmd.Parameters.AddWithValue("DataEmissao", DateTime.Parse(dataEmissaoDateTimePicker.Text));
                
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir cliente!\n " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }

                panelCaixasTexto.Enabled = false;                
                butInserir.Text = "Inserir";
                cliente cliente = new cliente();
                this.Close();
                cliente.Show();
            }
            else
            {
                //nBalcaoTextBox.Text = Global.getLastID(sender, e, "balcao", "nbalcao").ToString();
                //ntelefoneTextBox.Text = "";
                //nomeTextBox.Text = "";
                //horarioTextBox.Text = "";
                //paísTextBox.Text = "";
                //localidadeTextBox.Text = "";
                //enderecoTextBox.Text = "";
                //codPostalTextBox.Text = "";
                //servicosTextBox.Text = "";
                //faxTextBox.Text = "";


                int newIDCliente = Global.getLastID(sender, e, "cliente", "idCliente");

                idClienteTextBox.Text = newIDCliente.ToString();

                panelCaixasTexto.Enabled = true;
                butInserir.Text = "Guardar";
                butCancelar.Visible = true;
                butActualizar.Enabled = false;
                butEliminar.Enabled = false;
            } 
           
        }


        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (panelCaixasTexto.Enabled)
            {
                nIFTextBox.Enabled = false;

                if (verificaCaixasTexto(sender, e) == false)
                {
                    MessageBox.Show("Todos os campos devem estar preenchidos!", "Verificação");
                    return;
                }



                SqlConnection conn = Global.Conn;
                SqlCommand cmd = new SqlCommand("Spupdateidentificacao", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NIF", int.Parse(nIFTextBox.Text));
                cmd.Parameters.AddWithValue("nTelefone", int.Parse(nTelefoneTextBox.Text));
                cmd.Parameters.AddWithValue("nome", nomeTextBox.Text);
                cmd.Parameters.AddWithValue("dataNascimento", DateTime.Parse(dataNascimentoDateTimePicker.Text));
                cmd.Parameters.AddWithValue("país", paísTextBox.Text);
                cmd.Parameters.AddWithValue("localidade", localidadeTextBox.Text);
                cmd.Parameters.AddWithValue("endereco", enderecoTextBox.Text);
                cmd.Parameters.AddWithValue("codPostal", codPostalTextBox.Text);
                cmd.Parameters.AddWithValue("gênero", gêneroTextBox.Text);
                cmd.Parameters.AddWithValue("idade", int.Parse(idadeTextBox.Text));

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao actualizar identificação!\n " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }

                conn = Global.Conn;
                cmd = new SqlCommand("Spupdatecliente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idCliente", int.Parse(idClienteTextBox.Text));
                cmd.Parameters.AddWithValue("NIF", int.Parse(nIFTextBox.Text));
                cmd.Parameters.AddWithValue("nBalcao", int.Parse(nBalcaoTextBox.Text));
                cmd.Parameters.AddWithValue("nConta", int.Parse(nContaTextBox.Text));
                cmd.Parameters.AddWithValue("paísResidenciaFiscal", paísResidenciaFiscalTextBox.Text);
                cmd.Parameters.AddWithValue("codReparticaoFiscal", int.Parse(codReparticaoFiscalTextBox.Text));
                cmd.Parameters.AddWithValue("estadoActual", estadoActualTextBox.Text);
                cmd.Parameters.AddWithValue("profissao", profissaoTextBox.Text);
                cmd.Parameters.AddWithValue("balcaoOrigem", balcaoOrigemTextBox.Text);
                cmd.Parameters.AddWithValue("estadoCivil", estadoCivilTextBox.Text);
                cmd.Parameters.AddWithValue("tipodocumento", tipodocumentoTextBox.Text);
                cmd.Parameters.AddWithValue("nIdentificacao", int.Parse(nIdentificacaoTextBox.Text));
                cmd.Parameters.AddWithValue("PaísEmissao", paísEmissaoTextBox.Text);
                cmd.Parameters.AddWithValue("DataEmissao", DateTime.Parse(dataEmissaoDateTimePicker.Text));

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao actualizar cliente!\n " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }

                panelCaixasTexto.Enabled = false;
                nIFTextBox.Enabled = true;
                butActualizar.Text = "Actualizar";
                cliente cliente = new cliente();
                this.Close();
                cliente.Show();
            }
            else
            {
                nIFTextBox.Enabled = false;
                panelCaixasTexto.Enabled = true;
                butActualizar.Text = "Guardar";
                butCancelar.Visible = true;
                butInserir.Enabled = false;
                butEliminar.Enabled = false;
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (butEliminar.Text == "Confirmar")
            {
                SqlConnection conn = Global.Conn;
                SqlCommand cmd = new SqlCommand("Deletecliente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NIF", int.Parse(nIFTextBox.Text));
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao eliminar cliente! Antes de eliminar o cliente deve em primeiro lugar eliminar as operações associadas ao cliente.\n " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }
                
                conn = Global.Conn;
                cmd = new SqlCommand("Deleteidentificacao", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NIF", int.Parse(nIFTextBox.Text));
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao eliminar identificação!\n " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }

                butEliminar.Text = "Eliminar";
                cliente cliente = new cliente();
                this.Close();
                cliente.Show();
            }
            else
            {
                butEliminar.Text = "Confirmar";
                butCancelar.Visible = true;
                butInserir.Enabled = false;
                butActualizar.Enabled = false;
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            cliente cliente = new cliente();
            this.Close();
            cliente.Show();
        }

        private bool verificaCaixasTexto(object sender, EventArgs e)
        {
            //if (ntelefoneTextBox.Text == "" | nomeTextBox.Text == "" | horarioTextBox.Text == "" |
            //    paísTextBox.Text == "" | localidadeTextBox.Text == "" | enderecoTextBox.Text == "" |
            //    codPostalTextBox.Text == "" | servicosTextBox.Text == "" | faxTextBox.Text == "")
            //{
            //    return false;
            //}
            //else
            //{
            return true;
            //}
        }

        private void search(object sender, EventArgs e)
        {

            SqlConnection conn = Global.Conn;
            SqlCommand cmd = new SqlCommand("sp_FindStringInTable", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@stringToFind", geral.Text);
            cmd.Parameters.AddWithValue("@schema", "dbo");
            cmd.Parameters.AddWithValue("@table", "clientesviewidentificacao");
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar na tabela cliente!\n " + ex.Message);
                return;
            }
            finally
            {
                conn.Close();
            }

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            ClienteDataGridView.DataSource = dt;



        }

        private void pesquisaColunas(object sender, EventArgs e)
        {
            string nome=NomeP.Text;
            string país =paísP.Text;
            int nBalcao;
            SqlConnection conn = Global.Conn;
            

            if (nome == "" & país == "" & nBalcaoP.Text == "")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                da = new SqlDataAdapter("Select * FROM clientesviewidentificacao", conn);
                da.Fill(dt);


                ClienteDataGridView.DataSource = dt;
            }
            else if(nome == "" & país == "" & nBalcaoP.Text != "")
            {
                 nBalcao=Convert.ToInt32(nBalcaoP.Text);
                 SqlCommand cmd = new SqlCommand("Select * FROM clientesviewidentificacao WHERE nBalcao like " + nBalcao, conn);
                 DataTable dt = new DataTable();
                 SqlDataAdapter da;


                 da = new SqlDataAdapter("Select * FROM clientesviewidentificacao WHERE nBalcao like " + nBalcao, conn);
                 da.Fill(dt);


                 ClienteDataGridView.DataSource = dt;
           

            }
            else if (nome == "" & país != "" & nBalcaoP.Text == "")
            {
                

                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM clientesviewidentificacao WHERE país like '%" + país + "%'", conn);
                da.Fill(dt);


                ClienteDataGridView.DataSource = dt;
            }
            else if (nome == "" & país != "" & nBalcaoP.Text != "")
            {
                nBalcao = Convert.ToInt32(nBalcaoP.Text);
                
                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM clientesviewidentificacao WHERE nBalcao like " + nBalcao + " and país like '%" + país + "%'", conn);
                da.Fill(dt);


                ClienteDataGridView.DataSource = dt;
            }
            else if (nome != "" & país == "" & nBalcaoP.Text == "")
            {
               
                
                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM clientesviewidentificacao WHERE nome like '%" + nome + "%'", conn);
                da.Fill(dt);


                ClienteDataGridView.DataSource = dt;

            }
            else if (nome != "" & país == "" & nBalcaoP.Text != "")
            {
                nBalcao = Convert.ToInt32(nBalcaoP.Text);
                
                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM clientesviewidentificacao WHERE nBalcao like " + nBalcao + " and nome like '%" + nome + "%'", conn);
                da.Fill(dt);


                ClienteDataGridView.DataSource = dt;
            }
            else if (nome != "" & país != "" & nBalcaoP.Text == "")
            {
                
                
                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM clientesviewidentificacao WHERE país like '%" + país + "%' and nome like '%" + nome + "%'", conn);
                da.Fill(dt);


                ClienteDataGridView.DataSource = dt;

            }
            else if (nome != "" & país != "" & nBalcaoP.Text != "")
            {
                nBalcao = Convert.ToInt32(nBalcaoP.Text);
               
                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM clientesviewidentificacao WHERE nBalcao like " + nBalcao + " and país like '%" + país + "%' and nome like '%" + nome + "%'", conn);
                da.Fill(dt);


                ClienteDataGridView.DataSource = dt;
            }



            conn.Close();
            
            /*
            SqlConnection conn = Global.Conn;
            SqlDataReader rdr = null;
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            //conn = new SqlConnection("Server=(local);DataBase=Northwind;Integrated Security=SSPI");
            conn.Open();

            // 1.  create a command object identifying the stored procedure
            string command ="exec SP_UDFBalcao "+"@nome='"+nome+"',@nBalcao="+nBalcao+",@país='"+país+"'";
            da = new SqlDataAdapter(command, conn);
            da.Fill(dt);


            BalcaoDataGridView.DataSource = dt;
           
            
            conn.Close();
          
            */

        
          
        

        }

    }
}
