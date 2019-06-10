using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;
using System.Windows.Input;
using Coursework.Models;
using System.Windows;

namespace Coursework.ViewModels
{
    public class FileViewModel
    {
        public DataModel Document { get; private set; }

        //Toolbar commands
        public ICommand NewCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand SaveAsCommand { get; }
        public ICommand OpenCommand { get; }

        public FileViewModel(DataModel document)
        {
            Document = document;
            NewCommand = new RelayCommand(NewFile);
            SaveCommand = new RelayCommand(SaveFile, () => !Document.isEmpty);
            SaveAsCommand = new RelayCommand(SaveFileAs);
            OpenCommand = new RelayCommand(OpenFile);
        }

        public void NewFile()
        {
            Document.FileName = string.Empty;
            Document.FilePath = string.Empty;
            //Document.Text = string.Empty;
        }

        private void SaveFile()
        {
            //File.WriteAllText(Document.FilePath, Document.Text);
            using (StreamWriter sw = new StreamWriter(Document.FileName))
            {
                try
                {
                    foreach (Abonent x in Document.GetCache())
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

        private void SaveFileAs()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == true)
            {
                DockFile(saveFileDialog);

                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    try
                    {
                        foreach (Abonent x in Document.GetCache())
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
        }

        private void OpenFile()
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                DockFile(openFileDialog);
                using (StreamReader sw = new StreamReader(openFileDialog.FileName))
                {
                    try
                    {
                        TypeOperator typeOper;
                        string line = null;
                        Document.Clear();
                        while ((line = sw.ReadLine()) != null)
                        {
                            string[] tokens = line.Split(Delimetr.delimetr);

                            if (Enum.TryParse(tokens[3].Substring(0, tokens[3].IndexOf(' ')), out typeOper))
                            {
                                Document.Add(new Abonent(tokens[0], tokens[1], 
                                    new Time(int.Parse(tokens[2]) / 3600, int.Parse(tokens[2]) % 3600 / 60, int.Parse(tokens[2]) % 3600 % 60),
                                    new Operator(typeOper, Convert.ToDecimal(tokens[4].Substring(tokens[4].IndexOf(' ') + 1)))));
                            }
                            else
                            {
                                MessageBox.Show("Тип оператора було пошкоджено, перевiрте правильнiсть його написання в файлi: " + openFileDialog.FileName);
                            }
                        }
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }

        private void DockFile<T>(T dialog) where T : FileDialog
        {
            Document.FilePath = dialog.FileName;
            Document.FileName = dialog.SafeFileName;
        }
    }
}
