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

namespace Практическая__6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void IncreaseBy1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Triad firstTriad = new Triad(int.Parse(firstTriad1.Text), int.Parse(secondTriad1.Text), int.Parse(thirdTriad1.Text));
                Triad result = firstTriad.Add();
                firstTriad1.Text = result.First.ToString();
                secondTriad1.Text = result.Second.ToString();
                thirdTriad1.Text = result.Third.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Введите корректные значения!");
            }
            
        }

        private void GetSum_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Triad firstTriad = new Triad(int.Parse(firstTriad1.Text), int.Parse(secondTriad1.Text), int.Parse(thirdTriad1.Text));
                Triad result = firstTriad + int.Parse(inputValue.Text);
                sum.Text = (result.First + result.Second + result.Third).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Введите корректные значения!");
            }
        }

        private void TaskInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Использовать класс Triad (тройка чисел). Разработать операцию инкремента полей " +
               "на 1.Разработать операцию для получения полной суммы триады с числом.", "Задание");
        }

        private void DeveloperInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Харенко Кирилл  ИСП-34", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
