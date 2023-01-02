using Microsoft.Win32;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace bang
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            mediaElement.Position = TimeSpan.FromMilliseconds(1);
            mediaElement.Play();
        }
        private void MediaElement_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Themes test";
            openFileDialog.Filter = "Media files|*.mp3;*.mp4;*.avi*.png;*.jpg;*.gif";


            if (openFileDialog.ShowDialog() == true)
            {
             
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "XeRon | Change Theme";
            openFileDialog.Filter = "Media files|*.mp3;*.mp4;*.avi*.png;*.jpg;*.gif";


            if (openFileDialog.ShowDialog() == true)
            {

                mediaElement.Source = new Uri(openFileDialog.FileName);
                mediaElement.Play();
            }
        }

        private void Close_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    this.DragMove();
                }
            }
        }

        private void Minimize_Click_1(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Clear_click(object sender, RoutedEventArgs e)
        {
          MessageBoxResult result = MessageBox.Show("Are u sure u want to clear the content of this tab?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            switch (result)
            {
                case MessageBoxResult.Yes:
                            GAY.Text = "";
                    break;
                case MessageBoxResult.No:
                    break;
            }

        }

        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
                saveFileDialog.Title = "XeRon | Save Script";
                saveFileDialog.DefaultExt = ".lua";
                saveFileDialog.Filter = "(*.txt)|*.txt|All Files (*.*)|*.*";
                Microsoft.Win32.SaveFileDialog SaveDialog = saveFileDialog;
                SaveDialog.ShowDialog();



                SaveDialog = (Microsoft.Win32.SaveFileDialog)null;
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("meh");
            }
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog1 = new Microsoft.Win32.OpenFileDialog();
            Microsoft.Win32.OpenFileDialog openFileDialog2 = new Microsoft.Win32.OpenFileDialog();
            openFileDialog2.Title = "XeRon | Open File";
            openFileDialog2.DefaultExt = ".txt";
            openFileDialog2.Filter = "Scripts (*.lua; *.txt)|*.lua;*.txt|All Files (*.*)|*.*";
            Microsoft.Win32.OpenFileDialog openFileDialog3 = openFileDialog2;
            bool? nullable = openFileDialog3.ShowDialog();
            bool flag2 = true;
            if (!(nullable.GetValueOrDefault() == flag2 & nullable.HasValue))
                return;
            GAY.Text = (System.IO.File.ReadAllText(openFileDialog3.FileName));
        
        }
    }
}

