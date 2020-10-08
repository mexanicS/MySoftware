using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Мeasure
{
    /// <summary>
    /// Логика взаимодействия для DataWindow1.xaml
    /// </summary>
    public partial class DataWindow1 : Window
    {
        // CartesianChart ch = new CartesianChart();

        public event EventHandler ButtonClicked;// событие нажатия клавиши

        public DataWindow1()
        {
            InitializeComponent();

          /*  ch.Series = new SeriesCollection
            {
           new LineSeries
             {
              Title = "Series 1",
              Values = new ChartValues<double> { 1, 1, 2, 3 ,5 }
             }
            };*/
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)//нажатие на кнопку
        {
            string a = NormalizedTemperature.Text;
            int NT = Convert.ToInt32(a);

            string b = DesignTemperature.Text;
            int DT = Convert.ToInt32(b);

            string c = ThermalConductivity1.Text;
            int TC1 = Convert.ToInt32(c);

            string d = ThermalConductivity2.Text;
            int TC2 = Convert.ToInt32(d);

            string f = LayerThickness1.Text;
            int LT1 = Convert.ToInt32(f);

            string g = LayerThickness2.Text;
            int LT2 = Convert.ToInt32(g);

            string h = TransmissionResistance.Text;
            int TrR = Convert.ToInt32(h);

            string j = HeatTransferCoefficientInside.Text;
            int HTCI = Convert.ToInt32(j);

            string k = HeatTransferCoefficientOutside.Text;
            int HTCO = Convert.ToInt32(k);

            string l = ThermalResistance.Text;
            int ThR = Convert.ToInt32(l);

            string m = ThermalResistanceClosedAirLayer.Text;
            int TRCAL = Convert.ToInt32(m);

            this.Close();

            /*if (ButtonClicked != null)
            {
                this.Close();
                ButtonClicked(this, EventArgs.Empty);//наверное вызываем ивент, но хз
            }*/
        }
    }
}
