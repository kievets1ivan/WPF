using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Models
{
    public class DataModel : ObservableObject
    {
        public ObservableCollection<Abonent> Abonents;
        //static private DataModel instance;

        /*static public DataModel GetInstance()
        {
            if (instance == null)
                instance = new DataModel();
            return instance;
        }*/


        public DataModel()
        {
            Abonents = new ObservableCollection<Abonent>();

            Abonents.Add(new Abonent("dsa", "dsada", new Time(1, 3, 4), new Operator(TypeOperator.Lifecell, 0.03m)));//для проверки
        }

        public ObservableCollection<Abonent> GetCache() => Abonents;

        public void Clear() => Abonents.Clear();

        public void Add(Abonent a) => Abonents.Add(a);

        public void Remove(int i) => Abonents.RemoveAt(i);

        public void Edit(int i)
        {
            Abonent a = Abonents.ElementAt(i);
            Abonents.Insert(i, a);
        }

        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set { OnPropertyChanged(ref _filePath, value); }
        }

        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { OnPropertyChanged(ref _fileName, value); }
        }

        public bool isEmpty
        {
            get
            {
                if (string.IsNullOrEmpty(FileName) ||
                    string.IsNullOrEmpty(FilePath))
                    return true;

                return false;
            }
        }

    }
}
