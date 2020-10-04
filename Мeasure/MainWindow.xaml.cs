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
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Defaults;// Тимена
using LiveCharts.Wpf;

namespace Мeasure
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       //изменение температуры на графике 
        public ChartValues<ObservablePoint> Temperature_Change_ChartValues { get; set; } 

        //высота и ширина стен
        public ChartValues<ObservablePoint> Height_Width_Wall_ChartValues { get; set; }

        public bool Button_Click1 = false;// пока не помню, потом вспомню

        public MainWindow()
        {
            InitializeComponent();

            //первый график
            Temperature_Change_ChartValues = new ChartValues<ObservablePoint>
            {
            new ObservablePoint(0, 20),
            new ObservablePoint(30, 20),
            new ObservablePoint(55, 38),
            new ObservablePoint(78, 63),
            new ObservablePoint(90, 92),
            new ObservablePoint(100, 92),
            };

            //второй график
            Height_Width_Wall_ChartValues = new ChartValues<ObservablePoint>
            {
            // первая коорд x, вторая y
            new ObservablePoint(30, 100),
            new ObservablePoint(40, 100),
            };

            DataContext = this;

            CartesianChart ch = new CartesianChart();//    зачем? кто знает, уже не помню, нужно разбираться..  
        }

       

        private void MakeButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new DataWindow1().ShowDialog(); // открытие нового окна

            //Chart.Visibility = Visibility.Visible;// делает видимым график

           // DataWindow1 dataWindow1 = new DataWindow1();
           //  dataWindow1.ButtonClicked += DataButton_ButtonClicked;
           //dataWindow1.Show();
        }

       /* private void DataButton_ButtonClicked(object sender, EventArgs e)// ивент, функция нажатия кнопки из DataWindow
        {
            Button_Click1 = true;
            MessageBox.Show("ButtonClicked");
        }
        */
        


    }
}
