using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

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
    }
}
