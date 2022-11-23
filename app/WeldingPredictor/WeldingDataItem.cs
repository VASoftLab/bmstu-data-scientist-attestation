using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeldingPredictor
{
    [Serializable]
    public class WeldingDataItem
    {
        public float IW { get; set; }
        public float IF { get; set; }
        public float VW { get; set; }
        public float FP { get; set; }
        public float Depth { get; set; }
        public float Width { get; set; }

        public WeldingDataItem()
        {
            IW = 0.0f;
            IF = 0.0f;
            VW = 0.0f;
            FP = 0.0f;
            Depth = 0.0f;
            Width = 0.0f;
        }

        public WeldingDataItem(float IW, float IF, float VW, float FP, float Depth, float Width)
        {
            this.IW = IW;
            this.IF = IF;
            this.VW = VW;
            this.FP = FP;
            this.Depth = Depth;
            this.Width = Width;
        }
    }
}
