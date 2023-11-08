using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Sortowanie
{
    public partial class Form1 : Form
    {
        int[] array;
        Stopwatch sw = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        void BubbleSort()
        {
            bool didSwap = false;
            do
            {
                didSwap = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                        didSwap = true;
                    }
                }
            } while (didSwap);
        }

        void SelectionSort()
        {
            int minId = 0;
            for (int i = 0; i < array.Length; i++)
            {
                minId = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[minId] > array[j])
                        minId = j;
                }
                Swap(ref array[minId], ref array[i]);
            }
        }

        void InsertSort()
        {
            int temp;
            for (int i = 1; i < array.Length; i++)
            {
                temp = array[i];
                for (int j = i; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
        }

        void MergeSort(int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(left, middle);
                MergeSort(middle + 1, right);
                Merge(left, middle, right);
            }
        }

        void Merge(int left, int middle, int right)
        {
            int i = 0, j = 0, k = left, n = middle - left + 1, m = right - middle;
            int[] sub1 = new int[n], sub2 = new int[m];

            for (; i < n; i++)
            {
                sub1[i] = array[left + i];
            }
            for (; j < m; j++)
            {
                sub2[j] = array[middle + j + 1];
            }


            i = 0;
            j = 0;

            while (i < n && j < m)
            {
                if (sub1[i] <= sub2[j])
                    array[k++] = sub1[i++];
                else
                    array[k++] = sub2[j++];
            }

            while (i < n)
            {
                array[k++] = sub1[i++];
            }

            while (j < m)
            {
                array[k++] = sub2[j++];
            }
        }

        void QuickSort(int left, int right)
        {
            if (left < right)
            {
                int middle = Partition(left, right);
                QuickSort(left, middle);
                QuickSort(middle + 1, right);
            }
        }

        int Partition(int left, int right)
        {
            int pivot = array[(left + right) / 2], i = left - 1, j = right + 1;
            while (true)
            {
                do
                {
                    i++;
                }
                while (array[i] < pivot);

                do
                {
                    j--;
                }
                while (array[j] > pivot);

                if (i >= j)
                    return j;

                Swap(ref array[i], ref array[j]);
            }
        }

        void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        int[] GenerateArray(int n)
        {
            int[] array = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 1000);
            }
            return array;
        }

        string ToString(int[] array)
        {
            string str = "";
            for (int i = 0; i < array.Length; i++)
            {
                str += array[i];
                str += ' ';
            }
            return str;
        }

        int[] ToIntArray(string input)
        {
            string[] numbersStr = input.Split(' ');
            int[] numbers = new int[numbersStr.Length];
            for (int i = 0; i < numbersStr.Length; i++)
                numbers[i] = int.Parse(numbersStr[i].Trim());
            return numbers;
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            if (!cbSwitch.Checked)
            {
                array = ToIntArray(tbInput.Text);
                BubbleSort();
                tbOutput.Text = ToString(array);
            }
            else
            {
                sw.Start();
                BubbleSort();
                sw.Stop();
                lblTimeSeconds.Text = sw.Elapsed.Seconds.ToString() + "." + sw.Elapsed.Milliseconds.ToString() + " s";
                sw.Reset();
            }
        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            if (!cbSwitch.Checked)
            {
                array = ToIntArray(tbInput.Text);
                SelectionSort();
                tbOutput.Text = ToString(array);
            }
            else
            {
                sw.Start();
                SelectionSort();
                sw.Stop();
                lblTimeSeconds.Text = sw.Elapsed.Seconds.ToString() + "." + sw.Elapsed.Milliseconds.ToString() + " s";
                sw.Reset();
            }
        }

        private void btnInsertSort_Click(object sender, EventArgs e)
        {
            if (!cbSwitch.Checked)
            {
                array = ToIntArray(tbInput.Text);
                InsertSort();
                tbOutput.Text = ToString(array);
            }
            else
            {
                sw.Start();
                InsertSort();
                sw.Stop();
                lblTimeSeconds.Text = sw.Elapsed.Seconds.ToString() + "." + sw.Elapsed.Milliseconds.ToString() + " s";
                sw.Reset();
            }
        }

        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            if (!cbSwitch.Checked)
            {
                array = ToIntArray(tbInput.Text);
                MergeSort(0, array.Length - 1);
                tbOutput.Text = ToString(array);
            }
            else
            {
                sw.Start();
                MergeSort(0, array.Length - 1);
                sw.Stop();
                lblTimeSeconds.Text = sw.Elapsed.Seconds.ToString() + "." + sw.Elapsed.Milliseconds.ToString() + " s";
                sw.Reset();
            }
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            if (!cbSwitch.Checked)
            {
                array = ToIntArray(tbInput.Text);
                QuickSort(0, array.Length - 1);
                tbOutput.Text = ToString(array);
            }
            else
            {
                sw.Start();
                QuickSort(0, array.Length - 1);
                sw.Stop();
                lblTimeSeconds.Text = sw.Elapsed.Seconds.ToString() + "." + sw.Elapsed.Milliseconds.ToString() + " s";
                sw.Reset();
            }
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbSwitch_CheckedChanged(object sender, EventArgs e)
        {
            tbInput.Enabled = !tbInput.Enabled;
            nudInputRandom.Enabled = !nudInputRandom.Enabled;
            btnGenerate.Enabled = !btnGenerate.Enabled;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            array = GenerateArray((int)nudInputRandom.Value);
        }

        private void nudInputRandom_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
