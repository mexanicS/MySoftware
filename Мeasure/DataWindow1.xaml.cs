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
            this.Close();

            /*if (ButtonClicked != null)
            {
                this.Close();
                ButtonClicked(this, EventArgs.Empty);//наверное вызываем ивент, но хз
            }*/
        }
    }
}
