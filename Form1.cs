using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sortowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void BubbleSort(int[] tab)
        {
            bool cbz = false;
            int temp;
            do
            {
                cbz = false;
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        temp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = temp;
                        cbz = true;
                    }
                }
            } while (cbz);

        }

        void SelectionSort(int[] tab)
        {
            int min = 0;
            int temp;
            for (int i = 0; i < tab.Length; i++)
            {
                min = i;
                for (int j = i; j < tab.Length; j++)
                {
                    if (tab[min] > tab[j])
                        min = j;
                }
                temp = tab[min];
                tab[min] = tab[i];
                tab[i] = temp;
            }
        }

        void InsertSort(int[] tab)
        {
            int temp;
            for (int i = 1; i < tab.Length; i++)
            {
                temp = tab[i];
                for (int j = i; j > 0; j--)
                {
                    if (tab[j] < tab[j - 1])
                    {
                        tab[j] = tab[j - 1];
                        tab[j - 1] = temp;
                    }
                }
            }
        }

        void Merge(int[] array, int left, int middle, int right)
        {

        }

        void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
        }

        string ToString(int[] tab)
        {
            string str = "";
            for (int i = 0; i < tab.Length; i++)
            {
                str += tab[i];
                str += ' ';
            }
            return str;
        }

        int[] ToIntArray(string input)
        {
            string[] liczbyS = input.Split(' ');
            int[] liczby = new int[liczbyS.Length];
            for (int i = 0; i < liczbyS.Length; i++)
                liczby[i] = int.Parse(liczbyS[i].Trim());
            return liczby;
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            int[] tab = ToIntArray(tbInput.Text);
            BubbleSort(tab);
            tbOutput.Text = ToString(tab);
        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            int[] tab = ToIntArray(tbInput.Text);
            SelectionSort(tab);
            tbOutput.Text = ToString(tab);
        }

        private void btnInsertSort_Click(object sender, EventArgs e)
        {
            int[] tab = ToIntArray(tbInput.Text);
            InsertSort(tab);
            tbOutput.Text = ToString(tab);
        }

        private void btnMergeSort_Click(object sender, EventArgs e)
        {

        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {

        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
