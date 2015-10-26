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
    public partial class operacao : Form
    {
        public operacao()
        {
            InitializeComponent();
        }

        private void operacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zOperacao.operacaoview' table. You can move, or remove it, as needed.
            this.operacaoviewTableAdapter.Fill(this.zOperacao.operacaoview);
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

        //private void Inserir_Click(object sender, EventArgs e)
        //{
        //    if (panelCaixasTexto.Enabled)
        //    {
        //        //if (verificaCaixasTexto(sender, e) == false)
        //        //{
        //        //    MessageBox.Show("Todos os campos devem estar preenchidos!", "Verificação");
        //        //    return;
        //        //}
                
        //        SqlConnection conn = Global.Conn;
        //        SqlCommand cmd = new SqlCommand("Spinsertoperacao", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("nbalcao", iD_OperaçãoTextBox.Text);
        //        cmd.Parameters.AddWithValue("nome", nIF_ClienteTextBox.Text);
        //        cmd.Parameters.AddWithValue("horario", número_ContaTextBox.Text);
        //        cmd.Parameters.AddWithValue("país", nIF_FuncionarioTextBox.Text);
        //        cmd.Parameters.AddWithValue("localidade", tipoTextBox.Text);
        //        cmd.Parameters.AddWithValue("endereco", dataDateTimePicker.Text);
        //        cmd.Parameters.AddWithValue("codpostal", horaTextBox.Text);
        //        try
        //        {
        //            conn.Open();
        //            cmd.ExecuteNonQuery();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Erro ao inserir operação!\n " + ex.Message);
        //            return;
        //        }
        //        finally
        //        {
        //            conn.Close();
        //        }

        //        panelCaixasTexto.Enabled = false;                
        //        butInserir.Text = "Inserir";
        //        operacao operacao = new operacao();
        //        this.Close();
        //        operacao.Show();
        //    }
        //    else
        //    {
        //        //nBalcaoTextBox.Text = Global.getLastID(sender, e, "balcao", "nbalcao").ToString();
        //        //ntelefoneTextBox.Text = "";
        //        //nomeTextBox.Text = "";
        //        //horarioTextBox.Text = "";
        //        //paísTextBox.Text = "";
        //        //localidadeTextBox.Text = "";
        //        //enderecoTextBox.Text = "";
        //        //codPostalTextBox.Text = "";
        //        //servicosTextBox.Text = "";
        //        //faxTextBox.Text = "";
                
        //        panelCaixasTexto.Enabled = true;
        //        butInserir.Text = "Guardar";
        //        butCancelar.Visible = true;
        //        butActualizar.Enabled = false;
        //        butEliminar.Enabled = false;

        //    } 
           
        //}


        //private void Actualizar_Click(object sender, EventArgs e)
        //{
        //    if (panelCaixasTexto.Enabled)
        //    {
        //        //if (verificaCaixasTexto(sender, e) == false)
        //        //{
        //        //    MessageBox.Show("Todos os campos devem estar preenchidos!", "Verificação");
        //        //    return;
        //        //}
                
                
        //        SqlConnection conn = Global.Conn;
        //        SqlCommand cmd = new SqlCommand("Spupdateoperacao", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        //cmd.Parameters.AddWithValue("nbalcao", int.Parse(nBalcaoTextBox.Text));
        //        //cmd.Parameters.AddWithValue("ntelefone", int.Parse(ntelefoneTextBox.Text));
        //        //cmd.Parameters.AddWithValue("nome", nomeTextBox.Text);
        //        //cmd.Parameters.AddWithValue("horario", horarioTextBox.Text);
        //        //cmd.Parameters.AddWithValue("país", paísTextBox.Text);
        //        //cmd.Parameters.AddWithValue("localidade", localidadeTextBox.Text);
        //        //cmd.Parameters.AddWithValue("endereco", enderecoTextBox.Text);
        //        //cmd.Parameters.AddWithValue("codpostal", codPostalTextBox.Text);
        //        //cmd.Parameters.AddWithValue("servicos", servicosTextBox.Text);
        //        //cmd.Parameters.AddWithValue("fax", int.Parse(faxTextBox.Text));
        //        try
        //        {
        //            conn.Open();
        //            cmd.ExecuteNonQuery();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Erro ao actualizar operação!\n " + ex.Message);
        //            return;
        //        }
        //        finally
        //        {
        //            conn.Close();
        //        }

        //        panelCaixasTexto.Enabled = false;
        //        butActualizar.Text = "Actualizar";
        //        operacao operacao = new operacao();
        //        this.Close();
        //        operacao.Show();
        //    }
        //    else
        //    {
        //        panelCaixasTexto.Enabled = true;
        //        butActualizar.Text = "Guardar";
        //        butCancelar.Visible = true;
        //        butInserir.Enabled = false;
        //        butEliminar.Enabled = false;
        //    }
        //}

        //private void Eliminar_Click(object sender, EventArgs e)
        //{
        //    if (butEliminar.Text == "Confirmar")
        //    {
        //        SqlConnection conn = Global.Conn;
        //        SqlCommand cmd = new SqlCommand("Deleteoperacao", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        //cmd.Parameters.AddWithValue("nbalcao", int.Parse(nBalcaoTextBox.Text));
        //        try
        //        {
        //            conn.Open();
        //            cmd.ExecuteNonQuery();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Erro ao actualizar balcão!\n " + ex.Message);
        //            return;
        //        }
        //        finally
        //        {
        //            conn.Close();
        //        }

        //        butEliminar.Text = "Eliminar";
        //        operacao operacao = new operacao();
        //        this.Close();
        //        operacao.Show();
        //    }
        //    else
        //    {
        //        butEliminar.Text = "Confirmar";
        //        butCancelar.Visible = true;
        //        butInserir.Enabled = false;
        //        butActualizar.Enabled = false;
        //    }
        //}

        //private void butCancelar_Click(object sender, EventArgs e)
        //{
        //    operacao operacao = new operacao();
        //    this.Close();
        //    operacao.Show();
        //}

        ////private bool verificaCaixasTexto(object sender, EventArgs e)
        ////{
        ////    if (ntelefoneTextBox.Text == "" | nomeTextBox.Text == "" | horarioTextBox.Text == "" |
        ////        paísTextBox.Text == "" | localidadeTextBox.Text == "" | enderecoTextBox.Text == "" |
        ////        codPostalTextBox.Text == "" | servicosTextBox.Text == "" | faxTextBox.Text == "")
        ////    {
        ////        return false;
        ////    }
        ////    else
        ////    {
        ////        return true;
        ////    }
        ////}

        private void search(object sender, EventArgs e)
        {
            string nome = IDOperacao.Text;
            string país = NConta.Text;
            int nBalcao;

            

            SqlConnection conn = Global.Conn;
            SqlCommand cmd = new SqlCommand("sp_FindStringInTable", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@stringToFind", geral.Text);
            cmd.Parameters.AddWithValue("@schema", "dbo");
            cmd.Parameters.AddWithValue("@table", "operacaoview");
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar na tabela operação!\n " + ex.Message);
                return;
            }
            finally
            {
                conn.Close();
            }

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            OperacaoDataGridView.DataSource = dt;


            //if (geral.Text == "")
            //{
            //    zBalcao.Reset();
            //    this.tableAdapterManager.UpdateAll(this.zBalcao);
            //}

        }

        private void pesquisaColunas(object sender, EventArgs e)
        {
            int idOperacao;
            string tipo = Tipotxt.Text;
            int nConta;
            SqlConnection conn = Global.Conn;

            if (Tipotxt.Text == "" & NConta.Text == "" & IDOperacao.Text == "")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                da = new SqlDataAdapter("Select * FROM operacaoview", conn);
                da.Fill(dt);


                OperacaoDataGridView.DataSource = dt;
            }
            else if (Tipotxt.Text == "" & NConta.Text == "" & IDOperacao.Text != "")
            {
                idOperacao = Convert.ToInt32(IDOperacao.Text);


                DataTable dt = new DataTable();
                SqlDataAdapter da;

                da = new SqlDataAdapter("Select * FROM operacaoview WHERE \"ID Operação\" = " + idOperacao, conn);
                da.Fill(dt);


                OperacaoDataGridView.DataSource = dt;


            }
            else if (Tipotxt.Text == "" & NConta.Text != "" & IDOperacao.Text == "")
            {

                nConta = Convert.ToInt32(NConta.Text);

                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM operacaoview WHERE \"Número Conta\" = " + nConta, conn);
                da.Fill(dt);


                OperacaoDataGridView.DataSource = dt;
            }
            else if (Tipotxt.Text == "" & NConta.Text != "" & IDOperacao.Text != "")
            {
                idOperacao = Convert.ToInt32(IDOperacao.Text);
                nConta = Convert.ToInt32(NConta.Text);

                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM operacaoview WHERE \"Número Conta\" = " + nConta + " and \"ID Operação\" =" + idOperacao, conn);
                da.Fill(dt);


                OperacaoDataGridView.DataSource = dt;
            }
            else if (Tipotxt.Text != "" & NConta.Text == "" & IDOperacao.Text == "")
            {

                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM operacaoview WHERE tipo like '%" + tipo + "%'", conn);
                da.Fill(dt);


                OperacaoDataGridView.DataSource = dt;

            }
            else if (Tipotxt.Text != "" & NConta.Text == "" & IDOperacao.Text != "")
            {
                idOperacao = Convert.ToInt32(IDOperacao.Text);

                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM operacaoview WHERE \"ID Operação\"=" + idOperacao + " and tipo like '%" + tipo + "%'", conn);
                da.Fill(dt);


                OperacaoDataGridView.DataSource = dt;
            }
            else if (Tipotxt.Text != "" & NConta.Text != "" & IDOperacao.Text == "")
            {
                nConta = Convert.ToInt32(NConta.Text);

                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM operacaoview WHERE tipo like '%" + tipo + "%' and \"Número Conta\"=" + nConta, conn);
                da.Fill(dt);


                OperacaoDataGridView.DataSource = dt;

            }
            else if (Tipotxt.Text != "" & NConta.Text != "" & IDOperacao.Text != "")
            {
                idOperacao = Convert.ToInt32(IDOperacao.Text);
                nConta = Convert.ToInt32(NConta.Text);

                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM operacaoview WHERE \"Número Conta\"=" + nConta + " and tipo like '%" + tipo + "%' and \"ID Operação\" =" + idOperacao, conn);
                da.Fill(dt);


                OperacaoDataGridView.DataSource = dt;
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

        private void buTransferencia_Click(object sender, EventArgs e)
        {
            this.Hide();
            transferencia transferencia = new transferencia();
            transferencia.Show();

        }

        private void butDeposito_Click(object sender, EventArgs e)
        {
            this.Hide();
            deposito deposito = new deposito();
            deposito.Show();
        }

        private void butEmprestimo_Click(object sender, EventArgs e)
        {
            this.Hide();
            emprestimo emprestimo = new emprestimo();
            emprestimo.Show();
        }

        private void butLevantamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            levantamento levantamento = new levantamento();
            levantamento.Show();
        }
    }
}
