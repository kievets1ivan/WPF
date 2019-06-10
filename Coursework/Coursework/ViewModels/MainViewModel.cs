using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coursework.Models;


namespace Coursework.ViewModels
{
    public class MainViewModel
    {
        //Document that is saved, loaded and hold editor text
        private DataModel _document;

        //Manages user input for document and format styles
        public ActionViewModel Editor { get; set; }
        //Manages saving and loading text files
        public FileViewModel File { get; set; }
        //Manage help dialog
        public HelpViewModel Help { get; set; }

        public DataModel Document { get => _document; }

        public MainViewModel()
        {
            
            _document = new DataModel();
            Help = new HelpViewModel();
            Editor = new ActionViewModel(_document);
            File = new FileViewModel(_document);
        }
        
        //public ObservableCollection<Abonent> InitGrid() => _document.GetCache();

        
    }
}
