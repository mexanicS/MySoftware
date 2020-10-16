using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    public partial class DataWindow1 : Window
    {
        public DataWindow1()
        {
           InitializeComponent();
        }

        /// <summary>
        /// Создаем переменные 
        /// </summary>
        public double NT;
        public void NormalizedTemperature_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (double.TryParse(NormalizedTemperature.Text, out NT) || string.IsNullOrEmpty(NormalizedTemperature.Text))
            {
                string a = NormalizedTemperature.Text;
                NormalizedTemperature.Background = Brushes.White;
                double NT = Convert.ToDouble(a);
            }
            else
            {
                NormalizedTemperature.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
            }
        }

        private void DesignTemperature_TextChanged(object sender, TextChangedEventArgs e)
        {

            double DT;
            if (double.TryParse(DesignTemperature.Text, out DT) || string.IsNullOrEmpty(DesignTemperature.Text))
            {
                DesignTemperature.Background = Brushes.White;
                
                
            }
            else
            {
                DesignTemperature.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
            }
        }

        private void ThermalConductivity1_TextChanged(object sender, TextChangedEventArgs e)
        {
            double TC1;
            if (double.TryParse(ThermalConductivity1.Text, out TC1) || string.IsNullOrEmpty(ThermalConductivity1.Text))
            {
                ThermalConductivity1.Background = Brushes.White;
            }
            else
            {
                ThermalConductivity1.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
            }
        }

        private void ThermalConductivity2_TextChanged(object sender, TextChangedEventArgs e)
        {
            double TC2;
            if (double.TryParse(ThermalConductivity2.Text, out TC2) || string.IsNullOrEmpty(ThermalConductivity2.Text))
            {
                ThermalConductivity2.Background = Brushes.White;
            }
            else
            {
                ThermalConductivity2.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
            }
        }

        private void LayerThickness1_TextChanged(object sender, TextChangedEventArgs e)
        {
            double LT1;
            if (double.TryParse(LayerThickness1.Text, out LT1) || string.IsNullOrEmpty(LayerThickness1.Text))
            {
                LayerThickness1.Background = Brushes.White;
            }
            else
            {
                LayerThickness1.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
            }
        }

        private void LayerThickness2_TextChanged(object sender, TextChangedEventArgs e)
        {
            double LT2;
            if (double.TryParse(LayerThickness2.Text, out LT2) || string.IsNullOrEmpty(LayerThickness2.Text))
            {
                LayerThickness2.Background = Brushes.White;
            }
            else
            {
                LayerThickness2.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
            }
        }

        private void TransmissionResistance_TextChanged(object sender, TextChangedEventArgs e)
        {
            double TrR;
            if (double.TryParse(TransmissionResistance.Text, out TrR) || string.IsNullOrEmpty(TransmissionResistance.Text))
            {
                TransmissionResistance.Background = Brushes.White;
            }
            else
            {
                TransmissionResistance.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
            }
        }

        private void HeatTransferCoefficientInside_TextChanged(object sender, TextChangedEventArgs e)
        {
            double HTCI;
            if (double.TryParse(HeatTransferCoefficientInside.Text, out HTCI) || string.IsNullOrEmpty(HeatTransferCoefficientInside.Text))
            {
                HeatTransferCoefficientInside.Background = Brushes.White;
            }
            else
            {
                HeatTransferCoefficientInside.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
            }
        }

        private void HeatTransferCoefficientOutside_TextChanged(object sender, TextChangedEventArgs e)
        {
            double HTCO;
            if (double.TryParse(HeatTransferCoefficientOutside.Text, out HTCO) || string.IsNullOrEmpty(HeatTransferCoefficientOutside.Text))
            {
                HeatTransferCoefficientOutside.Background = Brushes.White;
            }
            else
            {
                HeatTransferCoefficientOutside.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
            }
        }

        public void ThermalResistance_TextChanged(object sender, TextChangedEventArgs e)
        {
            double ThR;
            if (double.TryParse(ThermalResistance.Text, out ThR) || string.IsNullOrEmpty(ThermalResistance.Text))
            {
                ThermalResistance.Background = Brushes.White;
            }
            else
            {
                ThermalResistance.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
            }
           // MessageBox.Show("HELLO", ThR);
        }

        private void ThermalResistanceClosedAirLayer_TextChanged(object sender, TextChangedEventArgs e)
        {
            double TRCAL;
            if (double.TryParse(ThermalResistanceClosedAirLayer.Text, out TRCAL) || string.IsNullOrEmpty(ThermalResistanceClosedAirLayer.Text))
            {
                ThermalResistanceClosedAirLayer.Background = Brushes.White;
            }
            else
            {
                ThermalResistanceClosedAirLayer.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataWindow1 datawindow1 = new DataWindow1();
            MessageBox.Show(datawindow1.NormalizedTemperature.Text);
        }
    }
   
}
