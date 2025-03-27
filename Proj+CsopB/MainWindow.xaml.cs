using System;  
using System.Windows;  
using System.Windows.Media;  

namespace CarCostCalculator  
{  
    public partial class MainWindow : Window  
    {  
        public MainWindow()  
        {  
            InitializeComponent();  
        }  

        private void CalculateButton_Click(object sender, RoutedEventArgs e)  
        {  
            try  
            {  
                double distance = double.Parse(DistanceTextBox.Text);  
                double consumption = double.Parse(ConsumptionTextBox.Text);  
                double fuelPrice = double.Parse(FuelPriceTextBox.Text);  
                bool hasToll = TollCheckBox.IsChecked == true;  

                double cost = (distance / 100) * consumption * fuelPrice;  
                if (hasToll)  
                {  
                    cost += 3500;   
                    this.Background = Brushes.Yellow;   
                }  
                else  
                {  
                    this.Background = Brushes.White;   
                }  

                ResultTextBlock.Text = $"Teljes költség: {cost:F2} Ft";  
            }  
            catch (FormatException)  
            {  
                MessageBox.Show("Kérjük, érvényes számokat adjon meg!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);  
            }  
        }  

        private void DistanceTextBox_LostFocus(object sender, RoutedEventArgs e)  
        {  
            ValidateInput(DistanceTextBox);  
        }  

        private void ConsumptionTextBox_LostFocus(object sender, RoutedEventArgs e)  
        {  
            ValidateInput(ConsumptionTextBox);  
        }  

        private void FuelPriceTextBox_LostFocus(object sender, RoutedEventArgs e)  
        {  
            ValidateInput(FuelPriceTextBox);  
        }  

        private void ValidateInput(TextBox textBox)  
        {  
            if (string.IsNullOrWhiteSpace(textBox.Text) || !double.TryParse(textBox.Text, out _))  
            {  
                textBox.BorderBrush = Brushes.Red;   
                MessageBox.Show("Kérjük, érvényes számot adjon meg!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Warning);  
            }  
            else  
            {  
                textBox.BorderBrush = Brushes.Gray;   
            }  
        }  
    }  
}  