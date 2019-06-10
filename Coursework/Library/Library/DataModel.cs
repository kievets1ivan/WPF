using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class DataModel
    {
        static public DataModel instance;
        static ObservableCollection<Abonent> abonents;


        static public DataModel GetInstance()
        {
            if (instance == null)
                instance = new DataModel();
            return instance;
        }

        private DataModel()
        {
            abonents = new ObservableCollection<Abonent>();
        }

        public ObservableCollection<Abonent> GetCache() => abonents;

        public void Clear() => abonents.Clear();

        public void Add(Abonent a) => abonents.Add(a);

        public void Remove(int i) => abonents.RemoveAt(i);

        public void Edit(int i)
        {
            Abonent a = abonents.ElementAt(i);
            abonents.Insert(i, a);
        }



    }
}
