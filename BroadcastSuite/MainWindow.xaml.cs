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

namespace BroadcastSuite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected string BlueTeam, RedTeam;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Button Pressed");

            // Store values for swap
            TextBox box1 = (TextBox)FindName("BoxLeft");
            TextBox box2 = (TextBox)FindName("BoxRight");



            string tempText = box1.Text;
            box1.Text = box2.Text;
            box2.Text = tempText;
            /*box1.Clear();
            box2.Clear();*/
            //MessageBox.Show(s1);

        }

        private void TextBox_TextChangedL(object sender, TextChangedEventArgs e)
        {
            
            TextBox box = (TextBox)sender;
            //TextBlock block = (TextBlock)FindName("LeftText");
            //block.Text = box.Text;
            //MessageBox.Show("Text Changed to \"" + box.Text + "\"");*/
            BlueTeam = box.Text;
        }

        private void TextBox_TextChangedR(object sender, TextChangedEventArgs e)
        {
            TextBox box = (TextBox)sender;
            //TextBlock block = (TextBlock)FindName("RightText");
            //block.Text = box.Text;
            //MessageBox.Show("Text Changed to \"" + box.Text + "\"");
            RedTeam = box.Text;
        }
    }
}
