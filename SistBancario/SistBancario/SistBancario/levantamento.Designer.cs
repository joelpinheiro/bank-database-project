namespace SistBancario
{
    partial class levantamento
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
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label nIF_FuncionarioLabel;
            System.Windows.Forms.Label número_de_ContaLabel;
            System.Windows.Forms.Label montante_LevantadoLabel;
            System.Windows.Forms.Label iD_LevantamentoLabel;
            System.Windows.Forms.Label iD_OperaçãoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(levantamento));
            this.LevantamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.iDOperaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLevantamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montanteLevantadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.númeroDeContaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levantamentosviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zLevantamento = new SistBancario.zLevantamento();
            this.depositoviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zDeposito = new SistBancario.zDeposito();
            this.transferenciaviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zTransferencia = new SistBancario.zTransferencia();
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.NConta = new System.Windows.Forms.TextBox();
            this.IDOperacao = new System.Windows.Forms.TextBox();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.Cancelar = new System.Windows.Forms.Button();
            this.butEliminar = new System.Windows.Forms.Button();
            this.butInserir = new System.Windows.Forms.Button();
            this.butMenuInicial = new System.Windows.Forms.Button();
            this.lblAjuda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientesviewidentificacaoTableAdapter = new SistBancario.zClienteTableAdapters.clientesviewidentificacaoTableAdapter();
            this.tableAdapterManager1 = new SistBancario.zClienteTableAdapters.TableAdapterManager();
            this.emprestimoviewTableAdapter = new SistBancario.zEmprestimoTableAdapters.emprestimoviewTableAdapter();
            this.tableAdapterManager2 = new SistBancario.zEmprestimoTableAdapters.TableAdapterManager();
            this.transferenciaviewTableAdapter = new SistBancario.zTransferenciaTableAdapters.transferenciaviewTableAdapter();
            this.tableAdapterManager3 = new SistBancario.zTransferenciaTableAdapters.TableAdapterManager();
            this.depositoviewTableAdapter = new SistBancario.zDepositoTableAdapters.depositoviewTableAdapter();
            this.tableAdapterManager4 = new SistBancario.zDepositoTableAdapters.TableAdapterManager();
            this.levantamentosviewTableAdapter = new SistBancario.zLevantamentoTableAdapters.levantamentosviewTableAdapter();
            this.tableAdapterManager5 = new SistBancario.zLevantamentoTableAdapters.TableAdapterManager();
            this.horaTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.nIF_FuncionarioTextBox = new System.Windows.Forms.TextBox();
            this.número_de_ContaTextBox = new System.Windows.Forms.TextBox();
            this.montante_LevantadoTextBox = new System.Windows.Forms.TextBox();
            this.iD_LevantamentoTextBox = new System.Windows.Forms.TextBox();
            this.iD_OperaçãoTextBox = new System.Windows.Forms.TextBox();
            this.geral = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelCaixasTexto = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            nIF_FuncionarioLabel = new System.Windows.Forms.Label();
            número_de_ContaLabel = new System.Windows.Forms.Label();
            montante_LevantadoLabel = new System.Windows.Forms.Label();
            iD_LevantamentoLabel = new System.Windows.Forms.Label();
            iD_OperaçãoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LevantamentoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levantamentosviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zLevantamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositoviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zDeposito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferenciaviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zTransferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimoviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEmprestimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesviewidentificacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balcaoviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zBalcao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPesquisa.SuspendLayout();
            this.panelBotoes.SuspendLayout();
            this.panelCaixasTexto.SuspendLayout();
            this.SuspendLayout();
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(5, 152);
            horaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(33, 13);
            horaLabel.TabIndex = 14;
            horaLabel.Text = "Hora:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(5, 127);
            dataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 12;
            dataLabel.Text = "Data:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(482, 11);
            tipoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 10;
            tipoLabel.Text = "Tipo:";
            tipoLabel.Visible = false;
            tipoLabel.Click += new System.EventHandler(this.tipoLabel_Click);
            // 
            // nIF_FuncionarioLabel
            // 
            nIF_FuncionarioLabel.AutoSize = true;
            nIF_FuncionarioLabel.Location = new System.Drawing.Point(5, 100);
            nIF_FuncionarioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nIF_FuncionarioLabel.Name = "nIF_FuncionarioLabel";
            nIF_FuncionarioLabel.Size = new System.Drawing.Size(85, 13);
            nIF_FuncionarioLabel.TabIndex = 8;
            nIF_FuncionarioLabel.Text = "NIF Funcionario:";
            nIF_FuncionarioLabel.Click += new System.EventHandler(this.nIF_FuncionarioLabel_Click);
            // 
            // número_de_ContaLabel
            // 
            número_de_ContaLabel.AutoSize = true;
            número_de_ContaLabel.Location = new System.Drawing.Point(3, 71);
            número_de_ContaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            número_de_ContaLabel.Name = "número_de_ContaLabel";
            número_de_ContaLabel.Size = new System.Drawing.Size(93, 13);
            número_de_ContaLabel.TabIndex = 6;
            número_de_ContaLabel.Text = "Número de Conta:";
            // 
            // montante_LevantadoLabel
            // 
            montante_LevantadoLabel.AutoSize = true;
            montante_LevantadoLabel.Location = new System.Drawing.Point(247, 68);
            montante_LevantadoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            montante_LevantadoLabel.Name = "montante_LevantadoLabel";
            montante_LevantadoLabel.Size = new System.Drawing.Size(109, 13);
            montante_LevantadoLabel.TabIndex = 4;
            montante_LevantadoLabel.Text = "Montante Levantado:";
            // 
            // iD_LevantamentoLabel
            // 
            iD_LevantamentoLabel.AutoSize = true;
            iD_LevantamentoLabel.Enabled = false;
            iD_LevantamentoLabel.Location = new System.Drawing.Point(247, 34);
            iD_LevantamentoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            iD_LevantamentoLabel.Name = "iD_LevantamentoLabel";
            iD_LevantamentoLabel.Size = new System.Drawing.Size(92, 13);
            iD_LevantamentoLabel.TabIndex = 2;
            iD_LevantamentoLabel.Text = "ID Levantamento:";
            // 
            // iD_OperaçãoLabel
            // 
            iD_OperaçãoLabel.AutoSize = true;
            iD_OperaçãoLabel.Enabled = false;
            iD_OperaçãoLabel.Location = new System.Drawing.Point(5, 37);
            iD_OperaçãoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            iD_OperaçãoLabel.Name = "iD_OperaçãoLabel";
            iD_OperaçãoLabel.Size = new System.Drawing.Size(71, 13);
            iD_OperaçãoLabel.TabIndex = 0;
            iD_OperaçãoLabel.Text = "ID Operação:";
            // 
            // LevantamentoDataGridView
            // 
            this.LevantamentoDataGridView.AllowUserToAddRows = false;
            this.LevantamentoDataGridView.AllowUserToDeleteRows = false;
            this.LevantamentoDataGridView.AllowUserToResizeRows = false;
            this.LevantamentoDataGridView.AutoGenerateColumns = false;
            this.LevantamentoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LevantamentoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LevantamentoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.LevantamentoDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.LevantamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LevantamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOperaçãoDataGridViewTextBoxColumn,
            this.iDLevantamentoDataGridViewTextBoxColumn,
            this.montanteLevantadoDataGridViewTextBoxColumn,
            this.númeroDeContaDataGridViewTextBoxColumn,
            this.nIFFuncionarioDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn});
            this.LevantamentoDataGridView.DataSource = this.levantamentosviewBindingSource;
            this.LevantamentoDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.LevantamentoDataGridView.Location = new System.Drawing.Point(6, 179);
            this.LevantamentoDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.LevantamentoDataGridView.Name = "LevantamentoDataGridView";
            this.LevantamentoDataGridView.ReadOnly = true;
            this.LevantamentoDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.LevantamentoDataGridView.RowHeadersVisible = false;
            this.LevantamentoDataGridView.RowHeadersWidth = 20;
            this.LevantamentoDataGridView.RowTemplate.Height = 17;
            this.LevantamentoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LevantamentoDataGridView.Size = new System.Drawing.Size(710, 108);
            this.LevantamentoDataGridView.TabIndex = 0;
            // 
            // iDOperaçãoDataGridViewTextBoxColumn
            // 
            this.iDOperaçãoDataGridViewTextBoxColumn.DataPropertyName = "ID Operação";
            this.iDOperaçãoDataGridViewTextBoxColumn.HeaderText = "ID Operação";
            this.iDOperaçãoDataGridViewTextBoxColumn.Name = "iDOperaçãoDataGridViewTextBoxColumn";
            this.iDOperaçãoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDLevantamentoDataGridViewTextBoxColumn
            // 
            this.iDLevantamentoDataGridViewTextBoxColumn.DataPropertyName = "ID Levantamento";
            this.iDLevantamentoDataGridViewTextBoxColumn.HeaderText = "ID Levantamento";
            this.iDLevantamentoDataGridViewTextBoxColumn.Name = "iDLevantamentoDataGridViewTextBoxColumn";
            this.iDLevantamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montanteLevantadoDataGridViewTextBoxColumn
            // 
            this.montanteLevantadoDataGridViewTextBoxColumn.DataPropertyName = "Montante Levantado";
            this.montanteLevantadoDataGridViewTextBoxColumn.HeaderText = "Montante Levantado";
            this.montanteLevantadoDataGridViewTextBoxColumn.Name = "montanteLevantadoDataGridViewTextBoxColumn";
            this.montanteLevantadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // númeroDeContaDataGridViewTextBoxColumn
            // 
            this.númeroDeContaDataGridViewTextBoxColumn.DataPropertyName = "Número de Conta";
            this.númeroDeContaDataGridViewTextBoxColumn.HeaderText = "Número de Conta";
            this.númeroDeContaDataGridViewTextBoxColumn.Name = "númeroDeContaDataGridViewTextBoxColumn";
            this.númeroDeContaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // levantamentosviewBindingSource
            // 
            this.levantamentosviewBindingSource.DataMember = "levantamentosview";
            this.levantamentosviewBindingSource.DataSource = this.zLevantamento;
            // 
            // zLevantamento
            // 
            this.zLevantamento.DataSetName = "zLevantamento";
            this.zLevantamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depositoviewBindingSource
            // 
            this.depositoviewBindingSource.DataMember = "depositoview";
            this.depositoviewBindingSource.DataSource = this.zDeposito;
            // 
            // zDeposito
            // 
            this.zDeposito.DataSetName = "zDeposito";
            this.zDeposito.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transferenciaviewBindingSource
            // 
            this.transferenciaviewBindingSource.DataMember = "transferenciaview";
            this.transferenciaviewBindingSource.DataSource = this.zTransferencia;
            // 
            // zTransferencia
            // 
            this.zTransferencia.DataSetName = "zTransferencia";
            this.zTransferencia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
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
            this.label1.Size = new System.Drawing.Size(421, 78);
            this.label1.TabIndex = 2;
            this.label1.Text = "Levantamento";
            // 
            // panelPesquisa
            // 
            this.panelPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPesquisa.Controls.Add(this.label6);
            this.panelPesquisa.Controls.Add(this.label5);
            this.panelPesquisa.Controls.Add(this.label4);
            this.panelPesquisa.Controls.Add(this.ID);
            this.panelPesquisa.Controls.Add(this.NConta);
            this.panelPesquisa.Controls.Add(this.IDOperacao);
            this.panelPesquisa.Location = new System.Drawing.Point(6, 304);
            this.panelPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.panelPesquisa.Name = "panelPesquisa";
            this.panelPesquisa.Size = new System.Drawing.Size(710, 106);
            this.panelPesquisa.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID Levantamento";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 22);
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
            this.ID.Location = new System.Drawing.Point(556, 15);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 3;
            this.ID.TextChanged += new System.EventHandler(this.pesquisaColunas);
            // 
            // NConta
            // 
            this.NConta.Location = new System.Drawing.Point(314, 15);
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
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.Cancelar);
            this.panelBotoes.Controls.Add(this.butEliminar);
            this.panelBotoes.Controls.Add(this.butInserir);
            this.panelBotoes.Location = new System.Drawing.Point(6, 612);
            this.panelBotoes.Margin = new System.Windows.Forms.Padding(2);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(710, 66);
            this.panelBotoes.TabIndex = 5;
            // 
            // Cancelar
            // 
            this.Cancelar.Enabled = false;
            this.Cancelar.Location = new System.Drawing.Point(242, 2);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(226, 42);
            this.Cancelar.TabIndex = 15;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(470, 2);
            this.butEliminar.Margin = new System.Windows.Forms.Padding(2);
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
            this.butInserir.Margin = new System.Windows.Forms.Padding(2);
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
            this.butMenuInicial.Margin = new System.Windows.Forms.Padding(2);
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
            // transferenciaviewTableAdapter
            // 
            this.transferenciaviewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.Connection = null;
            this.tableAdapterManager3.UpdateOrder = SistBancario.zTransferenciaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // depositoviewTableAdapter
            // 
            this.depositoviewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager4
            // 
            this.tableAdapterManager4.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager4.Connection = null;
            this.tableAdapterManager4.UpdateOrder = SistBancario.zDepositoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // levantamentosviewTableAdapter
            // 
            this.levantamentosviewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager5
            // 
            this.tableAdapterManager5.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager5.Connection = null;
            this.tableAdapterManager5.UpdateOrder = SistBancario.zLevantamentoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // horaTextBox
            // 
            this.horaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.levantamentosviewBindingSource, "Hora", true));
            this.horaTextBox.Enabled = false;
            this.horaTextBox.Location = new System.Drawing.Point(94, 145);
            this.horaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.horaTextBox.Name = "horaTextBox";
            this.horaTextBox.Size = new System.Drawing.Size(102, 20);
            this.horaTextBox.TabIndex = 15;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.levantamentosviewBindingSource, "Data", true));
            this.dataDateTimePicker.Enabled = false;
            this.dataDateTimePicker.Location = new System.Drawing.Point(94, 121);
            this.dataDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(102, 20);
            this.dataDateTimePicker.TabIndex = 13;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.levantamentosviewBindingSource, "Tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(539, 10);
            this.tipoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(102, 20);
            this.tipoTextBox.TabIndex = 11;
            this.tipoTextBox.Visible = false;
            // 
            // nIF_FuncionarioTextBox
            // 
            this.nIF_FuncionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.levantamentosviewBindingSource, "NIF Funcionario", true));
            this.nIF_FuncionarioTextBox.Location = new System.Drawing.Point(94, 97);
            this.nIF_FuncionarioTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nIF_FuncionarioTextBox.Name = "nIF_FuncionarioTextBox";
            this.nIF_FuncionarioTextBox.Size = new System.Drawing.Size(102, 20);
            this.nIF_FuncionarioTextBox.TabIndex = 9;
            this.nIF_FuncionarioTextBox.TextChanged += new System.EventHandler(this.nIF_FuncionarioTextBox_TextChanged);
            // 
            // número_de_ContaTextBox
            // 
            this.número_de_ContaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.levantamentosviewBindingSource, "Número de Conta", true));
            this.número_de_ContaTextBox.Location = new System.Drawing.Point(94, 68);
            this.número_de_ContaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.número_de_ContaTextBox.Name = "número_de_ContaTextBox";
            this.número_de_ContaTextBox.Size = new System.Drawing.Size(102, 20);
            this.número_de_ContaTextBox.TabIndex = 7;
            // 
            // montante_LevantadoTextBox
            // 
            this.montante_LevantadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.levantamentosviewBindingSource, "Montante Levantado", true));
            this.montante_LevantadoTextBox.Location = new System.Drawing.Point(364, 65);
            this.montante_LevantadoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.montante_LevantadoTextBox.Name = "montante_LevantadoTextBox";
            this.montante_LevantadoTextBox.Size = new System.Drawing.Size(102, 20);
            this.montante_LevantadoTextBox.TabIndex = 5;
            // 
            // iD_LevantamentoTextBox
            // 
            this.iD_LevantamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.levantamentosviewBindingSource, "ID Levantamento", true));
            this.iD_LevantamentoTextBox.Enabled = false;
            this.iD_LevantamentoTextBox.Location = new System.Drawing.Point(364, 34);
            this.iD_LevantamentoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.iD_LevantamentoTextBox.Name = "iD_LevantamentoTextBox";
            this.iD_LevantamentoTextBox.Size = new System.Drawing.Size(102, 20);
            this.iD_LevantamentoTextBox.TabIndex = 3;
            // 
            // iD_OperaçãoTextBox
            // 
            this.iD_OperaçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.levantamentosviewBindingSource, "ID Operação", true));
            this.iD_OperaçãoTextBox.Enabled = false;
            this.iD_OperaçãoTextBox.Location = new System.Drawing.Point(94, 34);
            this.iD_OperaçãoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.iD_OperaçãoTextBox.Name = "iD_OperaçãoTextBox";
            this.iD_OperaçãoTextBox.Size = new System.Drawing.Size(102, 20);
            this.iD_OperaçãoTextBox.TabIndex = 1;
            // 
            // geral
            // 
            this.geral.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geral.Location = new System.Drawing.Point(539, 260);
            this.geral.Margin = new System.Windows.Forms.Padding(2);
            this.geral.Name = "geral";
            this.geral.Size = new System.Drawing.Size(180, 32);
            this.geral.TabIndex = 7;
            this.geral.Visible = false;
            this.geral.TextChanged += new System.EventHandler(this.search);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(572, 229);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pesquisa geral";
            this.label7.Visible = false;
            // 
            // panelCaixasTexto
            // 
            this.panelCaixasTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCaixasTexto.Controls.Add(this.label7);
            this.panelCaixasTexto.Controls.Add(iD_OperaçãoLabel);
            this.panelCaixasTexto.Controls.Add(this.geral);
            this.panelCaixasTexto.Controls.Add(this.iD_OperaçãoTextBox);
            this.panelCaixasTexto.Controls.Add(iD_LevantamentoLabel);
            this.panelCaixasTexto.Controls.Add(this.iD_LevantamentoTextBox);
            this.panelCaixasTexto.Controls.Add(montante_LevantadoLabel);
            this.panelCaixasTexto.Controls.Add(this.montante_LevantadoTextBox);
            this.panelCaixasTexto.Controls.Add(número_de_ContaLabel);
            this.panelCaixasTexto.Controls.Add(this.número_de_ContaTextBox);
            this.panelCaixasTexto.Controls.Add(nIF_FuncionarioLabel);
            this.panelCaixasTexto.Controls.Add(this.nIF_FuncionarioTextBox);
            this.panelCaixasTexto.Controls.Add(tipoLabel);
            this.panelCaixasTexto.Controls.Add(this.tipoTextBox);
            this.panelCaixasTexto.Controls.Add(dataLabel);
            this.panelCaixasTexto.Controls.Add(this.dataDateTimePicker);
            this.panelCaixasTexto.Controls.Add(horaLabel);
            this.panelCaixasTexto.Controls.Add(this.horaTextBox);
            this.panelCaixasTexto.Enabled = false;
            this.panelCaixasTexto.Location = new System.Drawing.Point(7, 426);
            this.panelCaixasTexto.Margin = new System.Windows.Forms.Padding(2);
            this.panelCaixasTexto.Name = "panelCaixasTexto";
            this.panelCaixasTexto.Size = new System.Drawing.Size(710, 292);
            this.panelCaixasTexto.TabIndex = 4;
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
            // levantamento
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
            this.Controls.Add(this.LevantamentoDataGridView);
            this.Controls.Add(this.panelPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "levantamento";
            this.Text = "Sistema Bancário - Balcão";
            this.Load += new System.EventHandler(this.levantamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LevantamentoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levantamentosviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zLevantamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositoviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zDeposito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferenciaviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zTransferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimoviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEmprestimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesviewidentificacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balcaoviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zBalcao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPesquisa.ResumeLayout(false);
            this.panelPesquisa.PerformLayout();
            this.panelBotoes.ResumeLayout(false);
            this.panelCaixasTexto.ResumeLayout(false);
            this.panelCaixasTexto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LevantamentoDataGridView;
        private zBalcao zBalcao;
        private System.Windows.Forms.BindingSource balcaoviewBindingSource;
        private zBalcaoTableAdapters.balcaoviewTableAdapter balcaoviewTableAdapter;
        private zBalcaoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPesquisa;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Button butEliminar;
        private System.Windows.Forms.Button butInserir;
        private System.Windows.Forms.Button butMenuInicial;
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox NConta;
        private System.Windows.Forms.TextBox IDOperacao;
        private zCliente zCliente;
        private System.Windows.Forms.BindingSource clientesviewidentificacaoBindingSource;
        private zClienteTableAdapters.clientesviewidentificacaoTableAdapter clientesviewidentificacaoTableAdapter;
        private zClienteTableAdapters.TableAdapterManager tableAdapterManager1;
        private zEmprestimo zEmprestimo;
        private System.Windows.Forms.BindingSource emprestimoviewBindingSource;
        private zEmprestimoTableAdapters.emprestimoviewTableAdapter emprestimoviewTableAdapter;
        private zEmprestimoTableAdapters.TableAdapterManager tableAdapterManager2;
        private zTransferencia zTransferencia;
        private System.Windows.Forms.BindingSource transferenciaviewBindingSource;
        private zTransferenciaTableAdapters.transferenciaviewTableAdapter transferenciaviewTableAdapter;
        private zTransferenciaTableAdapters.TableAdapterManager tableAdapterManager3;
        private System.Windows.Forms.Button Cancelar;
        private zDeposito zDeposito;
        private System.Windows.Forms.BindingSource depositoviewBindingSource;
        private zDepositoTableAdapters.depositoviewTableAdapter depositoviewTableAdapter;
        private zDepositoTableAdapters.TableAdapterManager tableAdapterManager4;
        private zLevantamento zLevantamento;
        private System.Windows.Forms.BindingSource levantamentosviewBindingSource;
        private zLevantamentoTableAdapters.levantamentosviewTableAdapter levantamentosviewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOperaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLevantamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montanteLevantadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn númeroDeContaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private zLevantamentoTableAdapters.TableAdapterManager tableAdapterManager5;
        private System.Windows.Forms.TextBox horaTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.TextBox nIF_FuncionarioTextBox;
        private System.Windows.Forms.TextBox número_de_ContaTextBox;
        private System.Windows.Forms.TextBox montante_LevantadoTextBox;
        private System.Windows.Forms.TextBox iD_LevantamentoTextBox;
        private System.Windows.Forms.TextBox iD_OperaçãoTextBox;
        private System.Windows.Forms.TextBox geral;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelCaixasTexto;
        private System.Windows.Forms.Label label3;
    }
}