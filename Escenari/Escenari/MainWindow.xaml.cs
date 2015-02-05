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

namespace Escenari
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnInici_Click(object sender, RoutedEventArgs e)
        {
            if (txtFiles.Text == "" || txtColumnes.Text == "")
            {
                MessageBox.Show("Tens que omplir tots els requadres", "ERROR!!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {

                int files = Convert.ToInt32(txtFiles.Text);
                int columnes = Convert.ToInt32(txtColumnes.Text);

                if (files > 1 && columnes > 1)
                {
                    Window wnd = new EscenariFesta(files, columnes);
                    wnd.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tens que omplir tots els requadres", "ERROR!!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void StackPanel_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int result;
            if (!Int32.TryParse(e.Text, out result))
            {
                e.Handled = true;
            }
        }

    }
}
