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

namespace SimpleCalculator_WPF
{
    /// <summary>
    /// Interaction logic for AdditionalTask2.xaml
    /// </summary>
    public partial class AdditionalTask2 : Window
    {
        public AdditionalTask2()
        {
            InitializeComponent();
        }

        private void applyButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = colorsStackPanel.Children.OfType<RadioButton>().FirstOrDefault(rb => rb.IsChecked == true);
            if (radioButton != null)
            {
                currentColorTextBlock.Text = radioButton.Content.ToString();
                currentColorTextBlock.Foreground = SetColor(currentColorTextBlock.Text);
                userTextBox.Foreground = SetColor(currentColorTextBlock.Text);
            }
        }

        private Brush SetColor(string color)
        {
            switch (color)
            {
                case "Красный":
                    return Brushes.Red;
                case "Зелёный":
                    return Brushes.Green;
                case "Синий":
                    return Brushes.Blue;
                default:
                    return Brushes.Black;
            }
        }
    }
}
