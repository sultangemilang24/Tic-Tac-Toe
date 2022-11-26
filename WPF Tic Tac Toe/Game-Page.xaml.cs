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

namespace WPF_Tic_Tac_Toe
{
    /// <summary>
    /// Interaction logic for Game_Page.xaml
    /// </summary>
    public partial class Game_Page : Window
    {
        public Game_Page()
        {
            InitializeComponent();
        }

        private void backButton_clicked(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void settingsButton_Clicked(object sender, RoutedEventArgs e)
        {
            Setting_Page setting_Page = new Setting_Page();
            this.Close();
            setting_Page.Show();
        }
    }
}
