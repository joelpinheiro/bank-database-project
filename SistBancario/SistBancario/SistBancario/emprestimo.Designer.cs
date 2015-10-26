namespace SistBancario
{
    partial class emprestimo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_OperaçãoLabel;
            System.Windows.Forms.Label iD_EmprestimoLabel;
            System.Windows.Forms.Label número_de_ContaLabel;
            System.Windows.Forms.Label valor_de_EmprestimoLabel;
            System.Windows.Forms.Label tipo_EmprestimoLabel;
            System.Windows.Forms.Label taxa_de_JuroLabel;
            System.Windows.Forms.Label nIF_FuncionarioLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label horaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emprestimo));
            this.EmprestimoDataGridView = new System.Windows.Forms.DataGridView();
            this.iDOperaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEmprestimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.númeroDeContaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDeEmprestimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEmprestimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxaDeJuroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emprestimoviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zEmprestimo = new SistBancario.zEmprestimo();
            this.clientesviewidentificacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zCliente = new SistBancario.zCliente();
            this.balcaoviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zBalcao = new SistBancario.zBalcao();
            this.balcaoviewTableAdapter = new SistBancario.zBalcaoTableAdapters.balcaoviewTableAdapter();
            this.tableAdapterManager = new SistBancario.zBalcaoTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPesquisa = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.geral = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.NConta = new System.Windows.Forms.TextBox();
            this.IDOperacao = new System.Windows.Forms.TextBox();
            this.panelCaixasTexto = new System.Windows.Forms.Panel();
            this.iD_OperaçãoTextBox = new System.Windows.Forms.TextBox();
            this.iD_EmprestimoTextBox = new System.Windows.Forms.TextBox();
            this.número_de_ContaTextBox = new System.Windows.Forms.TextBox();
            this.valor_de_EmprestimoTextBox = new System.Windows.Forms.TextBox();
            this.tipo_EmprestimoTextBox = new System.Windows.Forms.TextBox();
            this.taxa_de_JuroTextBox = new System.Windows.Forms.TextBox();
            this.nIF_FuncionarioTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaTextBox = new System.Windows.Forms.TextBox();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.butCancelar = new System.Windows.Forms.Button();
            this.butEliminar = new System.Windows.Forms.Button();
            this.butInserir = new System.Windows.Forms.Button();
            this.butMenuInicial = new System.Windows.Forms.Button();
            this.lblAjuda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clientesviewidentificacaoTableAdapter = new SistBancario.zClienteTableAdapters.clientesviewidentificacaoTableAdapter();
            this.tableAdapterManager1 = new SistBancario.zClienteTableAdapters.TableAdapterManager();
            this.emprestimoviewTableAdapter = new SistBancario.zEmprestimoTableAdapters.emprestimoviewTableAdapter();
            this.tableAdapterManager2 = new SistBancario.zEmprestimoTableAdapters.TableAdapterManager();
            iD_OperaçãoLabel = new System.Windows.Forms.Label();
            iD_EmprestimoLabel = new System.Windows.Forms.Label();
            número_de_ContaLabel = new System.Windows.Forms.Label();
            valor_de_EmprestimoLabel = new System.Windows.Forms.Label();
            tipo_EmprestimoLabel = new System.Windows.Forms.Label();
            taxa_de_JuroLabel = new System.Windows.Forms.Label();
            nIF_FuncionarioLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmprestimoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimoviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEmprestimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesviewidentificacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balcaoviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zBalcao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPesquisa.SuspendLayout();
            this.panelCaixasTexto.SuspendLayout();
            this.panelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_OperaçãoLabel
            // 
            iD_OperaçãoLabel.AutoSize = true;
            iD_OperaçãoLabel.Location = new System.Drawing.Point(343, 27);
            iD_OperaçãoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            iD_OperaçãoLabel.Name = "iD_OperaçãoLabel";
            iD_OperaçãoLabel.Size = new System.Drawing.Size(71, 13);
            iD_OperaçãoLabel.TabIndex = 0;
            iD_OperaçãoLabel.Text = "ID Operação:";
            // 
            // iD_EmprestimoLabel
            // 
            iD_EmprestimoLabel.AutoSize = true;
            iD_EmprestimoLabel.Location = new System.Drawing.Point(343, 57);
            iD_EmprestimoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            iD_EmprestimoLabel.Name = "iD_EmprestimoLabel";
            iD_EmprestimoLabel.Size = new System.Drawing.Size(78, 13);
            iD_EmprestimoLabel.TabIndex = 2;
            iD_EmprestimoLabel.Text = "ID Emprestimo:";
            iD_EmprestimoLabel.Click += new System.EventHandler(this.iD_EmprestimoLabel_Click);
            // 
            // número_de_ContaLabel
            // 
            número_de_ContaLabel.AutoSize = true;
            número_de_ContaLabel.Location = new System.Drawing.Point(343, 86);
            número_de_ContaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            número_de_ContaLabel.Name = "número_de_ContaLabel";
            número_de_ContaLabel.Size = new System.Drawing.Size(93, 13);
            número_de_ContaLabel.TabIndex = 4;
            número_de_ContaLabel.Text = "Número de Conta:";
            // 
            // valor_de_EmprestimoLabel
            // 
            valor_de_EmprestimoLabel.AutoSize = true;
            valor_de_EmprestimoLabel.Location = new System.Drawing.Point(17, 27);
            valor_de_EmprestimoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            valor_de_EmprestimoLabel.Name = "valor_de_EmprestimoLabel";
            valor_de_EmprestimoLabel.Size = new System.Drawing.Size(106, 13);
            valor_de_EmprestimoLabel.TabIndex = 6;
            valor_de_EmprestimoLabel.Text = "Valor de Emprestimo:";
            // 
            // tipo_EmprestimoLabel
            // 
            tipo_EmprestimoLabel.AutoSize = true;
            tipo_EmprestimoLabel.Location = new System.Drawing.Point(16, 60);
            tipo_EmprestimoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tipo_EmprestimoLabel.Name = "tipo_EmprestimoLabel";
            tipo_EmprestimoLabel.Size = new System.Drawing.Size(88, 13);
            tipo_EmprestimoLabel.TabIndex = 8;
            tipo_EmprestimoLabel.Text = "Tipo Emprestimo:";
            // 
            // taxa_de_JuroLabel
            // 
            taxa_de_JuroLabel.AutoSize = true;
            taxa_de_JuroLabel.Location = new System.Drawing.Point(16, 86);
            taxa_de_JuroLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            taxa_de_JuroLabel.Name = "taxa_de_JuroLabel";
            taxa_de_JuroLabel.Size = new System.Drawing.Size(72, 13);
            taxa_de_JuroLabel.TabIndex = 10;
            taxa_de_JuroLabel.Text = "Taxa de Juro:";
            // 
            // nIF_FuncionarioLabel
            // 
            nIF_FuncionarioLabel.AutoSize = true;
            nIF_FuncionarioLabel.Location = new System.Drawing.Point(343, 120);
            nIF_FuncionarioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nIF_FuncionarioLabel.Name = "nIF_FuncionarioLabel";
            nIF_FuncionarioLabel.Size = new System.Drawing.Size(85, 13);
            nIF_FuncionarioLabel.TabIndex = 12;
            nIF_FuncionarioLabel.Text = "NIF Funcionario:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(18, 0);
            tipoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 14;
            tipoLabel.Text = "Tipo:";
            tipoLabel.Visible = false;
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(16, 114);
            dataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 16;
            dataLabel.Text = "Data:";
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(17, 148);
            horaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(33, 13);
            horaLabel.TabIndex = 18;
            horaLabel.Text = "Hora:";
            // 
            // EmprestimoDataGridView
            // 
            this.EmprestimoDataGridView.AllowUserToAddRows = false;
            this.EmprestimoDataGridView.AllowUserToDeleteRows = false;
            this.EmprestimoDataGridView.AllowUserToResizeRows = false;
            this.EmprestimoDataGridView.AutoGenerateColumns = false;
            this.EmprestimoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmprestimoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.EmprestimoDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.EmprestimoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmprestimoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOperaçãoDataGridViewTextBoxColumn,
            this.iDEmprestimoDataGridViewTextBoxColumn,
            this.númeroDeContaDataGridViewTextBoxColumn,
            this.valorDeEmprestimoDataGridViewTextBoxColumn,
            this.tipoEmprestimoDataGridViewTextBoxColumn,
            this.taxaDeJuroDataGridViewTextBoxColumn,
            this.nIFFuncionarioDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn});
            this.EmprestimoDataGridView.DataSource = this.emprestimoviewBindingSource;
            this.EmprestimoDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EmprestimoDataGridView.Location = new System.Drawing.Point(6, 179);
            this.EmprestimoDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmprestimoDataGridView.Name = "EmprestimoDataGridView";
            this.EmprestimoDataGridView.ReadOnly = true;
            this.EmprestimoDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.EmprestimoDataGridView.RowHeadersVisible = false;
            this.EmprestimoDataGridView.RowHeadersWidth = 20;
            this.EmprestimoDataGridView.RowTemplate.Height = 17;
            this.EmprestimoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmprestimoDataGridView.Size = new System.Drawing.Size(710, 108);
            this.EmprestimoDataGridView.TabIndex = 0;
            // 
            // iDOperaçãoDataGridViewTextBoxColumn
            // 
            this.iDOperaçãoDataGridViewTextBoxColumn.DataPropertyName = "ID Operação";
            this.iDOperaçãoDataGridViewTextBoxColumn.HeaderText = "ID Operação";
            this.iDOperaçãoDataGridViewTextBoxColumn.Name = "iDOperaçãoDataGridViewTextBoxColumn";
            this.iDOperaçãoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDEmprestimoDataGridViewTextBoxColumn
            // 
            this.iDEmprestimoDataGridViewTextBoxColumn.DataPropertyName = "ID Emprestimo";
            this.iDEmprestimoDataGridViewTextBoxColumn.HeaderText = "ID Emprestimo";
            this.iDEmprestimoDataGridViewTextBoxColumn.Name = "iDEmprestimoDataGridViewTextBoxColumn";
            this.iDEmprestimoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // númeroDeContaDataGridViewTextBoxColumn
            // 
            this.númeroDeContaDataGridViewTextBoxColumn.DataPropertyName = "Número de Conta";
            this.númeroDeContaDataGridViewTextBoxColumn.HeaderText = "Número de Conta";
            this.númeroDeContaDataGridViewTextBoxColumn.Name = "númeroDeContaDataGridViewTextBoxColumn";
            this.númeroDeContaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDeEmprestimoDataGridViewTextBoxColumn
            // 
            this.valorDeEmprestimoDataGridViewTextBoxColumn.DataPropertyName = "Valor de Emprestimo";
            this.valorDeEmprestimoDataGridViewTextBoxColumn.HeaderText = "Valor de Emprestimo";
            this.valorDeEmprestimoDataGridViewTextBoxColumn.Name = "valorDeEmprestimoDataGridViewTextBoxColumn";
            this.valorDeEmprestimoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoEmprestimoDataGridViewTextBoxColumn
            // 
            this.tipoEmprestimoDataGridViewTextBoxColumn.DataPropertyName = "Tipo Emprestimo";
            this.tipoEmprestimoDataGridViewTextBoxColumn.HeaderText = "Tipo Emprestimo";
            this.tipoEmprestimoDataGridViewTextBoxColumn.Name = "tipoEmprestimoDataGridViewTextBoxColumn";
            this.tipoEmprestimoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxaDeJuroDataGridViewTextBoxColumn
            // 
            this.taxaDeJuroDataGridViewTextBoxColumn.DataPropertyName = "Taxa de Juro";
            this.taxaDeJuroDataGridViewTextBoxColumn.HeaderText = "Taxa de Juro";
            this.taxaDeJuroDataGridViewTextBoxColumn.Name = "taxaDeJuroDataGridViewTextBoxColumn";
            this.taxaDeJuroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nIFFuncionarioDataGridViewTextBoxColumn
            // 
            this.nIFFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "NIF Funcionario";
            this.nIFFuncionarioDataGridViewTextBoxColumn.HeaderText = "NIF Funcionario";
            this.nIFFuncionarioDataGridViewTextBoxColumn.Name = "nIFFuncionarioDataGridViewTextBoxColumn";
            this.nIFFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emprestimoviewBindingSource
            // 
            this.emprestimoviewBindingSource.DataMember = "emprestimoview";
            this.emprestimoviewBindingSource.DataSource = this.zEmprestimo;
            // 
            // zEmprestimo
            // 
            this.zEmprestimo.DataSetName = "zEmprestimo";
            this.zEmprestimo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesviewidentificacaoBindingSource
            // 
            this.clientesviewidentificacaoBindingSource.DataMember = "clientesviewidentificacao";
            this.clientesviewidentificacaoBindingSource.DataSource = this.zCliente;
            // 
            // zCliente
            // 
            this.zCliente.DataSetName = "zCliente";
            this.zCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // balcaoviewBindingSource
            // 
            this.balcaoviewBindingSource.DataMember = "balcaoview";
            this.balcaoviewBindingSource.DataSource = this.zBalcao;
            // 
            // zBalcao
            // 
            this.zBalcao.DataSetName = "zBalcao";
            this.zBalcao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // balcaoviewTableAdapter
            // 
            this.balcaoviewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = SistBancario.zBalcaoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 78);
            this.label1.TabIndex = 2;
            this.label1.Text = "Empréstimos";
            // 
            // panelPesquisa
            // 
            this.panelPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPesquisa.Controls.Add(this.label7);
            this.panelPesquisa.Controls.Add(this.geral);
            this.panelPesquisa.Controls.Add(this.label6);
            this.panelPesquisa.Controls.Add(this.label5);
            this.panelPesquisa.Controls.Add(this.label4);
            this.panelPesquisa.Controls.Add(this.ID);
            this.panelPesquisa.Controls.Add(this.NConta);
            this.panelPesquisa.Controls.Add(this.IDOperacao);
            this.panelPesquisa.Location = new System.Drawing.Point(6, 304);
            this.panelPesquisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelPesquisa.Name = "panelPesquisa";
            this.panelPesquisa.Size = new System.Drawing.Size(710, 106);
            this.panelPesquisa.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(468, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pesquisa geral";
            // 
            // geral
            // 
            this.geral.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geral.Location = new System.Drawing.Point(435, 48);
            this.geral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.geral.Name = "geral";
            this.geral.Size = new System.Drawing.Size(180, 32);
            this.geral.TabIndex = 7;
            this.geral.TextChanged += new System.EventHandler(this.search);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID Empréstimo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "N. Conta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID Operação";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(107, 67);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 3;
            this.ID.TextChanged += new System.EventHandler(this.pesquisaColunas);
            // 
            // NConta
            // 
            this.NConta.Location = new System.Drawing.Point(107, 41);
            this.NConta.Name = "NConta";
            this.NConta.Size = new System.Drawing.Size(100, 20);
            this.NConta.TabIndex = 2;
            this.NConta.TextChanged += new System.EventHandler(this.pesquisaColunas);
            // 
            // IDOperacao
            // 
            this.IDOperacao.Location = new System.Drawing.Point(107, 15);
            this.IDOperacao.Name = "IDOperacao";
            this.IDOperacao.Size = new System.Drawing.Size(100, 20);
            this.IDOperacao.TabIndex = 1;
            this.IDOperacao.TextChanged += new System.EventHandler(this.pesquisaColunas);
            // 
            // panelCaixasTexto
            // 
            this.panelCaixasTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCaixasTexto.Controls.Add(iD_OperaçãoLabel);
            this.panelCaixasTexto.Controls.Add(this.iD_OperaçãoTextBox);
            this.panelCaixasTexto.Controls.Add(iD_EmprestimoLabel);
            this.panelCaixasTexto.Controls.Add(this.iD_EmprestimoTextBox);
            this.panelCaixasTexto.Controls.Add(número_de_ContaLabel);
            this.panelCaixasTexto.Controls.Add(this.número_de_ContaTextBox);
            this.panelCaixasTexto.Controls.Add(valor_de_EmprestimoLabel);
            this.panelCaixasTexto.Controls.Add(this.valor_de_EmprestimoTextBox);
            this.panelCaixasTexto.Controls.Add(tipo_EmprestimoLabel);
            this.panelCaixasTexto.Controls.Add(this.tipo_EmprestimoTextBox);
            this.panelCaixasTexto.Controls.Add(taxa_de_JuroLabel);
            this.panelCaixasTexto.Controls.Add(this.taxa_de_JuroTextBox);
            this.panelCaixasTexto.Controls.Add(nIF_FuncionarioLabel);
            this.panelCaixasTexto.Controls.Add(this.nIF_FuncionarioTextBox);
            this.panelCaixasTexto.Controls.Add(tipoLabel);
            this.panelCaixasTexto.Controls.Add(this.tipoTextBox);
            this.panelCaixasTexto.Controls.Add(dataLabel);
            this.panelCaixasTexto.Controls.Add(this.dataDateTimePicker);
            this.panelCaixasTexto.Controls.Add(horaLabel);
            this.panelCaixasTexto.Controls.Add(this.horaTextBox);
            this.panelCaixasTexto.Enabled = false;
            this.panelCaixasTexto.Location = new System.Drawing.Point(6, 426);
            this.panelCaixasTexto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCaixasTexto.Name = "panelCaixasTexto";
            this.panelCaixasTexto.Size = new System.Drawing.Size(710, 182);
            this.panelCaixasTexto.TabIndex = 4;
            // 
            // iD_OperaçãoTextBox
            // 
            this.iD_OperaçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emprestimoviewBindingSource, "ID Operação", true));
            this.iD_OperaçãoTextBox.Enabled = false;
            this.iD_OperaçãoTextBox.Location = new System.Drawing.Point(457, 27);
            this.iD_OperaçãoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iD_OperaçãoTextBox.Name = "iD_OperaçãoTextBox";
            this.iD_OperaçãoTextBox.Size = new System.Drawing.Size(152, 20);
            this.iD_OperaçãoTextBox.TabIndex = 1;
            // 
            // iD_EmprestimoTextBox
            // 
            this.iD_EmprestimoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emprestimoviewBindingSource, "ID Emprestimo", true));
            this.iD_EmprestimoTextBox.Enabled = false;
            this.iD_EmprestimoTextBox.Location = new System.Drawing.Point(457, 54);
            this.iD_EmprestimoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iD_EmprestimoTextBox.Name = "iD_EmprestimoTextBox";
            this.iD_EmprestimoTextBox.Size = new System.Drawing.Size(152, 20);
            this.iD_EmprestimoTextBox.TabIndex = 3;
            this.iD_EmprestimoTextBox.TextChanged += new System.EventHandler(this.iD_EmprestimoTextBox_TextChanged);
            // 
            // número_de_ContaTextBox
            // 
            this.número_de_ContaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emprestimoviewBindingSource, "Número de Conta", true));
            this.número_de_ContaTextBox.Location = new System.Drawing.Point(457, 79);
            this.número_de_ContaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.número_de_ContaTextBox.Name = "número_de_ContaTextBox";
            this.número_de_ContaTextBox.Size = new System.Drawing.Size(152, 20);
            this.número_de_ContaTextBox.TabIndex = 5;
            // 
            // valor_de_EmprestimoTextBox
            // 
            this.valor_de_EmprestimoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emprestimoviewBindingSource, "Valor de Emprestimo", true));
            this.valor_de_EmprestimoTextBox.Location = new System.Drawing.Point(168, 27);
            this.valor_de_EmprestimoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.valor_de_EmprestimoTextBox.Name = "valor_de_EmprestimoTextBox";
            this.valor_de_EmprestimoTextBox.Size = new System.Drawing.Size(152, 20);
            this.valor_de_EmprestimoTextBox.TabIndex = 7;
            // 
            // tipo_EmprestimoTextBox
            // 
            this.tipo_EmprestimoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emprestimoviewBindingSource, "Tipo Emprestimo", true));
            this.tipo_EmprestimoTextBox.Location = new System.Drawing.Point(168, 57);
            this.tipo_EmprestimoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tipo_EmprestimoTextBox.Name = "tipo_EmprestimoTextBox";
            this.tipo_EmprestimoTextBox.Size = new System.Drawing.Size(152, 20);
            this.tipo_EmprestimoTextBox.TabIndex = 9;
            // 
            // taxa_de_JuroTextBox
            // 
            this.taxa_de_JuroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emprestimoviewBindingSource, "Taxa de Juro", true));
            this.taxa_de_JuroTextBox.Location = new System.Drawing.Point(168, 83);
            this.taxa_de_JuroTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.taxa_de_JuroTextBox.Name = "taxa_de_JuroTextBox";
            this.taxa_de_JuroTextBox.Size = new System.Drawing.Size(152, 20);
            this.taxa_de_JuroTextBox.TabIndex = 11;
            // 
            // nIF_FuncionarioTextBox
            // 
            this.nIF_FuncionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emprestimoviewBindingSource, "NIF Funcionario", true));
            this.nIF_FuncionarioTextBox.Location = new System.Drawing.Point(457, 114);
            this.nIF_FuncionarioTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nIF_FuncionarioTextBox.Name = "nIF_FuncionarioTextBox";
            this.nIF_FuncionarioTextBox.Size = new System.Drawing.Size(152, 20);
            this.nIF_FuncionarioTextBox.TabIndex = 13;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emprestimoviewBindingSource, "Tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(168, 0);
            this.tipoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(152, 20);
            this.tipoTextBox.TabIndex = 15;
            this.tipoTextBox.Visible = false;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.emprestimoviewBindingSource, "Data", true));
            this.dataDateTimePicker.Enabled = false;
            this.dataDateTimePicker.Location = new System.Drawing.Point(168, 114);
            this.dataDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(152, 20);
            this.dataDateTimePicker.TabIndex = 17;
            // 
            // horaTextBox
            // 
            this.horaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emprestimoviewBindingSource, "Hora", true));
            this.horaTextBox.Enabled = false;
            this.horaTextBox.Location = new System.Drawing.Point(168, 148);
            this.horaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.horaTextBox.Name = "horaTextBox";
            this.horaTextBox.Size = new System.Drawing.Size(152, 20);
            this.horaTextBox.TabIndex = 19;
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.butCancelar);
            this.panelBotoes.Controls.Add(this.butEliminar);
            this.panelBotoes.Controls.Add(this.butInserir);
            this.panelBotoes.Location = new System.Drawing.Point(6, 612);
            this.panelBotoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(710, 66);
            this.panelBotoes.TabIndex = 5;
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(242, 2);
            this.butCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(226, 42);
            this.butCancelar.TabIndex = 14;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(470, 2);
            this.butEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(226, 42);
            this.butEliminar.TabIndex = 2;
            this.butEliminar.Text = "Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // butInserir
            // 
            this.butInserir.Location = new System.Drawing.Point(14, 2);
            this.butInserir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butInserir.Name = "butInserir";
            this.butInserir.Size = new System.Drawing.Size(226, 42);
            this.butInserir.TabIndex = 0;
            this.butInserir.Text = "Inserir";
            this.butInserir.UseVisualStyleBackColor = true;
            this.butInserir.Click += new System.EventHandler(this.Inserir_Click);
            // 
            // butMenuInicial
            // 
            this.butMenuInicial.Image = ((System.Drawing.Image)(resources.GetObject("butMenuInicial.Image")));
            this.butMenuInicial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butMenuInicial.Location = new System.Drawing.Point(614, 6);
            this.butMenuInicial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butMenuInicial.Name = "butMenuInicial";
            this.butMenuInicial.Size = new System.Drawing.Size(100, 58);
            this.butMenuInicial.TabIndex = 6;
            this.butMenuInicial.Text = "Menu Inicial";
            this.butMenuInicial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butMenuInicial.UseVisualStyleBackColor = true;
            this.butMenuInicial.Click += new System.EventHandler(this.butMenuInicial_Click);
            // 
            // lblAjuda
            // 
            this.lblAjuda.AutoSize = true;
            this.lblAjuda.Location = new System.Drawing.Point(6, 164);
            this.lblAjuda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(149, 13);
            this.lblAjuda.TabIndex = 7;
            this.lblAjuda.Text = "Selecione uma linha da grelha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pesquisa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 418);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Info da grelha/Modo de edição";
            // 
            // clientesviewidentificacaoTableAdapter
            // 
            this.clientesviewidentificacaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = SistBancario.zClienteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // emprestimoviewTableAdapter
            // 
            this.emprestimoviewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.UpdateOrder = SistBancario.zEmprestimoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(683, 373);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAjuda);
            this.Controls.Add(this.butMenuInicial);
            this.Controls.Add(this.panelBotoes);
            this.Controls.Add(this.panelCaixasTexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EmprestimoDataGridView);
            this.Controls.Add(this.panelPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "emprestimo";
            this.Text = "Sistema Bancário - Balcão";
            this.Load += new System.EventHandler(this.emprestimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmprestimoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimoviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEmprestimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesviewidentificacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balcaoviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zBalcao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPesquisa.ResumeLayout(false);
            this.panelPesquisa.PerformLayout();
            this.panelCaixasTexto.ResumeLayout(false);
            this.panelCaixasTexto.PerformLayout();
            this.panelBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmprestimoDataGridView;
        private zBalcao zBalcao;
        private System.Windows.Forms.BindingSource balcaoviewBindingSource;
        private zBalcaoTableAdapters.balcaoviewTableAdapter balcaoviewTableAdapter;
        private zBalcaoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPesquisa;
        private System.Windows.Forms.Panel panelCaixasTexto;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Button butEliminar;
        private System.Windows.Forms.Button butInserir;
        private System.Windows.Forms.Button butMenuInicial;
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox NConta;
        private System.Windows.Forms.TextBox IDOperacao;
        private System.Windows.Forms.TextBox geral;
        private System.Windows.Forms.Label label7;
        private zCliente zCliente;
        private System.Windows.Forms.BindingSource clientesviewidentificacaoBindingSource;
        private zClienteTableAdapters.clientesviewidentificacaoTableAdapter clientesviewidentificacaoTableAdapter;
        private zClienteTableAdapters.TableAdapterManager tableAdapterManager1;
        private zEmprestimo zEmprestimo;
        private System.Windows.Forms.BindingSource emprestimoviewBindingSource;
        private zEmprestimoTableAdapters.emprestimoviewTableAdapter emprestimoviewTableAdapter;
        private System.Windows.Forms.TextBox iD_OperaçãoTextBox;
        private System.Windows.Forms.TextBox iD_EmprestimoTextBox;
        private System.Windows.Forms.TextBox número_de_ContaTextBox;
        private System.Windows.Forms.TextBox valor_de_EmprestimoTextBox;
        private System.Windows.Forms.TextBox tipo_EmprestimoTextBox;
        private System.Windows.Forms.TextBox taxa_de_JuroTextBox;
        private System.Windows.Forms.TextBox nIF_FuncionarioTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox horaTextBox;
        private zEmprestimoTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOperaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEmprestimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn númeroDeContaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDeEmprestimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEmprestimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxaDeJuroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
    }
}