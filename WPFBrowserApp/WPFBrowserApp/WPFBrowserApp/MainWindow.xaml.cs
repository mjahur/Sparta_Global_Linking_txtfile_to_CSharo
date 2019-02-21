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
using System.IO;

namespace WPFBrowserApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
List<string> comboBoxDataSource = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            storedURLToCombo1();


        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string item = combo1.SelectedItem.ToString();
            brwControl.Navigate(item);
        }

        private void OnKeyPress(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                brwControl.Navigate("https://"+combo1.Text);
                using (StreamWriter w = File.AppendText("C:/Users/Tech-W96a/Engineering26/week6/Day3/Sparta_Global_Linking_txtfile_to_CSharo/WPFBrowserApp/links.txt"))
                {
                    w.WriteLine("https://"+combo1.Text + '\r');

                }
            }
        }
        
        private void storedURLToCombo1()
        {
            string[] readText = File.ReadAllLines("C:/Users/Tech-W96a/Engineering26/week6/Day3/Sparta_Global_Linking_txtfile_to_CSharo/WPFBrowserApp/links.txt");
            for (int i = 0; i < readText.Length; i++)
            {
                combo1.Items.Add(readText[i]); 
            }
            
        }
    }
}
