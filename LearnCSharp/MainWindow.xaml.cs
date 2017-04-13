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

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            int[] array = Array.ConvertAll(System.IO.File.ReadAllLines(@"Arr.txt"), int.Parse);
            int sum = 0;
            foreach (int i in array)
            {
                if (i < 21)
                {
                    sum += i;
                }
            }
            MessageBox.Show("Сумма элементов, меньших чем 21 в массиве {" + string.Join(", ", array) + "} равна " + sum, "Результат");
        }


        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            int[] array = Array.ConvertAll(System.IO.File.ReadAllLines(@"Arr.txt"), int.Parse);
            int[] arrayCopy = new int[10];
            Array.Copy(array, arrayCopy, 10);
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 5).Equals(0))
                {
                    array[i]++;
                }
            }
            MessageBox.Show("Исходный массив {" + string.Join(", ", arrayCopy) + "}, массив c увеличенными на 1 элементами, кратными 5 {" + string.Join(", ", array) + "}", "Результат");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            int[] array = Array.ConvertAll(System.IO.File.ReadAllLines(@"Arr.txt"), int.Parse);
            int sum = 0;
            foreach (int i in array)
            {
                if (!(i % 3).Equals(0))
                {
                    sum += i;
                }
            }
            MessageBox.Show("Сумма элементов, не кратных 3 в массиве {" + string.Join(", ", array) + "} равна " + sum, "Результат");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            int[] array = Array.ConvertAll(System.IO.File.ReadAllLines(@"Arr.txt"), int.Parse);
            int counter = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] < array[0] && array[i] > array[array.Length - 1])
                {
                    counter++;
                }
            }
            MessageBox.Show("В массиве {" + string.Join(", ", array) + "} " + counter + " элементов меньше 1 элемента и одновременно больше последнего", "Результат");
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            int[] array = Array.ConvertAll(System.IO.File.ReadAllLines(@"Arr.txt"), int.Parse);
            int item = array[0];
            int diff = Math.Abs(Math.Abs(array[0]) - Math.Abs(array[1]));
            for (int i = 1; i < array.Length; i++)
            {
                int tempDiff = Math.Abs(Math.Abs(array[i]) - Math.Abs(array[1]));
                if (tempDiff <= diff && i != 1)
                {
                    diff = tempDiff;
                    item = array[i];
                }
            }
            MessageBox.Show("В массиве {" + string.Join(", ", array) + "} элемент " + item + " меньше всего отличается от второго", "Результат");
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            int[] array = Array.ConvertAll(System.IO.File.ReadAllLines(@"Arr.txt"), int.Parse);
            int counter = 0;
            foreach (int i in array)
            {
                if ((i % 3).Equals(0))
                {
                    counter++;
                }
            }
            MessageBox.Show("В массиве {" + string.Join(", ", array) + "} " + counter + " элементов, кратных 3", "Результат");
        }

    }
}
