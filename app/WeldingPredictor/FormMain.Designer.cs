namespace WeldingPredictor
{
    partial class FormMain
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
            this.buttonLoadModel = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxPathToModel = new System.Windows.Forms.TextBox();
            this.labelPathToModel = new System.Windows.Forms.Label();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.labelPathToData = new System.Windows.Forms.Label();
            this.textBoxPathToData = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.iWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxIn = new System.Windows.Forms.GroupBox();
            this.labelFP = new System.Windows.Forms.Label();
            this.labelVW = new System.Windows.Forms.Label();
            this.labelIF = new System.Windows.Forms.Label();
            this.labelIW = new System.Windows.Forms.Label();
            this.textBoxFP = new System.Windows.Forms.TextBox();
            this.textBoxVW = new System.Windows.Forms.TextBox();
            this.textBoxIF = new System.Windows.Forms.TextBox();
            this.textBoxIW = new System.Windows.Forms.TextBox();
            this.groupBoxOut = new System.Windows.Forms.GroupBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxDepth = new System.Windows.Forms.TextBox();
            this.groupBoxPrediction = new System.Windows.Forms.GroupBox();
            this.labelDeltaWidth = new System.Windows.Forms.Label();
            this.labelDeltaDepth = new System.Windows.Forms.Label();
            this.labelWidthPrediction = new System.Windows.Forms.Label();
            this.labelDepthPrediction = new System.Windows.Forms.Label();
            this.textBoxWidthPrediction = new System.Windows.Forms.TextBox();
            this.textBoxDepthPrediction = new System.Windows.Forms.TextBox();
            this.buttonPrediction = new System.Windows.Forms.Button();
            this.buttonFullPrediction = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelMAE = new System.Windows.Forms.Label();
            this.textBoxMAEDepth = new System.Windows.Forms.TextBox();
            this.textBoxMSEDepth = new System.Windows.Forms.TextBox();
            this.labelMSE = new System.Windows.Forms.Label();
            this.textBoxRMSEDepth = new System.Windows.Forms.TextBox();
            this.labelRMSE = new System.Windows.Forms.Label();
            this.textBoxR2Depth = new System.Windows.Forms.TextBox();
            this.labelR2 = new System.Windows.Forms.Label();
            this.labelStatistic = new System.Windows.Forms.Label();
            this.textBoxR2Width = new System.Windows.Forms.TextBox();
            this.textBoxRMSEWidth = new System.Windows.Forms.TextBox();
            this.textBoxMSEWidth = new System.Windows.Forms.TextBox();
            this.textBoxMAEWidth = new System.Windows.Forms.TextBox();
            this.textBoxMAPEWidth = new System.Windows.Forms.TextBox();
            this.textBoxMAPEDepth = new System.Windows.Forms.TextBox();
            this.labelMAPE = new System.Windows.Forms.Label();
            this.labelDepthStat = new System.Windows.Forms.Label();
            this.labelWidthStat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.groupBoxIn.SuspendLayout();
            this.groupBoxOut.SuspendLayout();
            this.groupBoxPrediction.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadModel
            // 
            this.buttonLoadModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadModel.Location = new System.Drawing.Point(819, 34);
            this.buttonLoadModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLoadModel.Name = "buttonLoadModel";
            this.buttonLoadModel.Size = new System.Drawing.Size(52, 25);
            this.buttonLoadModel.TabIndex = 1;
            this.buttonLoadModel.Text = "...";
            this.buttonLoadModel.UseVisualStyleBackColor = true;
            this.buttonLoadModel.Click += new System.EventHandler(this.buttonLoadModel_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(568, 670);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(302, 58);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "ВЫХОД";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxPathToModel
            // 
            this.textBoxPathToModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPathToModel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxPathToModel.Location = new System.Drawing.Point(13, 34);
            this.textBoxPathToModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPathToModel.Name = "textBoxPathToModel";
            this.textBoxPathToModel.Size = new System.Drawing.Size(798, 26);
            this.textBoxPathToModel.TabIndex = 1;
            // 
            // labelPathToModel
            // 
            this.labelPathToModel.AutoSize = true;
            this.labelPathToModel.Location = new System.Drawing.Point(13, 9);
            this.labelPathToModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPathToModel.Name = "labelPathToModel";
            this.labelPathToModel.Size = new System.Drawing.Size(175, 20);
            this.labelPathToModel.TabIndex = 2;
            this.labelPathToModel.Text = "Путь к файлу модели";
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadData.Location = new System.Drawing.Point(819, 91);
            this.buttonLoadData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(52, 25);
            this.buttonLoadData.TabIndex = 3;
            this.buttonLoadData.Text = "...";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // labelPathToData
            // 
            this.labelPathToData.AutoSize = true;
            this.labelPathToData.Location = new System.Drawing.Point(13, 65);
            this.labelPathToData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPathToData.Name = "labelPathToData";
            this.labelPathToData.Size = new System.Drawing.Size(172, 20);
            this.labelPathToData.TabIndex = 5;
            this.labelPathToData.Text = "Путь к файлу данных";
            // 
            // textBoxPathToData
            // 
            this.textBoxPathToData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPathToData.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxPathToData.Location = new System.Drawing.Point(13, 90);
            this.textBoxPathToData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPathToData.Name = "textBoxPathToData";
            this.textBoxPathToData.Size = new System.Drawing.Size(798, 26);
            this.textBoxPathToData.TabIndex = 4;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeight = 32;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iWDataGridViewTextBoxColumn,
            this.iFDataGridViewTextBoxColumn,
            this.vWDataGridViewTextBoxColumn,
            this.fPDataGridViewTextBoxColumn,
            this.depthDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.bindingSource;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(14, 127);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowCellErrors = false;
            this.dataGridView.ShowCellToolTips = false;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.ShowRowErrors = false;
            this.dataGridView.Size = new System.Drawing.Size(544, 441);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // iWDataGridViewTextBoxColumn
            // 
            this.iWDataGridViewTextBoxColumn.DataPropertyName = "IW";
            this.iWDataGridViewTextBoxColumn.HeaderText = "IW";
            this.iWDataGridViewTextBoxColumn.Name = "iWDataGridViewTextBoxColumn";
            this.iWDataGridViewTextBoxColumn.ReadOnly = true;
            this.iWDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iWDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.iWDataGridViewTextBoxColumn.Width = 75;
            // 
            // iFDataGridViewTextBoxColumn
            // 
            this.iFDataGridViewTextBoxColumn.DataPropertyName = "IF";
            this.iFDataGridViewTextBoxColumn.HeaderText = "IF";
            this.iFDataGridViewTextBoxColumn.Name = "iFDataGridViewTextBoxColumn";
            this.iFDataGridViewTextBoxColumn.ReadOnly = true;
            this.iFDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iFDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.iFDataGridViewTextBoxColumn.Width = 75;
            // 
            // vWDataGridViewTextBoxColumn
            // 
            this.vWDataGridViewTextBoxColumn.DataPropertyName = "VW";
            this.vWDataGridViewTextBoxColumn.HeaderText = "VW";
            this.vWDataGridViewTextBoxColumn.Name = "vWDataGridViewTextBoxColumn";
            this.vWDataGridViewTextBoxColumn.ReadOnly = true;
            this.vWDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.vWDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.vWDataGridViewTextBoxColumn.Width = 75;
            // 
            // fPDataGridViewTextBoxColumn
            // 
            this.fPDataGridViewTextBoxColumn.DataPropertyName = "FP";
            this.fPDataGridViewTextBoxColumn.HeaderText = "FP";
            this.fPDataGridViewTextBoxColumn.Name = "fPDataGridViewTextBoxColumn";
            this.fPDataGridViewTextBoxColumn.ReadOnly = true;
            this.fPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fPDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fPDataGridViewTextBoxColumn.Width = 75;
            // 
            // depthDataGridViewTextBoxColumn
            // 
            this.depthDataGridViewTextBoxColumn.DataPropertyName = "Depth";
            this.depthDataGridViewTextBoxColumn.HeaderText = "Depth";
            this.depthDataGridViewTextBoxColumn.Name = "depthDataGridViewTextBoxColumn";
            this.depthDataGridViewTextBoxColumn.ReadOnly = true;
            this.depthDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.depthDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Width";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.ReadOnly = true;
            this.widthDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.widthDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(WeldingPredictor.WeldingDataItem);
            // 
            // groupBoxIn
            // 
            this.groupBoxIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIn.Controls.Add(this.labelFP);
            this.groupBoxIn.Controls.Add(this.labelVW);
            this.groupBoxIn.Controls.Add(this.labelIF);
            this.groupBoxIn.Controls.Add(this.labelIW);
            this.groupBoxIn.Controls.Add(this.textBoxFP);
            this.groupBoxIn.Controls.Add(this.textBoxVW);
            this.groupBoxIn.Controls.Add(this.textBoxIF);
            this.groupBoxIn.Controls.Add(this.textBoxIW);
            this.groupBoxIn.Location = new System.Drawing.Point(567, 127);
            this.groupBoxIn.Name = "groupBoxIn";
            this.groupBoxIn.Size = new System.Drawing.Size(304, 176);
            this.groupBoxIn.TabIndex = 7;
            this.groupBoxIn.TabStop = false;
            this.groupBoxIn.Text = "Входные параметры";
            // 
            // labelFP
            // 
            this.labelFP.AutoSize = true;
            this.labelFP.ForeColor = System.Drawing.Color.DimGray;
            this.labelFP.Location = new System.Drawing.Point(22, 138);
            this.labelFP.Name = "labelFP";
            this.labelFP.Size = new System.Drawing.Size(137, 20);
            this.labelFP.TabIndex = 7;
            this.labelFP.Text = "Скорость сварки";
            // 
            // labelVW
            // 
            this.labelVW.AutoSize = true;
            this.labelVW.ForeColor = System.Drawing.Color.DimGray;
            this.labelVW.Location = new System.Drawing.Point(22, 106);
            this.labelVW.Name = "labelVW";
            this.labelVW.Size = new System.Drawing.Size(137, 20);
            this.labelVW.TabIndex = 6;
            this.labelVW.Text = "Скорость сварки";
            // 
            // labelIF
            // 
            this.labelIF.AutoSize = true;
            this.labelIF.ForeColor = System.Drawing.Color.DimGray;
            this.labelIF.Location = new System.Drawing.Point(22, 74);
            this.labelIF.Name = "labelIF";
            this.labelIF.Size = new System.Drawing.Size(139, 20);
            this.labelIF.TabIndex = 5;
            this.labelIF.Text = "Ток фокусировки";
            // 
            // labelIW
            // 
            this.labelIW.AutoSize = true;
            this.labelIW.ForeColor = System.Drawing.Color.DimGray;
            this.labelIW.Location = new System.Drawing.Point(22, 42);
            this.labelIW.Name = "labelIW";
            this.labelIW.Size = new System.Drawing.Size(165, 20);
            this.labelIW.TabIndex = 4;
            this.labelIW.Text = "Ток сварочного тока";
            // 
            // textBoxFP
            // 
            this.textBoxFP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFP.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxFP.Location = new System.Drawing.Point(192, 135);
            this.textBoxFP.Name = "textBoxFP";
            this.textBoxFP.Size = new System.Drawing.Size(106, 26);
            this.textBoxFP.TabIndex = 3;
            // 
            // textBoxVW
            // 
            this.textBoxVW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVW.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxVW.Location = new System.Drawing.Point(192, 103);
            this.textBoxVW.Name = "textBoxVW";
            this.textBoxVW.Size = new System.Drawing.Size(106, 26);
            this.textBoxVW.TabIndex = 2;
            // 
            // textBoxIF
            // 
            this.textBoxIF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIF.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxIF.Location = new System.Drawing.Point(192, 71);
            this.textBoxIF.Name = "textBoxIF";
            this.textBoxIF.Size = new System.Drawing.Size(106, 26);
            this.textBoxIF.TabIndex = 1;
            // 
            // textBoxIW
            // 
            this.textBoxIW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIW.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxIW.Location = new System.Drawing.Point(193, 39);
            this.textBoxIW.Name = "textBoxIW";
            this.textBoxIW.Size = new System.Drawing.Size(105, 26);
            this.textBoxIW.TabIndex = 0;
            // 
            // groupBoxOut
            // 
            this.groupBoxOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOut.Controls.Add(this.labelWidth);
            this.groupBoxOut.Controls.Add(this.labelDepth);
            this.groupBoxOut.Controls.Add(this.textBoxWidth);
            this.groupBoxOut.Controls.Add(this.textBoxDepth);
            this.groupBoxOut.Location = new System.Drawing.Point(568, 309);
            this.groupBoxOut.Name = "groupBoxOut";
            this.groupBoxOut.Size = new System.Drawing.Size(304, 106);
            this.groupBoxOut.TabIndex = 8;
            this.groupBoxOut.TabStop = false;
            this.groupBoxOut.Text = "Выходные параметры";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelWidth.Location = new System.Drawing.Point(22, 68);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(102, 20);
            this.labelWidth.TabIndex = 5;
            this.labelWidth.Text = "Ширина шва";
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelDepth.Location = new System.Drawing.Point(22, 36);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(106, 20);
            this.labelDepth.TabIndex = 4;
            this.labelDepth.Text = "Глубина шва";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWidth.ForeColor = System.Drawing.Color.DarkCyan;
            this.textBoxWidth.Location = new System.Drawing.Point(191, 65);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(107, 26);
            this.textBoxWidth.TabIndex = 1;
            // 
            // textBoxDepth
            // 
            this.textBoxDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDepth.ForeColor = System.Drawing.Color.DarkCyan;
            this.textBoxDepth.Location = new System.Drawing.Point(191, 33);
            this.textBoxDepth.Name = "textBoxDepth";
            this.textBoxDepth.Size = new System.Drawing.Size(107, 26);
            this.textBoxDepth.TabIndex = 0;
            // 
            // groupBoxPrediction
            // 
            this.groupBoxPrediction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPrediction.Controls.Add(this.labelDeltaWidth);
            this.groupBoxPrediction.Controls.Add(this.labelDeltaDepth);
            this.groupBoxPrediction.Controls.Add(this.labelWidthPrediction);
            this.groupBoxPrediction.Controls.Add(this.labelDepthPrediction);
            this.groupBoxPrediction.Controls.Add(this.textBoxWidthPrediction);
            this.groupBoxPrediction.Controls.Add(this.textBoxDepthPrediction);
            this.groupBoxPrediction.Location = new System.Drawing.Point(568, 421);
            this.groupBoxPrediction.Name = "groupBoxPrediction";
            this.groupBoxPrediction.Size = new System.Drawing.Size(304, 106);
            this.groupBoxPrediction.TabIndex = 9;
            this.groupBoxPrediction.TabStop = false;
            this.groupBoxPrediction.Text = "Прогноз";
            // 
            // labelDeltaWidth
            // 
            this.labelDeltaWidth.BackColor = System.Drawing.Color.Transparent;
            this.labelDeltaWidth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelDeltaWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeltaWidth.ForeColor = System.Drawing.Color.DimGray;
            this.labelDeltaWidth.Location = new System.Drawing.Point(248, 76);
            this.labelDeltaWidth.Name = "labelDeltaWidth";
            this.labelDeltaWidth.Size = new System.Drawing.Size(46, 13);
            this.labelDeltaWidth.TabIndex = 7;
            this.labelDeltaWidth.Text = "0.00";
            this.labelDeltaWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelDeltaWidth.Visible = false;
            // 
            // labelDeltaDepth
            // 
            this.labelDeltaDepth.BackColor = System.Drawing.Color.Transparent;
            this.labelDeltaDepth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelDeltaDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeltaDepth.ForeColor = System.Drawing.Color.DimGray;
            this.labelDeltaDepth.Location = new System.Drawing.Point(248, 44);
            this.labelDeltaDepth.Name = "labelDeltaDepth";
            this.labelDeltaDepth.Size = new System.Drawing.Size(46, 13);
            this.labelDeltaDepth.TabIndex = 6;
            this.labelDeltaDepth.Text = "0.00";
            this.labelDeltaDepth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelDeltaDepth.Visible = false;
            // 
            // labelWidthPrediction
            // 
            this.labelWidthPrediction.AutoSize = true;
            this.labelWidthPrediction.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelWidthPrediction.Location = new System.Drawing.Point(22, 68);
            this.labelWidthPrediction.Name = "labelWidthPrediction";
            this.labelWidthPrediction.Size = new System.Drawing.Size(102, 20);
            this.labelWidthPrediction.TabIndex = 5;
            this.labelWidthPrediction.Text = "Ширина шва";
            // 
            // labelDepthPrediction
            // 
            this.labelDepthPrediction.AutoSize = true;
            this.labelDepthPrediction.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelDepthPrediction.Location = new System.Drawing.Point(22, 36);
            this.labelDepthPrediction.Name = "labelDepthPrediction";
            this.labelDepthPrediction.Size = new System.Drawing.Size(106, 20);
            this.labelDepthPrediction.TabIndex = 4;
            this.labelDepthPrediction.Text = "Глубина шва";
            // 
            // textBoxWidthPrediction
            // 
            this.textBoxWidthPrediction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWidthPrediction.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxWidthPrediction.Location = new System.Drawing.Point(191, 65);
            this.textBoxWidthPrediction.Name = "textBoxWidthPrediction";
            this.textBoxWidthPrediction.Size = new System.Drawing.Size(107, 26);
            this.textBoxWidthPrediction.TabIndex = 1;
            // 
            // textBoxDepthPrediction
            // 
            this.textBoxDepthPrediction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDepthPrediction.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxDepthPrediction.Location = new System.Drawing.Point(191, 33);
            this.textBoxDepthPrediction.Name = "textBoxDepthPrediction";
            this.textBoxDepthPrediction.Size = new System.Drawing.Size(107, 26);
            this.textBoxDepthPrediction.TabIndex = 0;
            // 
            // buttonPrediction
            // 
            this.buttonPrediction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrediction.Location = new System.Drawing.Point(568, 534);
            this.buttonPrediction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPrediction.Name = "buttonPrediction";
            this.buttonPrediction.Size = new System.Drawing.Size(303, 35);
            this.buttonPrediction.TabIndex = 11;
            this.buttonPrediction.Text = "ПРОГНОЗ";
            this.buttonPrediction.UseVisualStyleBackColor = true;
            this.buttonPrediction.Click += new System.EventHandler(this.buttonPrediction_Click);
            // 
            // buttonFullPrediction
            // 
            this.buttonFullPrediction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFullPrediction.Enabled = false;
            this.buttonFullPrediction.Location = new System.Drawing.Point(569, 579);
            this.buttonFullPrediction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFullPrediction.Name = "buttonFullPrediction";
            this.buttonFullPrediction.Size = new System.Drawing.Size(303, 64);
            this.buttonFullPrediction.TabIndex = 12;
            this.buttonFullPrediction.Text = "ПРОГОН ВСЕЙ ВЫБОРКИ";
            this.buttonFullPrediction.UseVisualStyleBackColor = true;
            this.buttonFullPrediction.Click += new System.EventHandler(this.buttonFullPrediction_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(14, 582);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(544, 29);
            this.progressBar.TabIndex = 13;
            // 
            // labelMAE
            // 
            this.labelMAE.AutoSize = true;
            this.labelMAE.Enabled = false;
            this.labelMAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMAE.Location = new System.Drawing.Point(174, 647);
            this.labelMAE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMAE.Name = "labelMAE";
            this.labelMAE.Size = new System.Drawing.Size(44, 20);
            this.labelMAE.TabIndex = 14;
            this.labelMAE.Text = "MAE";
            // 
            // textBoxMAEDepth
            // 
            this.textBoxMAEDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMAEDepth.Enabled = false;
            this.textBoxMAEDepth.ForeColor = System.Drawing.Color.Black;
            this.textBoxMAEDepth.Location = new System.Drawing.Point(159, 670);
            this.textBoxMAEDepth.Name = "textBoxMAEDepth";
            this.textBoxMAEDepth.Size = new System.Drawing.Size(75, 26);
            this.textBoxMAEDepth.TabIndex = 15;
            this.textBoxMAEDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMSEDepth
            // 
            this.textBoxMSEDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMSEDepth.Enabled = false;
            this.textBoxMSEDepth.ForeColor = System.Drawing.Color.Black;
            this.textBoxMSEDepth.Location = new System.Drawing.Point(240, 670);
            this.textBoxMSEDepth.Name = "textBoxMSEDepth";
            this.textBoxMSEDepth.Size = new System.Drawing.Size(75, 26);
            this.textBoxMSEDepth.TabIndex = 17;
            this.textBoxMSEDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMSE
            // 
            this.labelMSE.AutoSize = true;
            this.labelMSE.Enabled = false;
            this.labelMSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMSE.Location = new System.Drawing.Point(255, 647);
            this.labelMSE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMSE.Name = "labelMSE";
            this.labelMSE.Size = new System.Drawing.Size(44, 20);
            this.labelMSE.TabIndex = 16;
            this.labelMSE.Text = "MSE";
            // 
            // textBoxRMSEDepth
            // 
            this.textBoxRMSEDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRMSEDepth.Enabled = false;
            this.textBoxRMSEDepth.ForeColor = System.Drawing.Color.Black;
            this.textBoxRMSEDepth.Location = new System.Drawing.Point(321, 670);
            this.textBoxRMSEDepth.Name = "textBoxRMSEDepth";
            this.textBoxRMSEDepth.Size = new System.Drawing.Size(75, 26);
            this.textBoxRMSEDepth.TabIndex = 19;
            this.textBoxRMSEDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRMSE
            // 
            this.labelRMSE.AutoSize = true;
            this.labelRMSE.Enabled = false;
            this.labelRMSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRMSE.Location = new System.Drawing.Point(330, 647);
            this.labelRMSE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRMSE.Name = "labelRMSE";
            this.labelRMSE.Size = new System.Drawing.Size(56, 20);
            this.labelRMSE.TabIndex = 18;
            this.labelRMSE.Text = "RMSE";
            // 
            // textBoxR2Depth
            // 
            this.textBoxR2Depth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxR2Depth.Enabled = false;
            this.textBoxR2Depth.ForeColor = System.Drawing.Color.Black;
            this.textBoxR2Depth.Location = new System.Drawing.Point(402, 670);
            this.textBoxR2Depth.Name = "textBoxR2Depth";
            this.textBoxR2Depth.Size = new System.Drawing.Size(75, 26);
            this.textBoxR2Depth.TabIndex = 21;
            this.textBoxR2Depth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelR2
            // 
            this.labelR2.AutoSize = true;
            this.labelR2.Enabled = false;
            this.labelR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR2.Location = new System.Drawing.Point(424, 647);
            this.labelR2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelR2.Name = "labelR2";
            this.labelR2.Size = new System.Drawing.Size(30, 20);
            this.labelR2.TabIndex = 20;
            this.labelR2.Text = "R2";
            // 
            // labelStatistic
            // 
            this.labelStatistic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStatistic.Enabled = false;
            this.labelStatistic.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelStatistic.Location = new System.Drawing.Point(14, 617);
            this.labelStatistic.Name = "labelStatistic";
            this.labelStatistic.Size = new System.Drawing.Size(544, 26);
            this.labelStatistic.TabIndex = 22;
            this.labelStatistic.Text = "Статистика по всей выборке";
            this.labelStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxR2Width
            // 
            this.textBoxR2Width.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxR2Width.Enabled = false;
            this.textBoxR2Width.ForeColor = System.Drawing.Color.Black;
            this.textBoxR2Width.Location = new System.Drawing.Point(402, 702);
            this.textBoxR2Width.Name = "textBoxR2Width";
            this.textBoxR2Width.Size = new System.Drawing.Size(75, 26);
            this.textBoxR2Width.TabIndex = 26;
            this.textBoxR2Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRMSEWidth
            // 
            this.textBoxRMSEWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRMSEWidth.Enabled = false;
            this.textBoxRMSEWidth.ForeColor = System.Drawing.Color.Black;
            this.textBoxRMSEWidth.Location = new System.Drawing.Point(321, 702);
            this.textBoxRMSEWidth.Name = "textBoxRMSEWidth";
            this.textBoxRMSEWidth.Size = new System.Drawing.Size(75, 26);
            this.textBoxRMSEWidth.TabIndex = 25;
            this.textBoxRMSEWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMSEWidth
            // 
            this.textBoxMSEWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMSEWidth.Enabled = false;
            this.textBoxMSEWidth.ForeColor = System.Drawing.Color.Black;
            this.textBoxMSEWidth.Location = new System.Drawing.Point(240, 702);
            this.textBoxMSEWidth.Name = "textBoxMSEWidth";
            this.textBoxMSEWidth.Size = new System.Drawing.Size(75, 26);
            this.textBoxMSEWidth.TabIndex = 24;
            this.textBoxMSEWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMAEWidth
            // 
            this.textBoxMAEWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMAEWidth.Enabled = false;
            this.textBoxMAEWidth.ForeColor = System.Drawing.Color.Black;
            this.textBoxMAEWidth.Location = new System.Drawing.Point(159, 702);
            this.textBoxMAEWidth.Name = "textBoxMAEWidth";
            this.textBoxMAEWidth.Size = new System.Drawing.Size(75, 26);
            this.textBoxMAEWidth.TabIndex = 23;
            this.textBoxMAEWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMAPEWidth
            // 
            this.textBoxMAPEWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMAPEWidth.Enabled = false;
            this.textBoxMAPEWidth.ForeColor = System.Drawing.Color.Black;
            this.textBoxMAPEWidth.Location = new System.Drawing.Point(483, 702);
            this.textBoxMAPEWidth.Name = "textBoxMAPEWidth";
            this.textBoxMAPEWidth.Size = new System.Drawing.Size(75, 26);
            this.textBoxMAPEWidth.TabIndex = 29;
            this.textBoxMAPEWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMAPEDepth
            // 
            this.textBoxMAPEDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMAPEDepth.Enabled = false;
            this.textBoxMAPEDepth.ForeColor = System.Drawing.Color.Black;
            this.textBoxMAPEDepth.Location = new System.Drawing.Point(483, 670);
            this.textBoxMAPEDepth.Name = "textBoxMAPEDepth";
            this.textBoxMAPEDepth.Size = new System.Drawing.Size(75, 26);
            this.textBoxMAPEDepth.TabIndex = 28;
            this.textBoxMAPEDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMAPE
            // 
            this.labelMAPE.AutoSize = true;
            this.labelMAPE.Enabled = false;
            this.labelMAPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMAPE.Location = new System.Drawing.Point(493, 647);
            this.labelMAPE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMAPE.Name = "labelMAPE";
            this.labelMAPE.Size = new System.Drawing.Size(54, 20);
            this.labelMAPE.TabIndex = 27;
            this.labelMAPE.Text = "MAPE";
            // 
            // labelDepthStat
            // 
            this.labelDepthStat.AutoSize = true;
            this.labelDepthStat.Enabled = false;
            this.labelDepthStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDepthStat.Location = new System.Drawing.Point(17, 673);
            this.labelDepthStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDepthStat.Name = "labelDepthStat";
            this.labelDepthStat.Size = new System.Drawing.Size(71, 20);
            this.labelDepthStat.TabIndex = 30;
            this.labelDepthStat.Text = "Глубина";
            // 
            // labelWidthStat
            // 
            this.labelWidthStat.AutoSize = true;
            this.labelWidthStat.Enabled = false;
            this.labelWidthStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWidthStat.Location = new System.Drawing.Point(17, 705);
            this.labelWidthStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWidthStat.Name = "labelWidthStat";
            this.labelWidthStat.Size = new System.Drawing.Size(67, 20);
            this.labelWidthStat.TabIndex = 31;
            this.labelWidthStat.Text = "Ширина";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 746);
            this.Controls.Add(this.labelWidthStat);
            this.Controls.Add(this.labelDepthStat);
            this.Controls.Add(this.textBoxMAPEWidth);
            this.Controls.Add(this.textBoxMAPEDepth);
            this.Controls.Add(this.labelMAPE);
            this.Controls.Add(this.textBoxR2Width);
            this.Controls.Add(this.textBoxRMSEWidth);
            this.Controls.Add(this.textBoxMSEWidth);
            this.Controls.Add(this.textBoxMAEWidth);
            this.Controls.Add(this.labelStatistic);
            this.Controls.Add(this.textBoxR2Depth);
            this.Controls.Add(this.labelR2);
            this.Controls.Add(this.textBoxRMSEDepth);
            this.Controls.Add(this.labelRMSE);
            this.Controls.Add(this.textBoxMSEDepth);
            this.Controls.Add(this.labelMSE);
            this.Controls.Add(this.textBoxMAEDepth);
            this.Controls.Add(this.labelMAE);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonFullPrediction);
            this.Controls.Add(this.buttonPrediction);
            this.Controls.Add(this.groupBoxPrediction);
            this.Controls.Add(this.groupBoxOut);
            this.Controls.Add(this.groupBoxIn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.labelPathToData);
            this.Controls.Add(this.textBoxPathToData);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonLoadModel);
            this.Controls.Add(this.labelPathToModel);
            this.Controls.Add(this.textBoxPathToModel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welding Predictor 1.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.groupBoxIn.ResumeLayout(false);
            this.groupBoxIn.PerformLayout();
            this.groupBoxOut.ResumeLayout(false);
            this.groupBoxOut.PerformLayout();
            this.groupBoxPrediction.ResumeLayout(false);
            this.groupBoxPrediction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonLoadModel;
        private System.Windows.Forms.TextBox textBoxPathToModel;
        private System.Windows.Forms.Label labelPathToModel;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Label labelPathToData;
        private System.Windows.Forms.TextBox textBoxPathToData;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBoxIn;
        private System.Windows.Forms.Label labelFP;
        private System.Windows.Forms.Label labelVW;
        private System.Windows.Forms.Label labelIF;
        private System.Windows.Forms.Label labelIW;
        private System.Windows.Forms.TextBox textBoxFP;
        private System.Windows.Forms.TextBox textBoxVW;
        private System.Windows.Forms.TextBox textBoxIF;
        private System.Windows.Forms.TextBox textBoxIW;
        private System.Windows.Forms.GroupBox groupBoxOut;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxDepth;
        private System.Windows.Forms.GroupBox groupBoxPrediction;
        private System.Windows.Forms.Label labelWidthPrediction;
        private System.Windows.Forms.Label labelDepthPrediction;
        private System.Windows.Forms.TextBox textBoxWidthPrediction;
        private System.Windows.Forms.TextBox textBoxDepthPrediction;
        private System.Windows.Forms.Button buttonPrediction;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelDeltaWidth;
        private System.Windows.Forms.Label labelDeltaDepth;
        private System.Windows.Forms.Button buttonFullPrediction;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelMAE;
        private System.Windows.Forms.TextBox textBoxMAEDepth;
        private System.Windows.Forms.TextBox textBoxMSEDepth;
        private System.Windows.Forms.Label labelMSE;
        private System.Windows.Forms.TextBox textBoxRMSEDepth;
        private System.Windows.Forms.Label labelRMSE;
        private System.Windows.Forms.TextBox textBoxR2Depth;
        private System.Windows.Forms.Label labelR2;
        private System.Windows.Forms.Label labelStatistic;
        private System.Windows.Forms.TextBox textBoxR2Width;
        private System.Windows.Forms.TextBox textBoxRMSEWidth;
        private System.Windows.Forms.TextBox textBoxMSEWidth;
        private System.Windows.Forms.TextBox textBoxMAEWidth;
        private System.Windows.Forms.TextBox textBoxMAPEWidth;
        private System.Windows.Forms.TextBox textBoxMAPEDepth;
        private System.Windows.Forms.Label labelMAPE;
        private System.Windows.Forms.Label labelDepthStat;
        private System.Windows.Forms.Label labelWidthStat;
    }
}

