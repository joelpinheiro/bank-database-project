namespace SistBancario
{
    partial class balcao
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
            System.Windows.Forms.Label nBalcaoLabel;
            System.Windows.Forms.Label ntelefoneLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label horarioLabel;
            System.Windows.Forms.Label paísLabel;
            System.Windows.Forms.Label localidadeLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label codPostalLabel;
            System.Windows.Forms.Label servicosLabel;
            System.Windows.Forms.Label faxLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(balcao));
            this.BalcaoDataGridView = new System.Windows.Forms.DataGridView();
            this.nBalcaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntelefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paísDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.paísP = new System.Windows.Forms.TextBox();
            this.nBalcaoP = new System.Windows.Forms.TextBox();
            this.NomeP = new System.Windows.Forms.TextBox();
            this.panelCaixasTexto = new System.Windows.Forms.Panel();
            this.nBalcaoTextBox = new System.Windows.Forms.TextBox();
            this.ntelefoneTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.horarioTextBox = new System.Windows.Forms.TextBox();
            this.paísTextBox = new System.Windows.Forms.TextBox();
            this.localidadeTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.codPostalTextBox = new System.Windows.Forms.TextBox();
            this.servicosTextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.butEliminar = new System.Windows.Forms.Button();
            this.butActualizar = new System.Windows.Forms.Button();
            this.butInserir = new System.Windows.Forms.Button();
            this.butMenuInicial = new System.Windows.Forms.Button();
            this.lblAjuda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butCancelar = new System.Windows.Forms.Button();
            nBalcaoLabel = new System.Windows.Forms.Label();
            ntelefoneLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            horarioLabel = new System.Windows.Forms.Label();
            paísLabel = new System.Windows.Forms.Label();
            localidadeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            codPostalLabel = new System.Windows.Forms.Label();
            servicosLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BalcaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balcaoviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zBalcao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPesquisa.SuspendLayout();
            this.panelCaixasTexto.SuspendLayout();
            this.panelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // nBalcaoLabel
            // 
            nBalcaoLabel.AutoSize = true;
            nBalcaoLabel.Location = new System.Drawing.Point(20, 26);
            nBalcaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nBalcaoLabel.Name = "nBalcaoLabel";
            nBalcaoLabel.Size = new System.Drawing.Size(52, 13);
            nBalcaoLabel.TabIndex = 0;
            nBalcaoLabel.Text = "n Balcao:";
            // 
            // ntelefoneLabel
            // 
            ntelefoneLabel.AutoSize = true;
            ntelefoneLabel.Location = new System.Drawing.Point(20, 64);
            ntelefoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ntelefoneLabel.Name = "ntelefoneLabel";
            ntelefoneLabel.Size = new System.Drawing.Size(54, 13);
            ntelefoneLabel.TabIndex = 2;
            ntelefoneLabel.Text = "ntelefone:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(20, 100);
            nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(36, 13);
            nomeLabel.TabIndex = 4;
            nomeLabel.Text = "nome:";
            // 
            // horarioLabel
            // 
            horarioLabel.AutoSize = true;
            horarioLabel.Location = new System.Drawing.Point(20, 136);
            horarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            horarioLabel.Name = "horarioLabel";
            horarioLabel.Size = new System.Drawing.Size(42, 13);
            horarioLabel.TabIndex = 6;
            horarioLabel.Text = "horario:";
            // 
            // paísLabel
            // 
            paísLabel.AutoSize = true;
            paísLabel.Location = new System.Drawing.Point(20, 174);
            paísLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            paísLabel.Name = "paísLabel";
            paísLabel.Size = new System.Drawing.Size(31, 13);
            paísLabel.TabIndex = 8;
            paísLabel.Text = "país:";
            // 
            // localidadeLabel
            // 
            localidadeLabel.AutoSize = true;
            localidadeLabel.Location = new System.Drawing.Point(716, 26);
            localidadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            localidadeLabel.Name = "localidadeLabel";
            localidadeLabel.Size = new System.Drawing.Size(58, 13);
            localidadeLabel.TabIndex = 10;
            localidadeLabel.Text = "localidade:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(716, 64);
            enderecoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(55, 13);
            enderecoLabel.TabIndex = 12;
            enderecoLabel.Text = "endereco:";
            // 
            // codPostalLabel
            // 
            codPostalLabel.AutoSize = true;
            codPostalLabel.Location = new System.Drawing.Point(716, 100);
            codPostalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codPostalLabel.Name = "codPostalLabel";
            codPostalLabel.Size = new System.Drawing.Size(60, 13);
            codPostalLabel.TabIndex = 14;
            codPostalLabel.Text = "cod Postal:";
            // 
            // servicosLabel
            // 
            servicosLabel.AutoSize = true;
            servicosLabel.Location = new System.Drawing.Point(716, 136);
            servicosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            servicosLabel.Name = "servicosLabel";
            servicosLabel.Size = new System.Drawing.Size(49, 13);
            servicosLabel.TabIndex = 16;
            servicosLabel.Text = "servicos:";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(716, 174);
            faxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(24, 13);
            faxLabel.TabIndex = 18;
            faxLabel.Text = "fax:";
            // 
            // BalcaoDataGridView
            // 
            this.BalcaoDataGridView.AllowUserToAddRows = false;
            this.BalcaoDataGridView.AllowUserToDeleteRows = false;
            this.BalcaoDataGridView.AllowUserToResizeRows = false;
            this.BalcaoDataGridView.AutoGenerateColumns = false;
            this.BalcaoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BalcaoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.BalcaoDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.BalcaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BalcaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nBalcaoDataGridViewTextBoxColumn,
            this.ntelefoneDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.horarioDataGridViewTextBoxColumn,
            this.paísDataGridViewTextBoxColumn,
            this.localidadeDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.codPostalDataGridViewTextBoxColumn,
            this.servicosDataGridViewTextBoxColumn,
            this.faxDataGridViewTextBoxColumn});
            this.BalcaoDataGridView.DataSource = this.balcaoviewBindingSource;
            this.BalcaoDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.BalcaoDataGridView.Location = new System.Drawing.Point(12, 358);
            this.BalcaoDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.BalcaoDataGridView.Name = "BalcaoDataGridView";
            this.BalcaoDataGridView.ReadOnly = true;
            this.BalcaoDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.BalcaoDataGridView.RowHeadersVisible = false;
            this.BalcaoDataGridView.RowHeadersWidth = 20;
            this.BalcaoDataGridView.RowTemplate.Height = 17;
            this.BalcaoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BalcaoDataGridView.Size = new System.Drawing.Size(1420, 216);
            this.BalcaoDataGridView.TabIndex = 0;
            // 
            // nBalcaoDataGridViewTextBoxColumn
            // 
            this.nBalcaoDataGridViewTextBoxColumn.DataPropertyName = "nBalcao";
            this.nBalcaoDataGridViewTextBoxColumn.HeaderText = "nBalcao";
            this.nBalcaoDataGridViewTextBoxColumn.Name = "nBalcaoDataGridViewTextBoxColumn";
            this.nBalcaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ntelefoneDataGridViewTextBoxColumn
            // 
            this.ntelefoneDataGridViewTextBoxColumn.DataPropertyName = "ntelefone";
            this.ntelefoneDataGridViewTextBoxColumn.HeaderText = "ntelefone";
            this.ntelefoneDataGridViewTextBoxColumn.Name = "ntelefoneDataGridViewTextBoxColumn";
            this.ntelefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horarioDataGridViewTextBoxColumn
            // 
            this.horarioDataGridViewTextBoxColumn.DataPropertyName = "horario";
            this.horarioDataGridViewTextBoxColumn.HeaderText = "horario";
            this.horarioDataGridViewTextBoxColumn.Name = "horarioDataGridViewTextBoxColumn";
            this.horarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paísDataGridViewTextBoxColumn
            // 
            this.paísDataGridViewTextBoxColumn.DataPropertyName = "país";
            this.paísDataGridViewTextBoxColumn.HeaderText = "país";
            this.paísDataGridViewTextBoxColumn.Name = "paísDataGridViewTextBoxColumn";
            this.paísDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localidadeDataGridViewTextBoxColumn
            // 
            this.localidadeDataGridViewTextBoxColumn.DataPropertyName = "localidade";
            this.localidadeDataGridViewTextBoxColumn.HeaderText = "localidade";
            this.localidadeDataGridViewTextBoxColumn.Name = "localidadeDataGridViewTextBoxColumn";
            this.localidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codPostalDataGridViewTextBoxColumn
            // 
            this.codPostalDataGridViewTextBoxColumn.DataPropertyName = "codPostal";
            this.codPostalDataGridViewTextBoxColumn.HeaderText = "codPostal";
            this.codPostalDataGridViewTextBoxColumn.Name = "codPostalDataGridViewTextBoxColumn";
            this.codPostalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // servicosDataGridViewTextBoxColumn
            // 
            this.servicosDataGridViewTextBoxColumn.DataPropertyName = "servicos";
            this.servicosDataGridViewTextBoxColumn.HeaderText = "servicos";
            this.servicosDataGridViewTextBoxColumn.Name = "servicosDataGridViewTextBoxColumn";
            this.servicosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faxDataGridViewTextBoxColumn
            // 
            this.faxDataGridViewTextBoxColumn.DataPropertyName = "fax";
            this.faxDataGridViewTextBoxColumn.HeaderText = "fax";
            this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
            this.faxDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 156);
            this.label1.TabIndex = 2;
            this.label1.Text = "Balcões";
            // 
            // panelPesquisa
            // 
            this.panelPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPesquisa.Controls.Add(this.label7);
            this.panelPesquisa.Controls.Add(this.geral);
            this.panelPesquisa.Controls.Add(this.label6);
            this.panelPesquisa.Controls.Add(this.label5);
            this.panelPesquisa.Controls.Add(this.label4);
            this.panelPesquisa.Controls.Add(this.paísP);
            this.panelPesquisa.Controls.Add(this.nBalcaoP);
            this.panelPesquisa.Controls.Add(this.NomeP);
            this.panelPesquisa.Location = new System.Drawing.Point(12, 608);
            this.panelPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.panelPesquisa.Name = "panelPesquisa";
            this.panelPesquisa.Size = new System.Drawing.Size(1418, 210);
            this.panelPesquisa.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(936, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 39);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pesquisa geral";
            // 
            // geral
            // 
            this.geral.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geral.Location = new System.Drawing.Point(870, 96);
            this.geral.Name = "geral";
            this.geral.Size = new System.Drawing.Size(355, 56);
            this.geral.TabIndex = 7;
            this.geral.TextChanged += new System.EventHandler(this.search);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "País";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nº Balcão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome";
            // 
            // paísP
            // 
            this.paísP.Location = new System.Drawing.Point(214, 134);
            this.paísP.Margin = new System.Windows.Forms.Padding(6);
            this.paísP.Name = "paísP";
            this.paísP.Size = new System.Drawing.Size(196, 20);
            this.paísP.TabIndex = 3;
            this.paísP.TextChanged += new System.EventHandler(this.pesquisaColunas);
            // 
            // nBalcaoP
            // 
            this.nBalcaoP.Location = new System.Drawing.Point(214, 82);
            this.nBalcaoP.Margin = new System.Windows.Forms.Padding(6);
            this.nBalcaoP.Name = "nBalcaoP";
            this.nBalcaoP.Size = new System.Drawing.Size(196, 20);
            this.nBalcaoP.TabIndex = 2;
            this.nBalcaoP.TextChanged += new System.EventHandler(this.pesquisaColunas);
            // 
            // NomeP
            // 
            this.NomeP.Location = new System.Drawing.Point(214, 30);
            this.NomeP.Margin = new System.Windows.Forms.Padding(6);
            this.NomeP.Name = "NomeP";
            this.NomeP.Size = new System.Drawing.Size(196, 20);
            this.NomeP.TabIndex = 1;
            this.NomeP.TextChanged += new System.EventHandler(this.pesquisaColunas);
            // 
            // panelCaixasTexto
            // 
            this.panelCaixasTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCaixasTexto.Controls.Add(nBalcaoLabel);
            this.panelCaixasTexto.Controls.Add(this.nBalcaoTextBox);
            this.panelCaixasTexto.Controls.Add(ntelefoneLabel);
            this.panelCaixasTexto.Controls.Add(this.ntelefoneTextBox);
            this.panelCaixasTexto.Controls.Add(nomeLabel);
            this.panelCaixasTexto.Controls.Add(this.nomeTextBox);
            this.panelCaixasTexto.Controls.Add(horarioLabel);
            this.panelCaixasTexto.Controls.Add(this.horarioTextBox);
            this.panelCaixasTexto.Controls.Add(paísLabel);
            this.panelCaixasTexto.Controls.Add(this.paísTextBox);
            this.panelCaixasTexto.Controls.Add(localidadeLabel);
            this.panelCaixasTexto.Controls.Add(this.localidadeTextBox);
            this.panelCaixasTexto.Controls.Add(enderecoLabel);
            this.panelCaixasTexto.Controls.Add(this.enderecoTextBox);
            this.panelCaixasTexto.Controls.Add(codPostalLabel);
            this.panelCaixasTexto.Controls.Add(this.codPostalTextBox);
            this.panelCaixasTexto.Controls.Add(servicosLabel);
            this.panelCaixasTexto.Controls.Add(this.servicosTextBox);
            this.panelCaixasTexto.Controls.Add(faxLabel);
            this.panelCaixasTexto.Controls.Add(this.faxTextBox);
            this.panelCaixasTexto.Enabled = false;
            this.panelCaixasTexto.Location = new System.Drawing.Point(12, 852);
            this.panelCaixasTexto.Margin = new System.Windows.Forms.Padding(4);
            this.panelCaixasTexto.Name = "panelCaixasTexto";
            this.panelCaixasTexto.Size = new System.Drawing.Size(1418, 258);
            this.panelCaixasTexto.TabIndex = 4;
            // 
            // nBalcaoTextBox
            // 
            this.nBalcaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.balcaoviewBindingSource, "nBalcao", true));
            this.nBalcaoTextBox.Enabled = false;
            this.nBalcaoTextBox.Location = new System.Drawing.Point(146, 24);
            this.nBalcaoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nBalcaoTextBox.Name = "nBalcaoTextBox";
            this.nBalcaoTextBox.Size = new System.Drawing.Size(504, 20);
            this.nBalcaoTextBox.TabIndex = 1;
            // 
            // ntelefoneTextBox
            // 
            this.ntelefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.balcaoviewBindingSource, "ntelefone", true));
            this.ntelefoneTextBox.Location = new System.Drawing.Point(146, 60);
            this.ntelefoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ntelefoneTextBox.Name = "ntelefoneTextBox";
            this.ntelefoneTextBox.Size = new System.Drawing.Size(504, 20);
            this.ntelefoneTextBox.TabIndex = 3;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.balcaoviewBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(146, 96);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(504, 20);
            this.nomeTextBox.TabIndex = 5;
            // 
            // horarioTextBox
            // 
            this.horarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.balcaoviewBindingSource, "horario", true));
            this.horarioTextBox.Location = new System.Drawing.Point(146, 134);
            this.horarioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.horarioTextBox.Name = "horarioTextBox";
            this.horarioTextBox.Size = new System.Drawing.Size(504, 20);
            this.horarioTextBox.TabIndex = 7;
            // 
            // paísTextBox
            // 
            this.paísTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.balcaoviewBindingSource, "país", true));
            this.paísTextBox.Location = new System.Drawing.Point(146, 172);
            this.paísTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.paísTextBox.Name = "paísTextBox";
            this.paísTextBox.Size = new System.Drawing.Size(504, 20);
            this.paísTextBox.TabIndex = 9;
            // 
            // localidadeTextBox
            // 
            this.localidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.balcaoviewBindingSource, "localidade", true));
            this.localidadeTextBox.Location = new System.Drawing.Point(842, 24);
            this.localidadeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.localidadeTextBox.Name = "localidadeTextBox";
            this.localidadeTextBox.Size = new System.Drawing.Size(504, 20);
            this.localidadeTextBox.TabIndex = 11;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.balcaoviewBindingSource, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(842, 60);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(504, 20);
            this.enderecoTextBox.TabIndex = 13;
            // 
            // codPostalTextBox
            // 
            this.codPostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.balcaoviewBindingSource, "codPostal", true));
            this.codPostalTextBox.Location = new System.Drawing.Point(842, 96);
            this.codPostalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.codPostalTextBox.Name = "codPostalTextBox";
            this.codPostalTextBox.Size = new System.Drawing.Size(504, 20);
            this.codPostalTextBox.TabIndex = 15;
            // 
            // servicosTextBox
            // 
            this.servicosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.balcaoviewBindingSource, "servicos", true));
            this.servicosTextBox.Location = new System.Drawing.Point(842, 134);
            this.servicosTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.servicosTextBox.Name = "servicosTextBox";
            this.servicosTextBox.Size = new System.Drawing.Size(504, 20);
            this.servicosTextBox.TabIndex = 17;
            // 
            // faxTextBox
            // 
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.balcaoviewBindingSource, "fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(842, 172);
            this.faxTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(504, 20);
            this.faxTextBox.TabIndex = 19;
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.butEliminar);
            this.panelBotoes.Controls.Add(this.butActualizar);
            this.panelBotoes.Controls.Add(this.butInserir);
            this.panelBotoes.Location = new System.Drawing.Point(16, 1118);
            this.panelBotoes.Margin = new System.Windows.Forms.Padding(4);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(1420, 132);
            this.panelBotoes.TabIndex = 5;
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(940, 4);
            this.butEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(452, 84);
            this.butEliminar.TabIndex = 2;
            this.butEliminar.Text = "Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // butActualizar
            // 
            this.butActualizar.Location = new System.Drawing.Point(484, 4);
            this.butActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.butActualizar.Name = "butActualizar";
            this.butActualizar.Size = new System.Drawing.Size(452, 84);
            this.butActualizar.TabIndex = 1;
            this.butActualizar.Text = "Actualizar";
            this.butActualizar.UseVisualStyleBackColor = true;
            this.butActualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // butInserir
            // 
            this.butInserir.Location = new System.Drawing.Point(28, 4);
            this.butInserir.Margin = new System.Windows.Forms.Padding(4);
            this.butInserir.Name = "butInserir";
            this.butInserir.Size = new System.Drawing.Size(452, 84);
            this.butInserir.TabIndex = 0;
            this.butInserir.Text = "Inserir";
            this.butInserir.UseVisualStyleBackColor = true;
            this.butInserir.Click += new System.EventHandler(this.Inserir_Click);
            // 
            // butMenuInicial
            // 
            this.butMenuInicial.Image = ((System.Drawing.Image)(resources.GetObject("butMenuInicial.Image")));
            this.butMenuInicial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butMenuInicial.Location = new System.Drawing.Point(1228, 12);
            this.butMenuInicial.Margin = new System.Windows.Forms.Padding(4);
            this.butMenuInicial.Name = "butMenuInicial";
            this.butMenuInicial.Size = new System.Drawing.Size(200, 116);
            this.butMenuInicial.TabIndex = 6;
            this.butMenuInicial.Text = "Menu Inicial";
            this.butMenuInicial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butMenuInicial.UseVisualStyleBackColor = true;
            this.butMenuInicial.Click += new System.EventHandler(this.butMenuInicial_Click);
            // 
            // lblAjuda
            // 
            this.lblAjuda.AutoSize = true;
            this.lblAjuda.Location = new System.Drawing.Point(13, 329);
            this.lblAjuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(149, 13);
            this.lblAjuda.TabIndex = 7;
            this.lblAjuda.Text = "Selecione uma linha da grelha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 594);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pesquisa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 836);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Info da grelha/Modo de edição";
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(498, 1210);
            this.butCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(452, 84);
            this.butCancelar.TabIndex = 3;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Visible = false;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // balcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1656, 1086);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAjuda);
            this.Controls.Add(this.butMenuInicial);
            this.Controls.Add(this.panelBotoes);
            this.Controls.Add(this.panelCaixasTexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BalcaoDataGridView);
            this.Controls.Add(this.panelPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "balcao";
            this.Text = "Sistema Bancário - Balcão";
            this.Load += new System.EventHandler(this.balcao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BalcaoDataGridView)).EndInit();
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

        private System.Windows.Forms.DataGridView BalcaoDataGridView;
        private zBalcao zBalcao;
        private System.Windows.Forms.BindingSource balcaoviewBindingSource;
        private zBalcaoTableAdapters.balcaoviewTableAdapter balcaoviewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nBalcaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ntelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paísDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private zBalcaoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPesquisa;
        private System.Windows.Forms.Panel panelCaixasTexto;
        private System.Windows.Forms.TextBox nBalcaoTextBox;
        private System.Windows.Forms.TextBox ntelefoneTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox horarioTextBox;
        private System.Windows.Forms.TextBox paísTextBox;
        private System.Windows.Forms.TextBox localidadeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox codPostalTextBox;
        private System.Windows.Forms.TextBox servicosTextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Button butEliminar;
        private System.Windows.Forms.Button butActualizar;
        private System.Windows.Forms.Button butInserir;
        private System.Windows.Forms.Button butMenuInicial;
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox paísP;
        private System.Windows.Forms.TextBox nBalcaoP;
        private System.Windows.Forms.TextBox NomeP;
        private System.Windows.Forms.TextBox geral;
        private System.Windows.Forms.Label label7;
    }
}