﻿using System;
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
    public partial class funcionario : Form
    {
        public funcionario()
        {
            InitializeComponent();
        }

        private void funcionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zFuncionario.funcionariosviewidentificacao' table. You can move, or remove it, as needed.
            this.funcionariosviewidentificacaoTableAdapter.Fill(this.zFuncionario.funcionariosviewidentificacao);
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


                int newIDFuncionario = Global.getLastID(sender, e, "funcionario", "idFuncionario");

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
                cmd = new SqlCommand("Spinsertfuncionario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NIF", int.Parse(nIFTextBox.Text));
                cmd.Parameters.AddWithValue("idFuncionario", int.Parse(idFuncionarioTextBox.Text));
                cmd.Parameters.AddWithValue("horarioT", horarioTTextBox.Text);
                cmd.Parameters.AddWithValue("funcao", funcaoTextBox.Text);
                cmd.Parameters.AddWithValue("salario", SqlMoney.Parse(salarioTextBox.Text));
                cmd.Parameters.AddWithValue("balcaoTrabalho", balcaoTrabalhoTextBox.Text);
                cmd.Parameters.AddWithValue("nbalcao", nbalcaoTextBox.Text);
                
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir funcionário!\n " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }

                panelCaixasTexto.Enabled = false;                
                butInserir.Text = "Inserir";
                funcionario funcionario = new funcionario();
                this.Close();
                funcionario.Show();
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


                int newIDFuncionario = Global.getLastID(sender, e, "funcionario", "idFuncionario");

                //idClienteTextBox.Text = newIDCliente.ToString();

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
                cmd = new SqlCommand("Spupdatefuncionario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NIF", int.Parse(nIFTextBox.Text));
                cmd.Parameters.AddWithValue("idFuncionario", int.Parse(idFuncionarioTextBox.Text));
                cmd.Parameters.AddWithValue("horarioT", horarioTTextBox.Text);
                cmd.Parameters.AddWithValue("funcao", funcaoTextBox.Text);
                cmd.Parameters.AddWithValue("salario", SqlMoney.Parse(salarioTextBox.Text));
                cmd.Parameters.AddWithValue("balcaoTrabalho", balcaoTrabalhoTextBox.Text);
                cmd.Parameters.AddWithValue("nbalcao", nbalcaoTextBox.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao actualizar funcionário!\n " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }

                panelCaixasTexto.Enabled = false;
                nIFTextBox.Enabled = true;
                butActualizar.Text = "Actualizar";
                funcionario funcionario = new funcionario();
                this.Close();
                funcionario.Show();
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
                SqlCommand cmd = new SqlCommand("Deletefuncionario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NIF", int.Parse(nIFTextBox.Text));
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao eliminar funcionário! Antes de eliminar o funcionário deve em primeiro lugar eliminar as operações associadas ao funcionário.\n " + ex.Message);
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
                funcionario funcionario = new funcionario();
                this.Close();
                funcionario.Show();
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
            funcionario funcionario = new funcionario();
            this.Close();
            funcionario.Show();
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
            cmd.Parameters.AddWithValue("@table", "funcionariosviewidentificacao");
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar na tabela funcionario!\n " + ex.Message);
                return;
            }
            finally
            {
                conn.Close();
            }

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            FuncionarioDataGridView.DataSource = dt;



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
                da = new SqlDataAdapter("Select * FROM funcionariosviewidentificacao", conn);
                da.Fill(dt);


                FuncionarioDataGridView.DataSource = dt;
            }
            else if(nome == "" & país == "" & nBalcaoP.Text != "")
            {
                 nBalcao=Convert.ToInt32(nBalcaoP.Text);
                 SqlCommand cmd = new SqlCommand("Select * FROM funcionariosviewidentificacao WHERE nBalcao like " + nBalcao, conn);
                 DataTable dt = new DataTable();
                 SqlDataAdapter da;


                 da = new SqlDataAdapter("Select * FROM funcionariosviewidentificacao WHERE nBalcao like " + nBalcao, conn);
                 da.Fill(dt);


                 FuncionarioDataGridView.DataSource = dt;
           

            }
            else if (nome == "" & país != "" & nBalcaoP.Text == "")
            {
                

                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM funcionariosviewidentificacao WHERE país like '%" + país + "%'", conn);
                da.Fill(dt);


                FuncionarioDataGridView.DataSource = dt;
            }
            else if (nome == "" & país != "" & nBalcaoP.Text != "")
            {
                nBalcao = Convert.ToInt32(nBalcaoP.Text);
                
                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM funcionariosviewidentificacao WHERE nBalcao like " + nBalcao + " and país like '%" + país + "%'", conn);
                da.Fill(dt);


                FuncionarioDataGridView.DataSource = dt;
            }
            else if (nome != "" & país == "" & nBalcaoP.Text == "")
            {
               
                
                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM funcionariosviewidentificacao WHERE nome like '%" + nome + "%'", conn);
                da.Fill(dt);


                FuncionarioDataGridView.DataSource = dt;

            }
            else if (nome != "" & país == "" & nBalcaoP.Text != "")
            {
                nBalcao = Convert.ToInt32(nBalcaoP.Text);
                
                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM funcionariosviewidentificacao WHERE nBalcao like " + nBalcao + " and nome like '%" + nome + "%'", conn);
                da.Fill(dt);


                FuncionarioDataGridView.DataSource = dt;
            }
            else if (nome != "" & país != "" & nBalcaoP.Text == "")
            {
                
                
                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM funcionariosviewidentificacao WHERE país like '%" + país + "%' and nome like '%" + nome + "%'", conn);
                da.Fill(dt);


                FuncionarioDataGridView.DataSource = dt;

            }
            else if (nome != "" & país != "" & nBalcaoP.Text != "")
            {
                nBalcao = Convert.ToInt32(nBalcaoP.Text);
               
                DataTable dt = new DataTable();
                SqlDataAdapter da;


                da = new SqlDataAdapter("Select * FROM funcionariosviewidentificacao WHERE nBalcao like " + nBalcao + " and país like '%" + país + "%' and nome like '%" + nome + "%'", conn);
                da.Fill(dt);


                FuncionarioDataGridView.DataSource = dt;
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
