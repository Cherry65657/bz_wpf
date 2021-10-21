using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace bz_wpf
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int i = 0;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.me.Source = new Uri(VideoFile.videof[i]);
            

        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            
            this.btn.Margin = new Thickness(1510, 0, 0, 0);
            this.mune.IsOpen = true;
            

        }

        private void mune_Opened(object sender, EventArgs e)
        {

            this.btn.Visibility = Visibility.Collapsed;

        }

        private void mune_Closed(object sender, EventArgs e)
        {
            this.btn.Margin = new Thickness(1910, 0, 0, 0);
            this.btn.Visibility = Visibility.Visible;
        }

        private void p_btn_Click(object sender, RoutedEventArgs e)
        {
            nsunews nn = new nsunews();
            nn.Show();
        }

        private void me_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (i > VideoFile.videof.Length) {
                i = 0;
            }
            i += 1;
            this.me.Source = new Uri(VideoFile.videof[i]);
            
        }

        private void p_btn1_Click(object sender, RoutedEventArgs e)
        {
            Process pro = new Process();
            ProcessStartInfo proinfo = new ProcessStartInfo(LnkRend.GetLnkRend()[0]);
            pro.StartInfo = proinfo;
            pro.Start();
        }   
    }
}
