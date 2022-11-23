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
        public FormMain()
        {
            InitializeComponent();

            appSet = new ApplicationSettings();
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

                    LoadData();
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
                }
            }
        }

        private void LoadData()
        {
            ;
        }

        private void buttonPrediction_Click(object sender, EventArgs e)
        {
            ;
        }
    }
}
