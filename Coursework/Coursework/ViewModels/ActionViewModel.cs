using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coursework.Models;
using System.Windows.Input;


namespace Coursework.ViewModels
{
    public class ActionViewModel
    {
        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public DataModel Document { get; set; }

        public ActionViewModel(DataModel document)
        {
            Document = document;
            AddCommand = new RelayCommand(OpenAddDialog);
            EditCommand = new RelayCommand(OpenEditDialog);
            DeleteCommand = new RelayCommand(Delete);
            /*Format = new FormatModel();
            FormatCommand = new RelayCommand(OpenStyleDialog);
            WrapCommand = new RelayCommand(ToggleWrap);*/
        }

        

        private void OpenEditDialog()
        {
            /*var fontDialog = new FontDialog();// editDialog
            fontDialog.ShowDialog();*/
        }

        private void OpenAddDialog()
        {
            AddDialogWindow addDialogWindow = new AddDialogWindow();
            addDialogWindow.ShowDialog();
            
            Document.Add(addDialogWindow.Abonent);

        }

        private void Delete()
        {
            
        }

    }
}
