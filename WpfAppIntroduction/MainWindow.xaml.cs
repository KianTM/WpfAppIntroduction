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
using WpfAppIntroduction.BIZ;

namespace WpfAppIntroduction
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBIZ classBIZ = new ClassBIZ();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonOpg12_Click(object sender, RoutedEventArgs e)
        {
            listBoxRes.Items.Clear();
            classBIZ.Delopgave12(listBoxRes);
        }

        private void buttonOpg13_Click(object sender, RoutedEventArgs e)
        {
            listBoxRes.Items.Clear();
            classBIZ.Delopgave13(listBoxRes);
        }
    }
}
