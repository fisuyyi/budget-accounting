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

namespace budget4
{
    /// <summary>
    /// Логика взаимодействия для AddTypes.xaml
    /// </summary>
    public partial class AddTypes : Window
    {
        
        public AddTypes()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
