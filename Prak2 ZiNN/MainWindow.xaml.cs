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

namespace Prak2_ZiNN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int K = Convert.ToInt32(TexA.Text);
            int day = (K % 7);
            if(day==1)
            {
                TexRE.Text += "\n" + "День:" + "Понедельник";
            }
            if (day == 2)
            {
                TexRE.Text += "\n" + "День:" + "Вторник";
            }
            if (day == 3)
            {
                TexRE.Text += "\n" + "День:" + "Среда";
            }
            if  (day == 4)
            {
                TexRE.Text += "\n" + "День:" + "Четверг";
            }
            if (day == 5)
            {
                TexRE.Text += "\n" + "День:" + "Пятница";
            }
            if (day == 6)
            {
                TexRE.Text += "\n" + "День:" + "Суббота";
            }
            if (day == 7)
            {
                TexRE.Text += "\n" + "День:" + "Воскресенье";
            }
        }
    }
}
