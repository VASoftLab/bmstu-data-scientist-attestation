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
            this.buttonLoadModel = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxPathToModel = new System.Windows.Forms.TextBox();
            this.labelPathToModel = new System.Windows.Forms.Label();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.labelPathToData = new System.Windows.Forms.Label();
            this.textBoxPathToData = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBoxIn = new System.Windows.Forms.GroupBox();
            this.textBoxIW = new System.Windows.Forms.TextBox();
            this.textBoxIF = new System.Windows.Forms.TextBox();
            this.textBoxVW = new System.Windows.Forms.TextBox();
            this.textBoxFP = new System.Windows.Forms.TextBox();
            this.labelIW = new System.Windows.Forms.Label();
            this.labelIF = new System.Windows.Forms.Label();
            this.labelVW = new System.Windows.Forms.Label();
            this.labelFP = new System.Windows.Forms.Label();
            this.groupBoxOut = new System.Windows.Forms.GroupBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxDepth = new System.Windows.Forms.TextBox();
            this.groupBoxPrediction = new System.Windows.Forms.GroupBox();
            this.labelWidthPrediction = new System.Windows.Forms.Label();
            this.labelDepthPrediction = new System.Windows.Forms.Label();
            this.textBoxWidthPrediction = new System.Windows.Forms.TextBox();
            this.textBoxDepthPrediction = new System.Windows.Forms.TextBox();
            this.buttonPrediction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.buttonClose.Location = new System.Drawing.Point(759, 546);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(112, 35);
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
            this.textBoxPathToModel.Location = new System.Drawing.Point(14, 34);
            this.textBoxPathToModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPathToModel.Name = "textBoxPathToModel";
            this.textBoxPathToModel.Size = new System.Drawing.Size(797, 26);
            this.textBoxPathToModel.TabIndex = 1;
            // 
            // labelPathToModel
            // 
            this.labelPathToModel.AutoSize = true;
            this.labelPathToModel.Location = new System.Drawing.Point(14, 9);
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
            this.labelPathToData.Location = new System.Drawing.Point(14, 65);
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
            this.textBoxPathToData.Location = new System.Drawing.Point(14, 90);
            this.textBoxPathToData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPathToData.Name = "textBoxPathToData";
            this.textBoxPathToData.Size = new System.Drawing.Size(797, 26);
            this.textBoxPathToData.TabIndex = 4;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(14, 127);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(544, 453);
            this.dataGridView.TabIndex = 6;
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
            // textBoxIW
            // 
            this.textBoxIW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIW.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxIW.Location = new System.Drawing.Point(193, 39);
            this.textBoxIW.Name = "textBoxIW";
            this.textBoxIW.Size = new System.Drawing.Size(100, 26);
            this.textBoxIW.TabIndex = 0;
            // 
            // textBoxIF
            // 
            this.textBoxIF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIF.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxIF.Location = new System.Drawing.Point(193, 71);
            this.textBoxIF.Name = "textBoxIF";
            this.textBoxIF.Size = new System.Drawing.Size(100, 26);
            this.textBoxIF.TabIndex = 1;
            // 
            // textBoxVW
            // 
            this.textBoxVW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVW.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxVW.Location = new System.Drawing.Point(193, 103);
            this.textBoxVW.Name = "textBoxVW";
            this.textBoxVW.Size = new System.Drawing.Size(100, 26);
            this.textBoxVW.TabIndex = 2;
            // 
            // textBoxFP
            // 
            this.textBoxFP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFP.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxFP.Location = new System.Drawing.Point(193, 135);
            this.textBoxFP.Name = "textBoxFP";
            this.textBoxFP.Size = new System.Drawing.Size(100, 26);
            this.textBoxFP.TabIndex = 3;
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
            // groupBoxOut
            // 
            this.groupBoxOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOut.Controls.Add(this.labelWidth);
            this.groupBoxOut.Controls.Add(this.labelDepth);
            this.groupBoxOut.Controls.Add(this.textBoxWidth);
            this.groupBoxOut.Controls.Add(this.textBoxDepth);
            this.groupBoxOut.Location = new System.Drawing.Point(568, 309);
            this.groupBoxOut.Name = "groupBoxOut";
            this.groupBoxOut.Size = new System.Drawing.Size(304, 112);
            this.groupBoxOut.TabIndex = 8;
            this.groupBoxOut.TabStop = false;
            this.groupBoxOut.Text = "Выходные параметры";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelWidth.Location = new System.Drawing.Point(22, 74);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(102, 20);
            this.labelWidth.TabIndex = 5;
            this.labelWidth.Text = "Ширина шва";
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelDepth.Location = new System.Drawing.Point(22, 42);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(106, 20);
            this.labelDepth.TabIndex = 4;
            this.labelDepth.Text = "Глубина шва";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWidth.ForeColor = System.Drawing.Color.DarkCyan;
            this.textBoxWidth.Location = new System.Drawing.Point(193, 71);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 26);
            this.textBoxWidth.TabIndex = 1;
            // 
            // textBoxDepth
            // 
            this.textBoxDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDepth.ForeColor = System.Drawing.Color.DarkCyan;
            this.textBoxDepth.Location = new System.Drawing.Point(193, 39);
            this.textBoxDepth.Name = "textBoxDepth";
            this.textBoxDepth.Size = new System.Drawing.Size(100, 26);
            this.textBoxDepth.TabIndex = 0;
            // 
            // groupBoxPrediction
            // 
            this.groupBoxPrediction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPrediction.Controls.Add(this.labelWidthPrediction);
            this.groupBoxPrediction.Controls.Add(this.labelDepthPrediction);
            this.groupBoxPrediction.Controls.Add(this.textBoxWidthPrediction);
            this.groupBoxPrediction.Controls.Add(this.textBoxDepthPrediction);
            this.groupBoxPrediction.Location = new System.Drawing.Point(568, 427);
            this.groupBoxPrediction.Name = "groupBoxPrediction";
            this.groupBoxPrediction.Size = new System.Drawing.Size(304, 112);
            this.groupBoxPrediction.TabIndex = 9;
            this.groupBoxPrediction.TabStop = false;
            this.groupBoxPrediction.Text = "Прогноз";
            // 
            // labelWidthPrediction
            // 
            this.labelWidthPrediction.AutoSize = true;
            this.labelWidthPrediction.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelWidthPrediction.Location = new System.Drawing.Point(22, 74);
            this.labelWidthPrediction.Name = "labelWidthPrediction";
            this.labelWidthPrediction.Size = new System.Drawing.Size(102, 20);
            this.labelWidthPrediction.TabIndex = 5;
            this.labelWidthPrediction.Text = "Ширина шва";
            // 
            // labelDepthPrediction
            // 
            this.labelDepthPrediction.AutoSize = true;
            this.labelDepthPrediction.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelDepthPrediction.Location = new System.Drawing.Point(22, 42);
            this.labelDepthPrediction.Name = "labelDepthPrediction";
            this.labelDepthPrediction.Size = new System.Drawing.Size(106, 20);
            this.labelDepthPrediction.TabIndex = 4;
            this.labelDepthPrediction.Text = "Глубина шва";
            // 
            // textBoxWidthPrediction
            // 
            this.textBoxWidthPrediction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWidthPrediction.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxWidthPrediction.Location = new System.Drawing.Point(193, 71);
            this.textBoxWidthPrediction.Name = "textBoxWidthPrediction";
            this.textBoxWidthPrediction.Size = new System.Drawing.Size(100, 26);
            this.textBoxWidthPrediction.TabIndex = 1;
            // 
            // textBoxDepthPrediction
            // 
            this.textBoxDepthPrediction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDepthPrediction.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxDepthPrediction.Location = new System.Drawing.Point(193, 39);
            this.textBoxDepthPrediction.Name = "textBoxDepthPrediction";
            this.textBoxDepthPrediction.Size = new System.Drawing.Size(100, 26);
            this.textBoxDepthPrediction.TabIndex = 0;
            // 
            // buttonPrediction
            // 
            this.buttonPrediction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrediction.Location = new System.Drawing.Point(568, 546);
            this.buttonPrediction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPrediction.Name = "buttonPrediction";
            this.buttonPrediction.Size = new System.Drawing.Size(186, 35);
            this.buttonPrediction.TabIndex = 11;
            this.buttonPrediction.Text = "ПРОГНОЗ";
            this.buttonPrediction.UseVisualStyleBackColor = true;
            this.buttonPrediction.Click += new System.EventHandler(this.buttonPrediction_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 595);
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
    }
}

