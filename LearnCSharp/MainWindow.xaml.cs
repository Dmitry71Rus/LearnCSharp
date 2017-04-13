using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace LearnCSharp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[] array = Array.ConvertAll(System.IO.File.ReadAllLines(@"Arr.txt"), int.Parse);
            int counter = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    counter++;
                }
            }
            MessageBox.Show(counter.ToString() + " элементов массива {" + string.Join(", ", array) + "} больше своих соседей", "Результат");
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int[] array = Array.ConvertAll(System.IO.File.ReadAllLines(@"Arr.txt"), int.Parse);
            int sum = 0;
            foreach (int i in array)
            {
                if (i > array[1])
                {
                    sum += i;
                }
            }
            MessageBox.Show("Сумма элементов, больших чем 2 элемент массива {" + string.Join(", ", array) + "} равна " + sum, "Результат");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int[] array = Array.ConvertAll(System.IO.File.ReadAllLines(@"Arr.txt"), int.Parse);
            int counter = 0;
            foreach (int i in array)
            {
                if (i > array[3])
                {
                    counter++;
                }
            }
            MessageBox.Show(counter + " элементов больше, чем 4 элемент массива {" + string.Join(", ", array) + "}", "Результат");
        }
    }
}
