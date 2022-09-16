﻿using System;
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
        string testString;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Button Pressed");

            // Store values for swap
            TextBlock tb1 = (TextBlock)FindName("LeftText");
            TextBlock tb2 = (TextBlock)FindName("RightText");
            TextBox box1 = (TextBox)FindName("BoxLeft");
            TextBox box2 = (TextBox)FindName("BoxRight");


            String tempText = tb1.Text;
            tb1.Text = tb2.Text;
            tb2.Text = tempText;
            //MessageBox.Show(s1);

        }

        private void TextBox_TextChangedL(object sender, TextChangedEventArgs e)
        {
            TextBox box = (TextBox)sender;
            //MessageBox.Show("Text Changed to \"" + box.Text + "\"");
        }

        private void TextBox_TextChangedR(object sender, TextChangedEventArgs e)
        {
            TextBox box = (TextBox)sender;
            //MessageBox.Show("Text Changed to \"" + box.Text + "\"");
        }
    }
}
