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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int[] array = Array.ConvertAll(System.IO.File.ReadAllLines(@"Arr.txt"), int.Parse);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 25)
                {
                    MessageBox.Show("Номер первого элемента массива {" + string.Join(", ", array) + "} большего 25 равен " + i, "Результат");
                    return;
                }
            }
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int[] array = Array.ConvertAll(System.IO.File.ReadAllLines(@"Arr.txt"), int.Parse);
            if (array[0] > array.Average())
            {
                MessageBox.Show("Первый элемент массива {" + string.Join(", ", array) + "} превосходит среднее значение (" + array.Average() + ") элементов этого массива", "Результат");
            }
            else
            {
                MessageBox.Show("Первый элемент массива {" + string.Join(", ", array) + "} не превосходит среднее (" + array.Average() + ") значение элементов этого массива", "Результат");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int[] array = Array.ConvertAll(System.IO.File.ReadAllLines(@"Arr.txt"), int.Parse);
            int counter = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] >= 0 && array[i] < 0 || array[i - 1] < 0 && array[i] >= 0)
                {
                    counter++;
                }
            }
            MessageBox.Show("В массиве {" + string.Join(", ", array) + "} " + counter + " раз меняется знак у элементов", "Результат");
        }
    }
}
