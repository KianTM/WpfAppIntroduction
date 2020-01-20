using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfAppIntroduction.BIZ
{
    class ClassBIZ
    {
        public ClassBIZ()
        {

        }

        public void Delopgave12(ListBox listBox)
        {
            for (int i = 4711; i <= 4736; i++)
            {
                listBox.Items.Add(i.ToString());
            }
        }

        public void Delopgave13(ListBox listBox)
        {
            Random rnd = new Random();

            for (int i = 0; i < 25; i++)
            {
                int numberToAdd = rnd.Next(100000, 1000001);
                listBox.Items.Add(numberToAdd.ToString());
            }
        }

        public void Delopgave14(ListBox listBox)
        {
            Random rnd = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                int numberToAdd = rnd.Next(100000, 1000001);
                numbers.Add(numberToAdd);
            }

            numbers.Sort();

            foreach (var i in numbers)
            {
                listBox.Items.Add(i);
            }
        }

        public void Delopgave15(ListBox listBox)
        {
            Random rnd = new Random();
            List<int> unsortedNumbers = new List<int>();
            List<int> sortedNumbers = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                int numberToAdd = rnd.Next(100000, 1000001);

                unsortedNumbers.Add(numberToAdd);
                sortedNumbers.Add(numberToAdd);
            }

            sortedNumbers.Sort();

            for (int i = 0; i < unsortedNumbers.Count; i++)
            {
                listBox.Items.Add($"{unsortedNumbers[i].ToString()} - {sortedNumbers[i].ToString()}");
            }
        }

        public void Delopgave16(ListBox listBox)
        {
            Random rnd = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                int numberToAdd = rnd.Next(100000, 1000001);

                listBox.Items.Add(numberToAdd.ToString());
                numbers.Add(numberToAdd);
            }

            listBox.Items.Add("");

            listBox.Items.Add($"Gennemsnit: {FindAverage(numbers)}");
        }

        public int FindAverage(List<int> numbers)
        {
            int total = 0;

            foreach (var i in numbers)
            {
                total += i;
            }

            return total / numbers.Count;
        }

        public void Delopgave17(ListBox listBox)
        {
            Random rnd = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                int numberToAdd = rnd.Next(100000, 1000001);

                numbers.Add(numberToAdd);
            }

            numbers.Sort();
            int average = FindAverage(numbers);

            foreach (var i in numbers)
            {
                listBox.Items.Add($"{i.ToString()} - {average.ToString()} = {(i - average).ToString()}");
            }
        }

        public List<string> Delopgave18()
        {
            Random rnd = new Random();
            List<int> numbers = new List<int>();
            List<string> strings = new List<string>();

            for (int i = 0; i < 25; i++)
            {
                int numberToAdd = rnd.Next(100000, 1000001);

                numbers.Add(numberToAdd);
            }

            numbers.Sort();
            int average = FindAverage(numbers);

            foreach (var i in numbers)
            {
                strings.Add($"{i.ToString()} - {average.ToString()} = {(i - average).ToString()}");
            }

            return strings;
        }

        public void ClearList(ListBox listBox)
        {
            if (listBox.ItemsSource != null)
            {
                listBox.ItemsSource = null;
                listBox.Items.Clear();
            }
            else
            {
                listBox.Items.Clear();
            }
        }

        public void Delopgave19(ListBox listBox)
        {
            Random rnd = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                int numberToAdd = rnd.Next(100000, 1000001);

                numbers.Add(numberToAdd);
            }

            numbers.Sort();
            int average = FindAverage(numbers);

            foreach (var i in numbers)
            {
                ListBoxItem listBoxItem = new ListBoxItem();
                listBoxItem.Content = $"{i.ToString()} - {average.ToString()} = {(i - average).ToString()}";
                
                if (i % 2 == 0)
                {
                    listBoxItem.Background = Brushes.HotPink;
                }
                else
                {
                    listBoxItem.Background = Brushes.AliceBlue;
                }

                listBox.Items.Add(listBoxItem);
            }
        }
    }
}
