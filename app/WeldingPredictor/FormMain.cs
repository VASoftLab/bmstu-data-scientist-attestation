using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.ML;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
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
            buttonFullPrediction.Enabled = true;
        }

        private void buttonPrediction_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            labelStatistic.Enabled = false;
            labelDepthStat.Enabled = false;
            labelWidthStat.Enabled = false;

            labelMAE.Enabled = false;            
            labelMSE.Enabled = false;
            labelRMSE.Enabled = false;            
            labelR2.Enabled = false;
            labelMAPE.Enabled = false;

            textBoxMAEDepth.Enabled = false;
            textBoxMSEDepth.Enabled = false;
            textBoxRMSEDepth.Enabled = false;
            textBoxR2Depth.Enabled = false;
            textBoxMAPEDepth.Enabled = false;

            textBoxMAEWidth.Enabled = false;
            textBoxMSEWidth.Enabled = false;
            textBoxRMSEWidth.Enabled = false;
            textBoxR2Width.Enabled = false;
            textBoxMAPEWidth.Enabled = false;

            textBoxMAEDepth.Text = string.Empty;
            textBoxMSEDepth.Text = string.Empty;
            textBoxRMSEDepth.Text = string.Empty;
            textBoxR2Depth.Text = string.Empty;
            textBoxMAPEDepth.Text = string.Empty;

            textBoxMAEWidth.Text = string.Empty;
            textBoxMSEWidth.Text = string.Empty;
            textBoxRMSEWidth.Text = string.Empty;
            textBoxR2Width.Text = string.Empty;
            textBoxMAPEWidth.Text = string.Empty;

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
                                float deltaDepth = 100 * Math.Abs((DepthPrediction - Depth) / Depth);
                                float deltaWidth = 100 * Math.Abs((WidthPrediction - Width) / Width);
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

        private async Task<Tuple<float, float>> RunPrediction(InferenceSession session, float IW, float IF, float VW, float FP)
        {
            float DepthPrediction = 0.0f;
            float WidthPrediction = 0.0f;

            await Task.Run(() =>
            {
                try
                {
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

                                float.TryParse(values[0].ToString(), out DepthPrediction);
                                float.TryParse(values[1].ToString(), out WidthPrediction);

                                Thread.Sleep(100);                                
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show(ex.Message);
                }
            });

            return new Tuple<float, float>(DepthPrediction, WidthPrediction);
        }

        private async void buttonFullPrediction_Click(object sender, EventArgs e)
        {
            labelDeltaDepth.Visible = false;
            labelDeltaWidth.Visible = false;

            labelStatistic.Enabled = false;
            labelDepthStat.Enabled = false;
            labelWidthStat.Enabled = false;

            labelMAE.Enabled = false;
            labelMSE.Enabled = false;
            labelRMSE.Enabled = false;
            labelR2.Enabled = false;
            labelMAPE.Enabled = false;

            textBoxMAEDepth.Enabled = false;
            textBoxMSEDepth.Enabled = false;
            textBoxRMSEDepth.Enabled = false;
            textBoxR2Depth.Enabled = false;
            textBoxMAPEDepth.Enabled = false;

            textBoxMAEWidth.Enabled = false;
            textBoxMSEWidth.Enabled = false;
            textBoxRMSEWidth.Enabled = false;
            textBoxR2Width.Enabled = false;
            textBoxMAPEWidth.Enabled = false;

            int N = dataSet.Count;

            progressBar.Minimum = 0;
            progressBar.Maximum = N - 1;
            progressBar.Step = 1;

            Cursor.Current = Cursors.WaitCursor;

            StatisticalData statDepth = new StatisticalData();
            StatisticalData statWidth = new StatisticalData();

            // Созднаие сессии для работы с моделью
            var session = new InferenceSession(appSet.PathToModel);
            progressBar.PerformStep();
            progressBar.PerformStep();
            progressBar.PerformStep();
            progressBar.PerformStep();
            progressBar.PerformStep();

            for (int index = 0; index < N; index++)
            {
                
                dataGridView.Rows[index].Selected = true;
                dataGridView.FirstDisplayedScrollingRowIndex = index;

                float.TryParse(textBoxIW.Text, out float IW);
                float.TryParse(textBoxIF.Text, out float IF);
                float.TryParse(textBoxVW.Text, out float VW);
                float.TryParse(textBoxFP.Text, out float FP);

                float.TryParse(textBoxDepth.Text, out float Depth);
                float.TryParse(textBoxWidth.Text, out float Width);

                var prediction = await RunPrediction(session, IW, IF, VW, FP);

                textBoxDepthPrediction.Text = prediction.Item1.ToString("0.00");
                textBoxWidthPrediction.Text = prediction.Item2.ToString("0.00");

                statDepth.Y.Add(Depth);
                statDepth.A.Add(prediction.Item1);

                statWidth.Y.Add(Width);
                statWidth.A.Add(prediction.Item2);
                progressBar.PerformStep();
            }

            progressBar.Value = 0;

            statDepth.Calculate();
            statWidth.Calculate();

            labelStatistic.Enabled = true;
            labelDepthStat.Enabled = true;
            labelWidthStat.Enabled = true;

            labelMAE.Enabled = true;
            labelMSE.Enabled = true;
            labelRMSE.Enabled = true;
            labelR2.Enabled = true;
            labelMAPE.Enabled = true;

            textBoxMAEDepth.Enabled = true;
            textBoxMSEDepth.Enabled = true;
            textBoxRMSEDepth.Enabled = true;
            textBoxR2Depth.Enabled = true;
            textBoxMAPEDepth.Enabled = true;

            textBoxMAEWidth.Enabled = true;
            textBoxMSEWidth.Enabled = true;
            textBoxRMSEWidth.Enabled = true;
            textBoxR2Width.Enabled = true;
            textBoxMAPEWidth.Enabled = true;

            textBoxMAEDepth.Text = statDepth.MAE.ToString("0.00");
            textBoxMSEDepth.Text = statDepth.MSE.ToString("0.0000");
            textBoxRMSEDepth.Text = statDepth.RMSE.ToString("0.00");
            textBoxR2Depth.Text = statDepth.R2.ToString("0.00");
            textBoxMAPEDepth.Text = statDepth.MAPE.ToString("0.00") + "%";

            textBoxMAEWidth.Text = statWidth.MAE.ToString("0.00");
            textBoxMSEWidth.Text = statWidth.MSE.ToString("0.0000");
            textBoxRMSEWidth.Text = statWidth.RMSE.ToString("0.00");
            textBoxR2Width.Text = statWidth.R2.ToString("0.00");
            textBoxMAPEWidth.Text = statWidth.MAPE.ToString("0.00") + "%";

            Cursor.Current = Cursors.Default;
        }
    }
}
