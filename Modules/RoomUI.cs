using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace diploma_216273.Modules
{
    public class RoomUI
    {
        public Label LabelTemp { get; set; }
        public Label LabelHum { get; set; }
        public Label LabelHeaterState { get; set; }
        public Label LabelVentState { get; set; }
        public Chart Chart { get; set; }
    }
}
