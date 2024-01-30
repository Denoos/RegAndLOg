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
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string PasswordIsChecked { get; set; }
        public bool IsChecked { get; set; }
        List<string> Saves = new();
        public Reg()
        {
            InitializeComponent();
            DataContext = this;
        }

        private static Reg instance;
        public static Reg getInstance()
        {
            if (instance == null)
                instance = new Reg();
            return instance;
        }

        private void Signed_Up(object sender, RoutedEventArgs e)
        {
            if (Password == PasswordIsChecked && IsChecked == true)
            {
                Saves.Add(Login);
                Saves.Add(Password);
                MessageBox.Show("Вы успешно загестрировались w"+Login); 
             MessageBox.Show(Login, Password); }
            else MessageBox.Show("Пересмотрите свои взгляды и переделайте правильно!!!!");
        }
    }
}
