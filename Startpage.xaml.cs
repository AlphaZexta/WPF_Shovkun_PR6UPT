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

namespace WPF_Shovkun_PR6UPT
{
    /// <summary>
    /// Логика взаимодействия для Startpage.xaml
    /// </summary>
    public partial class Startpage : Page
    {
        public Startpage()
        {
            InitializeComponent();
        }

        private void btnNextpage_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Mainpage());
        }
    }
}
