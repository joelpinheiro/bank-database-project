using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistBancario
{
    public partial class levantamento : Form
    {
        public levantamento()
        {
            InitializeComponent();
        }

        private void levantamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zLevantamento.levantamentosview' table. You can move, or remove it, as needed.
            this.levantamentosviewTableAdapter.Fill(this.zLevantamento.levantamentosview);
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
                
                if (!Global.exists(sender, e, "conta", "nConta", número_de_ContaTextBox.Text))
                {
                    MessageBox.Show("O campo número_de_ContaTextBox tem de existir!", "Verificação");
                    return;
                }


                if (!Global.exists(sender, e, "funcionario", "NIF", nIF_FuncionarioTextBox.Text))
                {
                    MessageBox.Show("O campo NIF do funcionário tem de existir!", "Verificação");
                    return;
                }

                int newIDOperacao = Global.getLastID(sender, e, "operacao", "idOperacao");
                int newIDLevantamento = Global.getLastID(sender, e, "levantamento", "idLevantamento");
                int NIFCliente = getNIF(int.Parse(número_de_ContaTextBox.Text));

                SqlConnection conn = Global.Conn;
                SqlCommand cmd = new SqlCommand("Spinsertoperacao", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idOperacao", newIDOperacao);
                cmd.Parameters.AddWithValue("tipo", "Levantamento");
                cmd.Parameters.AddWithValue("data", DateTime.Today);
                cmd.Parameters.AddWithValue("hora", DateTime.Now.TimeOfDay);
                cmd.Parameters.AddWithValue("NIF", nIF_FuncionarioTextBox.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir operação!\n " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }
                
                
                conn = Global.Conn;
                cmd = new SqlCommand("Spinsertlevantamento", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idOperacao", newIDOperacao);
                cmd.Parameters.AddWithValue("idlevantamento", newIDLevantamento);
                cmd.Parameters.AddWithValue("nConta", int.Parse(número_de_ContaTextBox.Text));
                cmd.Parameters.AddWithValue("montanteLevantamento", SqlMoney.Parse(montante_LevantadoTextBox.Text));

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir levantamento!\n " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }

               
                conn = Global.Conn;
                cmd = new SqlCommand("Spinsertsolicitacao", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idOperacao", newIDOperacao);
                cmd.Parameters.AddWithValue("NIF", NIFCliente);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir solicitação!\n " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }
                Cancelar.Enabled = false;

                panelCaixasTexto.Enabled = false;                
                butInserir.Text = "Inserir";
                levantamento levantamento = new levantamento();
                this.Close();
                levantamento.Show();
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


                int newIDOperacao = Global.getLastID(sender, e, "operacao", "idOperacao");
                int newIDLevantamento = Global.getLastID(sender, e, "levantamento", "idLevantamento");

                iD_OperaçãoTextBox.Text = newIDOperacao.ToString();
                iD_LevantamentoTextBox.Text = newIDLevantamento.ToString();

                dataDateTimePicker.Text = DateTime.Today.ToString();
                horaTextBox.Text = DateTime.Now.TimeOfDay.ToString();

                Cancelar.Enabled = true;
                panelCaixasTexto.Enabled = true;
                butInserir.Text = "Guardar";
                butEliminar.Enabled = false;
            } 
           
        }

        private int getNIF(int nconta)
        {
            int NIF = 0;
            try
            {
                Global.Conn.Open();

                // create a SqlCommand object for this connection
                SqlCommand command = Global.Conn.CreateCommand();
                command.CommandText = "SELECT tem.NIF FROM tem WHERE tem.nconta = " + nconta;

                // execute the command that returns a SqlDataReader
                var reader = command.ExecuteReader();

                // the results
                while (reader.Read())
                {
                    NIF = reader.GetInt32(0);
                }

                // close the connection
                reader.Close();
                Global.Conn.Close();
            }
            catch (Exception)
            {
                Global.Conn.Close();
            }
            return NIF;
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (butEliminar.Text == "Confirmar")
            {
                SqlConnection conn = Global.Conn;
                SqlCommand cmd = new SqlCommand("Spdeletelevantamento", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idOperacao", int.Parse(iD_OperaçãoTextBox.Text));
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao eliminar levantamento!" + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }

                conn = Global.Conn;
                cmd = new SqlCommand("Spdeleteassocia", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nConta", int.Parse(número_de_ContaTextBox.Text));
                cmd.Parameters.AddWithValue("idOperacao", int.Parse(iD_OperaçãoTextBox.Text));
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao eliminar associa!\n " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }

                conn = Global.Conn;
                cmd = new SqlCommand("Spdeletesolicitacao", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idOperacao", iD_OperaçãoTextBox.Text);
                
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao eliminar solicitação!\n " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }



                conn = Global.Conn;
                cmd = new SqlCommand("Spdeleteoperacao", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idOperacao", int.Parse(iD_OperaçãoTextBox.Text));
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao eliminar operação!\n " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }

                Cancelar.Enabled = false;
                butEliminar.Text = "Eliminar";
                levantamento levantamento = new levantamento();
                this.Close();
                levantamento.Show();
            }
            else
            {
                Cancelar.Enabled = true;
                butEliminar.Text = "Confirmar";
                butInserir.Enabled = false;
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {

            levantamento levantamento = new levantamento();
            this.Close();
            levantamento.Show();
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
            cmd.Parameters.AddWithValue("@table", "levantamentosview");
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar na tabela levantamento!\n " + ex.Message);
                return;
            }
            finally
            {
                conn.Close();
            }

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            LevantamentoDataGridView.DataSource = dt;



        }

        private void pesquisaColunas(object sender, EventArgs e)
        {
            int idOperacao;
            int idLevantamento;
            int nConta;
            SqlConnection conn = Global.Conn;

            if (ID.Text == "" & NConta.Text == "" & IDOperacao.Text == "")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                da = new SqlDataAdapter("Select * FROM levantamentosview", conn);
                da.Fill(dt);


                LevantamentoDataGridView.DataSource = dt;
            }
            else if (ID.Text == "" & NConta.Text == "" & IDOperacao.Text != "")
            {
                 idOperacao = Convert.ToInt32(IDOperacao.Text);

                
                 DataTable dt = new DataTable();
                 SqlDataAdapter da;

                 da = new SqlDataAdapter("Select * FROM levantamentosview WHERE \"ID Operação\" = " + idOperacao, conn);
                 da.Fill(dt);


                 LevantamentoDataGridView.DataSource = dt;
           

            }
            else if (ID.Text == "" & NConta.Text != "" & IDOperacao.Text == "")
            {

                nConta = Convert.ToInt32(NConta.Text);

                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM levantamentosview WHERE \"Número de Conta\" = " + nConta, conn);
                da.Fill(dt);


                LevantamentoDataGridView.DataSource = dt;
            }
            else if (ID.Text == "" & NConta.Text != "" & IDOperacao.Text != "")
            {
                idOperacao = Convert.ToInt32(IDOperacao.Text);
                nConta = Convert.ToInt32(NConta.Text);
                
                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM levantamentosview WHERE \"Número de Conta\" = " + nConta + " and \"ID Operação\" =" + idOperacao, conn);
                da.Fill(dt);


                LevantamentoDataGridView.DataSource = dt;
            }
            else if (ID.Text != "" & NConta.Text == "" & IDOperacao.Text == "")
            {
                idLevantamento = Convert.ToInt32(ID.Text);
                
                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM levantamentosview WHERE \"ID Levantamento\" =" + idLevantamento, conn);
                da.Fill(dt);


                LevantamentoDataGridView.DataSource = dt;

            }
            else if (ID.Text != "" & NConta.Text == "" & IDOperacao.Text != "")
            {
                idOperacao = Convert.ToInt32(IDOperacao.Text);
                idLevantamento = Convert.ToInt32(ID.Text);

                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM levantamentosview WHERE \"ID Operação\"=" + idOperacao + " and \"ID Levantamento\" =" + idLevantamento, conn);
                da.Fill(dt);


                LevantamentoDataGridView.DataSource = dt;
            }
            else if (ID.Text != "" & NConta.Text != "" & IDOperacao.Text == "")
            {
                idLevantamento = Convert.ToInt32(ID.Text);
                nConta = Convert.ToInt32(NConta.Text);
                
                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM levantamentosview WHERE \"ID Levantamento\"=" + idLevantamento + " and \"Número de Conta\"=" + nConta, conn);
                da.Fill(dt);


                LevantamentoDataGridView.DataSource = dt;

            }
            else if (ID.Text != "" & NConta.Text != "" & IDOperacao.Text != "")
            {
                idOperacao = Convert.ToInt32(IDOperacao.Text);
                idLevantamento = Convert.ToInt32(ID.Text);
                nConta = Convert.ToInt32(NConta.Text);
               
                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM levantamentosview WHERE \"Número de Conta\"=" + nConta + " and \"ID Levantamento\" =" + idLevantamento + " and \"ID Operação\" =" + idOperacao, conn);
                da.Fill(dt);


                LevantamentoDataGridView.DataSource = dt;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tipoLabel_Click(object sender, EventArgs e)
        {

        }

        private void nIF_FuncionarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void nIF_FuncionarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
