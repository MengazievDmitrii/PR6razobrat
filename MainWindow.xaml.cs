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
using System.Xml;

namespace ПР6
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
        Random a = new Random();
        private void b1_Click(object sender, RoutedEventArgs e)
        {
            int[] arr = new int[a.Next(10, 25)]; // генерация рандомного массива рандомной длиной от 10 до 25 чисел;
            Random rand = new Random();
            try
            {
                for (int i = 0; i < a.Next(10, 25); i++)
                {
                    arr[i] = rand.Next(-100, 100); //заполнение массива числами от -100 до 100
                }
                for (int i = 0; i < a.Next(10, 25); i++)
                {
                    tb1.Text = string.Join(Environment.NewLine, arr);

                }
            }
            catch { }
        }

        private void b2_Click(object sender, RoutedEventArgs e, int[] arr)
        {
            int[] arrCopy = new int[arr.Length];
            Array.Copy(arr, arrCopy, arr.Length);
            SortAndMeasure("Сортировка пузырьком", arr, BubbleSort);
            tb2.Text = string.Join(Environment.NewLine,arrCopy);
        }

        private void BubbleSort(int[] arr) //Сортировка пузырьком
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                    }
                }
            }
        }
        private void SelectionSort(int[] arr) //сортировка выбором
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(arr, i, minIndex);
            }
        }
        private void QuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }

        private void QuickSort(int[] arr, int low, int high) //быстрая сортировка
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }
        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, high);
            return (i + 1);
        }
        // Обмен элементов массива
        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        private void b2_Click_1(object sender, RoutedEventArgs e)
        {

        }
        private void SortAndMeasure(string algorithmName, int[] arr, Action<int[]> sortMethod)
        {
            // Создание копии массива для каждого алгоритма
            int[] numbersCopy = new int[arr.Length];
            Array.Copy(arr, numbersCopy, arr.Length);

        }
    }
}