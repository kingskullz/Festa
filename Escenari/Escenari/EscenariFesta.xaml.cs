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

namespace Escenari
{
    /// <summary>
    /// Lógica de interacción para Escenari.xaml
    /// </summary>
    public partial class EscenariFesta : Window
    {
        public EscenariFesta(int files, int columnes)
        {
            InitializeComponent();
            ugEsenari.Rows = files;
            ugEsenari.Columns = columnes;

            OmpleDades(files * columnes);

        }

        private void OmpleDades(int quantitat)
        {
            List<Button> buttons = new List<Button>();

            for (int i = 0; i < quantitat; i++)
            {
                Button btn = new Button();
                btn.Content = i;
                buttons.Add(btn);
            }

            OmpleGraella(buttons);
        }

        private void OmpleGraella(List<Button> buttons)
        {
            foreach (Button b in buttons)
            { 
                ugEsenari.Children.Add(b); 
            }
        }
    }
}
