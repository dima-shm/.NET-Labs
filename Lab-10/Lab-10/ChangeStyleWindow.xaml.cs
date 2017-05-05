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

namespace Lab_10
{
    /// <summary>
    /// Логика взаимодействия для ChangeStyleWindow.xaml
    /// </summary>
    public partial class ChangeStyleWindow : Window
    {
        MainWindow mainWnd;
        public ChangeStyleWindow(MainWindow _mainWnd)
        {
            InitializeComponent();

            cmbChangeStyle.ItemsSource = new List<string>() { "Cyan", "White", "Dark" };
            mainWnd = _mainWnd;
        }

        private void cmbChangeStyle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbChangeStyle.SelectedItem.ToString() == "Cyan")
            {
                this.Resources["windowStyle"] = new SolidColorBrush(Colors.Cyan);
                mainWnd.Resources["windowStyle"] = new SolidColorBrush(Colors.Cyan);
            }
            else if (cmbChangeStyle.SelectedItem.ToString() == "White")
            {
                this.Resources["windowStyle"] = new SolidColorBrush(Colors.White);
                mainWnd.Resources["windowStyle"] = new SolidColorBrush(Colors.White);
            }
            else if (cmbChangeStyle.SelectedItem.ToString() == "Dark")
            {
                this.Resources["windowStyle"] = new SolidColorBrush(Colors.DarkGray);
                mainWnd.Resources["windowStyle"] = new SolidColorBrush(Colors.DarkGray);
            }
        }
    }
}
