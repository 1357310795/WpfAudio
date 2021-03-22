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

namespace WpfAudio
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //AudioController.AudioManager.SetApplicationMute(int.Parse(text1.Text),true);
            //SetAppVolumne.class1.test();
            foreach(Process p in Process.GetProcessesByName("msedge"))
            {
                Console.WriteLine(p.Id);
                AudioController.AudioManager.SetApplicationMute(p.Id, true);
                AudioController.AudioManager.SetApplicationVolume(p.Id, 50);
            }
        }
    }
}
