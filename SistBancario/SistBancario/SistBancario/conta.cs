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
    public partial class conta : Form
    {
        public conta()
        {
            InitializeComponent();
        }

        private void conta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zConta.contaview' table. You can move, or remove it, as needed.
            this.contaviewTableAdapter.Fill(this.zConta.contaview);
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
                
                if (!Global.exists(sender, e, "cliente", "NIF", nIFTextBox.Text))
                {
                    MessageBox.Show("O NIF tem de existir!", "Verificação");
                    return;
                }

                if (!Global.exists(sender, e, "balcao", "nome", balcão_AssociadoTextBox.Text))
                {
                    MessageBox.Show("O Balcão Associado tem de existir!", "Verificação");
                    return;
                }

                int newNConta = Global.getLastID(sender, e, "conta", "nConta");

                SqlConnection conn = Global.Conn;
                SqlCommand cmd = new SqlCommand("Spinsertconta", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nConta", número_de_ContaTextBox.Text);
                cmd.Parameters.AddWithValue("tipoConta", tipoTextBox.Text);
                cmd.Parameters.AddWithValue("balcaoAssociado", balcão_AssociadoTextBox.Text);
                cmd.Parameters.AddWithValue("saldo", saldoTextBox.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir conta!\n " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }
                
                


                conn = Global.Conn;
                cmd = new SqlCommand("Spinserttem", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nConta", int.Parse(número_de_ContaTextBox.Text));
                cmd.Parameters.AddWithValue("NIF", int.Parse(nIFTextBox.Text));

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir no 'tem'!\n " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }
                butCancelar.Visible = false;
                panelCaixasTexto.Enabled = false;                
                butInserir.Text = "Inserir";
                conta conta = new conta();
                this.Close();
                conta.Show();
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


                int newNConta = Global.getLastID(sender, e, "conta", "nConta");

                número_de_ContaTextBox.Text = newNConta.ToString();
                butCancelar.Visible = true;
                panelCaixasTexto.Enabled = true;
                butInserir.Text = "Guardar";
                butEliminar.Enabled = false;
            } 
           
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (butEliminar.Text == "Confirmar")
            {


                SqlConnection conn = Global.Conn;
                SqlCommand cmd = new SqlCommand("Spdeletetem", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nConta", int.Parse(número_de_ContaTextBox.Text));
                cmd.Parameters.AddWithValue("NIF", int.Parse(nIFTextBox.Text));
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao eliminar 'tem'!\n " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }

                conn = Global.Conn;
                cmd = new SqlCommand("Spdeleteconta", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nConta", int.Parse(número_de_ContaTextBox.Text));
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao eliminar conta!" + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }

                butEliminar.Text = "Eliminar";
                butCancelar.Visible = false;
                conta conta = new conta();
                this.Close();
                conta.Show();
            }
            else
            {
                butCancelar.Visible = true;
                butEliminar.Text = "Confirmar";
                butInserir.Enabled = false;
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {

            conta conta = new conta();
            this.Close();
            conta.Show();
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
            cmd.Parameters.AddWithValue("@table", "contaview");
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar na tabela conta!\n " + ex.Message);
                return;
            }
            finally
            {
                conn.Close();
            }

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            TransferenciaDataGridView.DataSource = dt;



        }

        private void pesquisaColunas(object sender, EventArgs e)
        {
            int nConta;
            string tipo = butTipo.Text;
            string balcaoAssociado = butBalcaoAssociado.Text;
            SqlConnection conn = Global.Conn;

            if (butNConta.Text == "" & tipo == "" & balcaoAssociado == "")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                da = new SqlDataAdapter("Select * FROM contaview", conn);
                da.Fill(dt);


                TransferenciaDataGridView.DataSource = dt;
            }
            else if (butNConta.Text == "" & tipo == "" & balcaoAssociado != "")
            {
              
                
                 DataTable dt = new DataTable();
                 SqlDataAdapter da;

                 da = new SqlDataAdapter("Select * FROM contaview WHERE \"Balcão Associado\" like '%" + balcaoAssociado + "%'", conn);
                 da.Fill(dt);


                 TransferenciaDataGridView.DataSource = dt;
           

            }
            else if (butNConta.Text == "" & tipo != "" & balcaoAssociado == "")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM contaview WHERE \"Tipo\" like '%" + tipo + "%'", conn);
                da.Fill(dt);


                TransferenciaDataGridView.DataSource = dt;
            }
            else if (butNConta.Text == "" & tipo != "" & balcaoAssociado != "")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM contaview WHERE \"Tipo\" like '%" + tipo + "%' and \"Balcão Associado\" like '%" + balcaoAssociado + "%'", conn);
                da.Fill(dt);


                TransferenciaDataGridView.DataSource = dt;
            }
            else if (butNConta.Text != "" & tipo == "" & balcaoAssociado == "")
            {
                nConta = Convert.ToInt32(butNConta.Text);

                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM contaview WHERE \"Número de Conta\"=" + nConta, conn);
                da.Fill(dt);


                TransferenciaDataGridView.DataSource = dt;

            }
            else if (butNConta.Text != "" & tipo == "" & balcaoAssociado != "")
            {
                nConta = Convert.ToInt32(butNConta.Text);

                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM contaview WHERE \"Número de Conta\"=" + nConta + " and \"Balcão Associado\" like '%" + balcaoAssociado + "%'", conn);
                da.Fill(dt);


                TransferenciaDataGridView.DataSource = dt;
            }
            else if (butNConta.Text != "" & tipo != "" & balcaoAssociado == "")
            {
                nConta = Convert.ToInt32(butNConta.Text);

                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM contaview WHERE \"Número de Conta\"=" + nConta + " and \"Tipo\" like '%" + tipo + "%'", conn);
                da.Fill(dt);

                TransferenciaDataGridView.DataSource = dt;

            }
            else if (butNConta.Text != "" & tipo != "" & balcaoAssociado != "")
            {
                nConta = Convert.ToInt32(butNConta.Text);
               
                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM contaview WHERE \"Número de Conta\"=" + nConta + " and \"Tipo\" like '%" + tipo + "%' and \"Balcão Associado\" like '%" + balcaoAssociado + "%'", conn);
                da.Fill(dt);


                TransferenciaDataGridView.DataSource = dt;
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

        private void butActualizar_Click(object sender, EventArgs e)
        {
            if (panelCaixasTexto.Enabled)
            {
                nIFTextBox.Enabled = false;

                if (verificaCaixasTexto(sender, e) == false)
                {
                    MessageBox.Show("Todos os campos devem estar preenchidos!", "Verificação");
                    return;
                }

                if (!Global.exists(sender, e, "balcao", "nome", balcão_AssociadoTextBox.Text))
                {
                    MessageBox.Show("O Balcão Associado tem de existir!", "Verificação");
                    return;
                }

                SqlConnection conn = Global.Conn;
                SqlCommand cmd = new SqlCommand("SpUpdateConta", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nConta", int.Parse(número_de_ContaTextBox.Text));
                cmd.Parameters.AddWithValue("balcaoAssociado", balcão_AssociadoTextBox.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao actualizar conta!\n " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }

                panelCaixasTexto.Enabled = false;
                nIFTextBox.Enabled = true;
                tipoTextBox.Enabled = true;
                saldoTextBox.Enabled = true;

                butActualizar.Text = "Actualizar";
                conta conta = new conta();
                this.Close();
                conta.Show();
            }
            else
            {
                tipoTextBox.Enabled = false;
                saldoTextBox.Enabled = false;
                nIFTextBox.Enabled = false;
                panelCaixasTexto.Enabled = true;
                butActualizar.Text = "Guardar";
                butCancelar.Visible = true;
                butInserir.Enabled = false;
                butEliminar.Enabled = false;
            }
        }




    }
}
