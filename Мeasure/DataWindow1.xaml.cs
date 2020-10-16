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
        public double NT,DT, TC1, TC2, LT1, LT2, TrR, HTCI, HTCO, ThR, TRCAL;
        public void NormalizedTemperature_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (NormalizedTemperature.Text.Length > 0)
            {
                AddLayer.IsEnabled = true;
            }
            if (double.TryParse(NormalizedTemperature.Text, out NT) || string.IsNullOrEmpty(NormalizedTemperature.Text))
            {
                NormalizedTemperature.Background = Brushes.White;
            }
            else
            {
                NormalizedTemperature.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
                AddLayer.IsEnabled = false;
            }
        }

        public void DesignTemperature_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (DesignTemperature.Text.Length > 0)
            {
                AddLayer.IsEnabled = true;
            }
            if (double.TryParse(DesignTemperature.Text, out DT) || string.IsNullOrEmpty(DesignTemperature.Text))
            {
                DesignTemperature.Background = Brushes.White;
            }
            else
            {
                DesignTemperature.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
                AddLayer.IsEnabled = false;
            }
        }

        public void ThermalConductivity1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ThermalConductivity1.Text.Length > 0)
            {
                AddLayer.IsEnabled = true;
            }
            if (double.TryParse(ThermalConductivity1.Text, out TC1) || string.IsNullOrEmpty(ThermalConductivity1.Text))
            {
                ThermalConductivity1.Background = Brushes.White;
            }
            else
            {
                ThermalConductivity1.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
                AddLayer.IsEnabled = false;
            }
        }

        public void ThermalConductivity2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ThermalConductivity2.Text.Length > 0)
            {
                AddLayer.IsEnabled = true;
            }
            if (double.TryParse(ThermalConductivity2.Text, out TC2) || string.IsNullOrEmpty(ThermalConductivity2.Text))
            {
                ThermalConductivity2.Background = Brushes.White;
            }
            else
            {
                ThermalConductivity2.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
                AddLayer.IsEnabled = false;
            }
        }

        public void LayerThickness1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (LayerThickness1.Text.Length > 0)
            {
                AddLayer.IsEnabled = true;
            }
            if (double.TryParse(LayerThickness1.Text, out LT1) || string.IsNullOrEmpty(LayerThickness1.Text))
            {
                LayerThickness1.Background = Brushes.White;
            }
            else
            {
                LayerThickness1.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
                AddLayer.IsEnabled = false;
            }
        }

        public void LayerThickness2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (LayerThickness2.Text.Length > 0)
            {
                AddLayer.IsEnabled = true;
            }
            if (double.TryParse(LayerThickness2.Text, out LT2) || string.IsNullOrEmpty(LayerThickness2.Text))
            {
                LayerThickness2.Background = Brushes.White;
            }
            else
            {
                LayerThickness2.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
                AddLayer.IsEnabled = false;
            }
        }

        public void TransmissionResistance_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TransmissionResistance.Text.Length > 0)
            {
                AddLayer.IsEnabled = true;
            }
            if (double.TryParse(TransmissionResistance.Text, out TrR) || string.IsNullOrEmpty(TransmissionResistance.Text))
            {
                TransmissionResistance.Background = Brushes.White;
            }
            else
            {
                TransmissionResistance.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
                AddLayer.IsEnabled = false;
            }
        }

        public void HeatTransferCoefficientInside_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (HeatTransferCoefficientInside.Text.Length > 0)
            {
                AddLayer.IsEnabled = true;
            }
            if (double.TryParse(HeatTransferCoefficientInside.Text, out HTCI) || string.IsNullOrEmpty(HeatTransferCoefficientInside.Text))
            {
                HeatTransferCoefficientInside.Background = Brushes.White;
            }
            else
            {
                HeatTransferCoefficientInside.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
                AddLayer.IsEnabled = false;
            }
        }

        public void HeatTransferCoefficientOutside_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (HeatTransferCoefficientOutside.Text.Length > 0)
            {
                AddLayer.IsEnabled = true;
            }
            if (double.TryParse(HeatTransferCoefficientOutside.Text, out HTCO) || string.IsNullOrEmpty(HeatTransferCoefficientOutside.Text))
            {
                HeatTransferCoefficientOutside.Background = Brushes.White;
            }
            else
            {
                HeatTransferCoefficientOutside.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
                AddLayer.IsEnabled = false;
            }
        }

        public void ThermalResistance_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ThermalResistance.Text.Length > 0)
            {
                AddLayer.IsEnabled = true;
            }
            if (double.TryParse(ThermalResistance.Text, out ThR) || string.IsNullOrEmpty(ThermalResistance.Text))
            {
                ThermalResistance.Background = Brushes.White;
            }
            else
            {
                ThermalResistance.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
                AddLayer.IsEnabled = false;
            }
           // MessageBox.Show("HELLO", ThR);
        }

        public void ThermalResistanceClosedAirLayer_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ThermalResistanceClosedAirLayer.Text.Length > 0)
            {
                AddLayer.IsEnabled = true;
            }
            if (double.TryParse(ThermalResistanceClosedAirLayer.Text, out TRCAL) || string.IsNullOrEmpty(ThermalResistanceClosedAirLayer.Text))
            {
                ThermalResistanceClosedAirLayer.Background = Brushes.White;
            }
            else
            {
                ThermalResistanceClosedAirLayer.Background = new SolidColorBrush(Color.FromArgb(100, 250, 182, 182));
                AddLayer.IsEnabled = false;
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
;       }
    }
   
}
