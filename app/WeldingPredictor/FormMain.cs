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

using Microsoft.ML;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;

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
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                // Созднаие сессии для работы с моделью
                var session = new InferenceSession(appSet.PathToModel);
                // Получаем информацию о входных и выходных слоях модели
                var inputMeta = session.InputMetadata;
                var outputMeta = session.OutputMetadata;
                // Определяем вектор входных переменных
                float.TryParse(textBoxIW.Text, out float IW);
                float.TryParse(textBoxIF.Text, out float IF);
                float.TryParse(textBoxVW.Text, out float VW);
                float.TryParse(textBoxFP.Text, out float FP);

                if (IW == 0 && IF == 0 && VW == 0 && FP == 0)
                {
                    MessageBox.Show("Проверьте правильность ввода данных!", "Ошибка", buttons: MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Задаем конфигурацию входного тензора
                var inputTensor = new DenseTensor<float>(new int[] { 1, 4 });
                inputTensor.SetValue(0, IW);
                inputTensor.SetValue(1, IF);
                inputTensor.SetValue(2, VW);
                inputTensor.SetValue(3, FP);
                // Создание именнованого тензора для передачи в модель
                var normalization_input = NamedOnnxValue.CreateFromTensor("normalization_input", inputTensor);
                var inputs = new List<NamedOnnxValue>() { normalization_input };
                // Запуск модели
                using (var outputs = session.Run(inputs))
                {
                    foreach (var output in outputs)
                    {
                        // Ищем выходной слой dense_2
                        if (output.Name == "dense_2")
                        {
                            // Считываем тензор с данными
                            DenseTensor<float> denseTensor = output.AsTensor<float>().ToDenseTensor();
                            // Парсим данные
                            var values = new float[denseTensor.Length];
                            denseTensor.Buffer.CopyTo(values);
                            try
                            {
                                // Выводим результат в текстовые поля
                                textBoxDepthPrediction.Text = values[0].ToString("0.00");
                                textBoxWidthPrediction.Text = values[1].ToString("0.00");

                                // Расчет относительной погрешности
                                float.TryParse(textBoxDepth.Text, out float Depth);
                                float.TryParse(textBoxWidth.Text, out float Width);

                                float.TryParse(textBoxDepthPrediction.Text, out float DepthPrediction);
                                float.TryParse(textBoxWidthPrediction.Text, out float WidthPrediction);

                                // Расчет относительной ошибки предсказания
                                float deltaDepth = 100*Math.Abs((DepthPrediction - Depth) / Depth);
                                float deltaWidth = 100* Math.Abs((WidthPrediction - Width) / Width);
                                labelDeltaDepth.Visible = true;
                                labelDeltaWidth.Visible = true;
                                labelDeltaDepth.Text = $"{deltaDepth.ToString("0.00")}%";
                                labelDeltaWidth.Text = $"{deltaWidth.ToString("0.00")}%";

                            }
                            catch (Exception ex)
                            {
                                Cursor.Current = Cursors.Default;
                                MessageBox.Show(ex.Message);
                            }
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
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
