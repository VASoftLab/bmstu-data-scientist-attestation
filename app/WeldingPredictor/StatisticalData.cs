using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeldingPredictor
{
    public class StatisticalData
    {
        public List<float> A { get; set; }
        public List<float> Y { get; set; }
        public float meanY { get; set; }
        public float MAE { get; set; }
        public float MSE { get; set; }
        public float RMSE { get; set; }
        public float R2 { get; set; }
        public float MAPE { get; set; }

        public StatisticalData()
        {
            A = new List<float>();
            Y = new List<float>();
            
            meanY = 0.0f;

            MAE = 0.0f;
            MSE = 0.0f;
            RMSE = 0.0f;
            R2 = 0.0f;
            MAPE = 0.0f;
        }

        public void Calculate()
        {
            meanY = Y.Average();

            MAE = CalculateMAE();
            MSE = CalculateMSE();
            RMSE = CalculateRMSE();
            R2 = CalculateR2();
            MAPE = CalculateMAPE();
        }

        float CalculateMAE()
        {
            int m = A.Count;
            float sum = 0.0f;
            
            for (int i = 0; i < m; i++)
                sum += Math.Abs(A[i] - Y[i]);
            
            return sum / m;
        }
        float CalculateMSE()
        {
            int m = A.Count;
            float sum = 0.0f;
            
            for (int i = 0; i < m; i++)
                sum += (A[i] - Y[i]) * (A[i] - Y[i]);
            
            return sum / m;
        }
        float CalculateRMSE()
        {
            float mse = CalculateMSE();
            return (float)Math.Sqrt(mse);
        }
        float CalculateR2()
        {
            int m = A.Count;
            float num = 0.0f;
            float den = 0.0f;
            float Yavg = Y.Average();

            for (int i = 0; i < m; i++)
            {
                num += (A[i] - Y[i]) * (A[i] - Y[i]);
                den += (Yavg - Y[i]) * (Yavg - Y[i]);
            }

            return 1 - num / den;
        }
        float CalculateMAPE()
        {
            int m = A.Count;
            float sum = 0.0f;

            for (int i = 0; i < m; i++)
                sum += Math.Abs(Y[i] - A[i]) / Math.Abs(Y[i]);

            return 100 * sum / m;
        }
    }
}
