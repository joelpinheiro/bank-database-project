namespace SistBancario
{
    partial class operacao
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label nIF_ClienteLabel;
            System.Windows.Forms.Label número_ContaLabel;
            System.Windows.Forms.Label nIF_FuncionarioLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label horaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(operacao));
            this.OperacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.iDOperaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.númeroContaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacaoviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zOperacao = new SistBancario.zOperacao();
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
            this.NConta = new System.Windows.Forms.TextBox();
            this.Tipotxt = new System.Windows.Forms.TextBox();
            this.IDOperacao = new System.Windows.Forms.TextBox();
            this.panelCaixasTexto = new System.Windows.Forms.Panel();
            this.iD_OperaçãoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nIF_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.número_ContaTextBox = new System.Windows.Forms.TextBox();
            this.nIF_FuncionarioTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaTextBox = new System.Windows.Forms.TextBox();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.butLevantamento = new System.Windows.Forms.Button();
            this.butEmprestimo = new System.Windows.Forms.Button();
            this.butDeposito = new System.Windows.Forms.Button();
            this.buTransferencia = new System.Windows.Forms.Button();
            this.butMenuInicial = new System.Windows.Forms.Button();
            this.lblAjuda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.operacaoviewTableAdapter = new SistBancario.zOperacaoTableAdapters.operacaoviewTableAdapter();
            this.tableAdapterManager1 = new SistBancario.zOperacaoTableAdapters.TableAdapterManager();
            iD_OperaçãoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            nIF_ClienteLabel = new System.Windows.Forms.Label();
            número_ContaLabel = new System.Windows.Forms.Label();
            nIF_FuncionarioLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OperacaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacaoviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zOperacao)).BeginInit();
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
            iD_OperaçãoLabel.Location = new System.Drawing.Point(6, 17);
            iD_OperaçãoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            iD_OperaçãoLabel.Name = "iD_OperaçãoLabel";
            iD_OperaçãoLabel.Size = new System.Drawing.Size(71, 13);
            iD_OperaçãoLabel.TabIndex = 0;
            iD_OperaçãoLabel.Text = "ID Operação:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(12, 39);
            nomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // nIF_ClienteLabel
            // 
            nIF_ClienteLabel.AutoSize = true;
            nIF_ClienteLabel.Location = new System.Drawing.Point(12, 72);
            nIF_ClienteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nIF_ClienteLabel.Name = "nIF_ClienteLabel";
            nIF_ClienteLabel.Size = new System.Drawing.Size(62, 13);
            nIF_ClienteLabel.TabIndex = 4;
            nIF_ClienteLabel.Text = "NIF Cliente:";
            // 
            // número_ContaLabel
            // 
            número_ContaLabel.AutoSize = true;
            número_ContaLabel.Location = new System.Drawing.Point(12, 97);
            número_ContaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            número_ContaLabel.Name = "número_ContaLabel";
            número_ContaLabel.Size = new System.Drawing.Size(78, 13);
            número_ContaLabel.TabIndex = 6;
            número_ContaLabel.Text = "Número Conta:";
            // 
            // nIF_FuncionarioLabel
            // 
            nIF_FuncionarioLabel.AutoSize = true;
            nIF_FuncionarioLabel.Location = new System.Drawing.Point(368, 97);
            nIF_FuncionarioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nIF_FuncionarioLabel.Name = "nIF_FuncionarioLabel";
            nIF_FuncionarioLabel.Size = new System.Drawing.Size(85, 13);
            nIF_FuncionarioLabel.TabIndex = 8;
            nIF_FuncionarioLabel.Text = "NIF Funcionario:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(368, 72);
            tipoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 10;
            tipoLabel.Text = "Tipo:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(368, 39);
            dataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 12;
            dataLabel.Text = "Data:";
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(368, 16);
            horaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(33, 13);
            horaLabel.TabIndex = 14;
            horaLabel.Text = "Hora:";
            // 
            // OperacaoDataGridView
            // 
            this.OperacaoDataGridView.AllowUserToAddRows = false;
            this.OperacaoDataGridView.AllowUserToDeleteRows = false;
            this.OperacaoDataGridView.AllowUserToResizeRows = false;
            this.OperacaoDataGridView.AutoGenerateColumns = false;
            this.OperacaoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OperacaoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.OperacaoDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.OperacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OperacaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOperaçãoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.nIFClienteDataGridViewTextBoxColumn,
            this.númeroContaDataGridViewTextBoxColumn,
            this.nIFFuncionarioDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn});
            this.OperacaoDataGridView.DataSource = this.operacaoviewBindingSource;
            this.OperacaoDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.OperacaoDataGridView.Location = new System.Drawing.Point(6, 179);
            this.OperacaoDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OperacaoDataGridView.Name = "OperacaoDataGridView";
            this.OperacaoDataGridView.ReadOnly = true;
            this.OperacaoDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.OperacaoDataGridView.RowHeadersVisible = false;
            this.OperacaoDataGridView.RowHeadersWidth = 20;
            this.OperacaoDataGridView.RowTemplate.Height = 17;
            this.OperacaoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OperacaoDataGridView.Size = new System.Drawing.Size(710, 108);
            this.OperacaoDataGridView.TabIndex = 0;
            // 
            // iDOperaçãoDataGridViewTextBoxColumn
            // 
            this.iDOperaçãoDataGridViewTextBoxColumn.DataPropertyName = "ID Operação";
            this.iDOperaçãoDataGridViewTextBoxColumn.HeaderText = "ID Operação";
            this.iDOperaçãoDataGridViewTextBoxColumn.Name = "iDOperaçãoDataGridViewTextBoxColumn";
            this.iDOperaçãoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nIFClienteDataGridViewTextBoxColumn
            // 
            this.nIFClienteDataGridViewTextBoxColumn.DataPropertyName = "NIF Cliente";
            this.nIFClienteDataGridViewTextBoxColumn.HeaderText = "NIF Cliente";
            this.nIFClienteDataGridViewTextBoxColumn.Name = "nIFClienteDataGridViewTextBoxColumn";
            this.nIFClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // númeroContaDataGridViewTextBoxColumn
            // 
            this.númeroContaDataGridViewTextBoxColumn.DataPropertyName = "Número Conta";
            this.númeroContaDataGridViewTextBoxColumn.HeaderText = "Número Conta";
            this.númeroContaDataGridViewTextBoxColumn.Name = "númeroContaDataGridViewTextBoxColumn";
            this.númeroContaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nIFFuncionarioDataGridViewTextBoxColumn
            // 
            this.nIFFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "NIF Funcionario";
            this.nIFFuncionarioDataGridViewTextBoxColumn.HeaderText = "NIF Funcionario";
            this.nIFFuncionarioDataGridViewTextBoxColumn.Name = "nIFFuncionarioDataGridViewTextBoxColumn";
            this.nIFFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // operacaoviewBindingSource
            // 
            this.operacaoviewBindingSource.DataMember = "operacaoview";
            this.operacaoviewBindingSource.DataSource = this.zOperacao;
            // 
            // zOperacao
            // 
            this.zOperacao.DataSetName = "zOperacao";
            this.zOperacao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label1.Size = new System.Drawing.Size(318, 78);
            this.label1.TabIndex = 2;
            this.label1.Text = "Operações";
            // 
            // panelPesquisa
            // 
            this.panelPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPesquisa.Controls.Add(this.label7);
            this.panelPesquisa.Controls.Add(this.geral);
            this.panelPesquisa.Controls.Add(this.label6);
            this.panelPesquisa.Controls.Add(this.label5);
            this.panelPesquisa.Controls.Add(this.label4);
            this.panelPesquisa.Controls.Add(this.NConta);
            this.panelPesquisa.Controls.Add(this.Tipotxt);
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
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "N. Conta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo";
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
            // NConta
            // 
            this.NConta.Location = new System.Drawing.Point(107, 67);
            this.NConta.Name = "NConta";
            this.NConta.Size = new System.Drawing.Size(100, 20);
            this.NConta.TabIndex = 3;
            this.NConta.TextChanged += new System.EventHandler(this.pesquisaColunas);
            // 
            // Tipotxt
            // 
            this.Tipotxt.Location = new System.Drawing.Point(107, 41);
            this.Tipotxt.Name = "Tipotxt";
            this.Tipotxt.Size = new System.Drawing.Size(100, 20);
            this.Tipotxt.TabIndex = 2;
            this.Tipotxt.TextChanged += new System.EventHandler(this.pesquisaColunas);
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
            this.panelCaixasTexto.Controls.Add(nomeLabel);
            this.panelCaixasTexto.Controls.Add(this.nomeTextBox);
            this.panelCaixasTexto.Controls.Add(nIF_ClienteLabel);
            this.panelCaixasTexto.Controls.Add(this.nIF_ClienteTextBox);
            this.panelCaixasTexto.Controls.Add(número_ContaLabel);
            this.panelCaixasTexto.Controls.Add(this.número_ContaTextBox);
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
            this.panelCaixasTexto.Size = new System.Drawing.Size(710, 130);
            this.panelCaixasTexto.TabIndex = 4;
            // 
            // iD_OperaçãoTextBox
            // 
            this.iD_OperaçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operacaoviewBindingSource, "ID Operação", true));
            this.iD_OperaçãoTextBox.Location = new System.Drawing.Point(168, 13);
            this.iD_OperaçãoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iD_OperaçãoTextBox.Name = "iD_OperaçãoTextBox";
            this.iD_OperaçãoTextBox.Size = new System.Drawing.Size(176, 20);
            this.iD_OperaçãoTextBox.TabIndex = 1;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operacaoviewBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(168, 39);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(176, 20);
            this.nomeTextBox.TabIndex = 3;
            // 
            // nIF_ClienteTextBox
            // 
            this.nIF_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operacaoviewBindingSource, "NIF Cliente", true));
            this.nIF_ClienteTextBox.Location = new System.Drawing.Point(168, 72);
            this.nIF_ClienteTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nIF_ClienteTextBox.Name = "nIF_ClienteTextBox";
            this.nIF_ClienteTextBox.Size = new System.Drawing.Size(176, 20);
            this.nIF_ClienteTextBox.TabIndex = 5;
            // 
            // número_ContaTextBox
            // 
            this.número_ContaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operacaoviewBindingSource, "Número Conta", true));
            this.número_ContaTextBox.Location = new System.Drawing.Point(168, 97);
            this.número_ContaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.número_ContaTextBox.Name = "número_ContaTextBox";
            this.número_ContaTextBox.Size = new System.Drawing.Size(176, 20);
            this.número_ContaTextBox.TabIndex = 7;
            // 
            // nIF_FuncionarioTextBox
            // 
            this.nIF_FuncionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operacaoviewBindingSource, "NIF Funcionario", true));
            this.nIF_FuncionarioTextBox.Location = new System.Drawing.Point(472, 94);
            this.nIF_FuncionarioTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nIF_FuncionarioTextBox.Name = "nIF_FuncionarioTextBox";
            this.nIF_FuncionarioTextBox.Size = new System.Drawing.Size(176, 20);
            this.nIF_FuncionarioTextBox.TabIndex = 9;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operacaoviewBindingSource, "Tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(472, 65);
            this.tipoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(176, 20);
            this.tipoTextBox.TabIndex = 11;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.operacaoviewBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(472, 39);
            this.dataDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(176, 20);
            this.dataDateTimePicker.TabIndex = 13;
            // 
            // horaTextBox
            // 
            this.horaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operacaoviewBindingSource, "Hora", true));
            this.horaTextBox.Location = new System.Drawing.Point(472, 10);
            this.horaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.horaTextBox.Name = "horaTextBox";
            this.horaTextBox.Size = new System.Drawing.Size(176, 20);
            this.horaTextBox.TabIndex = 15;
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.butLevantamento);
            this.panelBotoes.Controls.Add(this.butEmprestimo);
            this.panelBotoes.Controls.Add(this.butDeposito);
            this.panelBotoes.Controls.Add(this.buTransferencia);
            this.panelBotoes.Location = new System.Drawing.Point(8, 559);
            this.panelBotoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(710, 66);
            this.panelBotoes.TabIndex = 5;
            // 
            // butLevantamento
            // 
            this.butLevantamento.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLevantamento.Location = new System.Drawing.Point(524, 7);
            this.butLevantamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butLevantamento.Name = "butLevantamento";
            this.butLevantamento.Size = new System.Drawing.Size(168, 46);
            this.butLevantamento.TabIndex = 3;
            this.butLevantamento.Text = "Levantamentos";
            this.butLevantamento.UseVisualStyleBackColor = true;
            this.butLevantamento.Click += new System.EventHandler(this.butLevantamento_Click);
            // 
            // butEmprestimo
            // 
            this.butEmprestimo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEmprestimo.Location = new System.Drawing.Point(354, 7);
            this.butEmprestimo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butEmprestimo.Name = "butEmprestimo";
            this.butEmprestimo.Size = new System.Drawing.Size(168, 46);
            this.butEmprestimo.TabIndex = 2;
            this.butEmprestimo.Text = "Empréstimos";
            this.butEmprestimo.UseVisualStyleBackColor = true;
            this.butEmprestimo.Click += new System.EventHandler(this.butEmprestimo_Click);
            // 
            // butDeposito
            // 
            this.butDeposito.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeposito.Location = new System.Drawing.Point(183, 7);
            this.butDeposito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butDeposito.Name = "butDeposito";
            this.butDeposito.Size = new System.Drawing.Size(168, 46);
            this.butDeposito.TabIndex = 1;
            this.butDeposito.Text = "Depósitos";
            this.butDeposito.UseVisualStyleBackColor = true;
            this.butDeposito.Click += new System.EventHandler(this.butDeposito_Click);
            // 
            // buTransferencia
            // 
            this.buTransferencia.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buTransferencia.Location = new System.Drawing.Point(12, 7);
            this.buTransferencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buTransferencia.Name = "buTransferencia";
            this.buTransferencia.Size = new System.Drawing.Size(168, 46);
            this.buTransferencia.TabIndex = 0;
            this.buTransferencia.Text = "Transferências";
            this.buTransferencia.UseVisualStyleBackColor = true;
            this.buTransferencia.Click += new System.EventHandler(this.buTransferencia_Click);
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
            // operacaoviewTableAdapter
            // 
            this.operacaoviewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = SistBancario.zOperacaoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // operacao
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
            this.Controls.Add(this.OperacaoDataGridView);
            this.Controls.Add(this.panelPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "operacao";
            this.Text = "Sistema Bancário - Balcão";
            this.Load += new System.EventHandler(this.operacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OperacaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacaoviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zOperacao)).EndInit();
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

        private System.Windows.Forms.DataGridView OperacaoDataGridView;
        private zBalcao zBalcao;
        private System.Windows.Forms.BindingSource balcaoviewBindingSource;
        private zBalcaoTableAdapters.balcaoviewTableAdapter balcaoviewTableAdapter;
        private zBalcaoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPesquisa;
        private System.Windows.Forms.Panel panelCaixasTexto;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Button butMenuInicial;
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NConta;
        private System.Windows.Forms.TextBox Tipotxt;
        private System.Windows.Forms.TextBox IDOperacao;
        private System.Windows.Forms.TextBox geral;
        private System.Windows.Forms.Label label7;
        private zOperacao zOperacao;
        private System.Windows.Forms.BindingSource operacaoviewBindingSource;
        private zOperacaoTableAdapters.operacaoviewTableAdapter operacaoviewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOperaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn númeroContaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox iD_OperaçãoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox nIF_ClienteTextBox;
        private System.Windows.Forms.TextBox número_ContaTextBox;
        private System.Windows.Forms.TextBox nIF_FuncionarioTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox horaTextBox;
        private zOperacaoTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button butLevantamento;
        private System.Windows.Forms.Button butEmprestimo;
        private System.Windows.Forms.Button butDeposito;
        private System.Windows.Forms.Button buTransferencia;
    }
}