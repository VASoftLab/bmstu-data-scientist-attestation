using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeldingPredictor
{
    public partial class FormMain : Form
    {
        private ApplicationSettings appSet;
        private List<WeldingDataItem> dataSet;
        public FormMain()
        {
            InitializeComponent();

            appSet = new ApplicationSettings();
            dataSet = new List<WeldingDataItem>();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Загрузка файла настроек
            appSet.Load();
            textBoxPathToModel.Text = appSet.PathToModel;
            textBoxPathToData.Text = appSet.PathToData;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLoadModel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Path.GetDirectoryName(appSet.PathToModel);
                openFileDialog.Filter = "ONNX models (*.onnx)|*.onnx|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxPathToModel.Text = openFileDialog.FileName;
                    appSet.PathToModel = textBoxPathToModel.Text;
                    appSet.Save();
                }
            }
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Path.GetDirectoryName(appSet.PathToData);
                openFileDialog.Filter = "CSV models (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxPathToData.Text = openFileDialog.FileName;
                    appSet.PathToData = textBoxPathToData.Text;
                    appSet.Save();
                    // Загрузка данных
                    LoadData();
                }
            }
        }
        /// <summary>
        /// Загрузка данных из CSV-файла
        /// </summary>
        private void LoadData()
        {
            dataSet.Clear();
            string[] data = System.IO.File.ReadAllLines(appSet.PathToData);
            
            bool first = true;
            
            foreach (string line in data)
            {
                if (first)
                {
                    first = false;
                    continue;
                }

                try
                {
                    string[] item = line.Split(',');

                    if (item.Length == 6)
                    {
                        float.TryParse(item[0], out float IW);
                        float.TryParse(item[1], out float IF);
                        float.TryParse(item[2], out float VW);
                        float.TryParse(item[3], out float FP);
                        float.TryParse(item[4], out float Depth);
                        float.TryParse(item[5], out float Width);

                        dataSet.Add(new WeldingDataItem()
                        {
                            IW = IW,
                            IF = IF,
                            VW = VW,
                            FP = FP,
                            Depth = Depth,
                            Width = Width
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    break;
                }
            }

            bindingSource.DataSource = dataSet;
        }

        private void buttonPrediction_Click(object sender, EventArgs e)
        {
            ;
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                string IW = row.Cells[0].Value.ToString();
                string IF = row.Cells[1].Value.ToString();
                string VW = row.Cells[2].Value.ToString();
                string FP = row.Cells[3].Value.ToString();
                string Depth = row.Cells[4].Value.ToString();
                string Width = row.Cells[5].Value.ToString();
                
                if (!String.IsNullOrEmpty(IW) &&
                    !String.IsNullOrEmpty(IF) &&
                    !String.IsNullOrEmpty(VW) &&
                    !String.IsNullOrEmpty(FP) &&
                    !String.IsNullOrEmpty(Depth) &&
                    !String.IsNullOrEmpty(Width))
                {
                    textBoxIW.Text = IW;
                    textBoxIF.Text = IF;
                    textBoxVW.Text = VW;
                    textBoxFP.Text = FP;
                    textBoxDepth.Text = Depth;
                    textBoxWidth.Text = Width;
                }
            }
        }
    }
}
