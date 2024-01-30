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

namespace RegAnLOg
{
    /// <summary>
    /// Логика взаимодействия для Log.xaml
    /// </summary>
    public partial class Log : Window
    {
        public string LogIN { get; set; }
        public string PasswoRD { get; set; }
        public Log()
        {
            InitializeComponent();
        }
        private void Signed_in(object sender, RoutedEventArgs e)
        {
            var reg = Reg.getInstance();
            List<string> list = reg.GetList();
            //if (reg.Login == LogIN && reg.Password == PasswoRD)
            if (list.Contains(LogIN) && list[list.IndexOf(LogIN) + 1] == PasswoRD )
            {MessageBox.Show("Вы вошли!!! Вам грозит тюремное заключение за просмотр хотсов с пингвинами)))"); }
            else MessageBox.Show("Вы не вошли, но Вам всё равно грозит тюремное заключение за просмотр хотсов с пингвинами)))");
        }
    }
}
