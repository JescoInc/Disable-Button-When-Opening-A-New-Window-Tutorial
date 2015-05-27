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

namespace DisableButtonTutorial
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

        private void loadButton_Click(object sender, RoutedEventArgs e)
        {
            var subWindow = Window.GetWindow(new SubWindow1());
            //subWindow.Closing += subWindow_Closing;
            subWindow.Closing += (s, ex) => loadButton.IsEnabled = true;
            subWindow.Show();
            loadButton.IsEnabled = false;
        }

        private void subWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loadButton.IsEnabled = true;
        }
    }
}
