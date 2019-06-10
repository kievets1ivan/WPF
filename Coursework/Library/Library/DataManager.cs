using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library
{
    public class DataManager
    {
        static public void SaveData(string fileName, ObservableCollection<Abonent> list)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                try
                {
                    foreach (Abonent x in list)
                    {
                        sw.WriteLine(x);
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        //list это коллекция в датаМоделе
        public static void ReadData(string filename, ObservableCollection<Abonent> list)
        {
            using (StreamReader sw = new StreamReader(filename))
            {
                try
                {
                    string line = null;
                    list.Clear();
                    while ((line = sw.ReadLine()) != null)
                    {
                        string[] tokens = line.Split(Delimetr.delimetr);

                        list.Add(new Abonent(tokens[0], tokens[1], new Time(int.Parse(tokens[2]) / 3600, int.Parse(tokens[2]) % 3600 / 60, int.Parse(tokens[2]) % 3600 % 60),
                            (Operator)int.Parse(tokens[3]), new TariffPlan(tokens[4].Substring(0, tokens[4].IndexOf(' ')), Convert.ToDecimal(tokens[4].Substring(tokens[4].IndexOf(' ') + 1)))));
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }






    }
}
