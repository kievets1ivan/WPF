using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Coursework.Models;
using System.Text.RegularExpressions;


namespace Coursework
{
    /// <summary>
    /// Interaction logic for AddDialogWindow.xaml
    /// </summary>
    public partial class AddDialogWindow : Window
    {
        public AddDialogWindow()
        {
            InitializeComponent();
        }

        public Abonent Abonent { get; set; }
        private bool _okCkicked = false;
        public bool isAddCkicked() => _okCkicked;

        Dictionary<TypeOperator, decimal> OperatorPrices = new Dictionary<TypeOperator, decimal>
        {
            [TypeOperator.Kyivstar] = 0.002m,
            [TypeOperator.Lifecell] = 0.003m,
            [TypeOperator.Vodafone] = 0.005m
        };




        private bool isInputValid()
        {
            string errorMessage = "";

            if (!isFieldValid(NameField.Text, @"^[а-я]+$"))
                errorMessage += "Неможливе значення в полi iм'я!\n";
            if (!isFieldValid(PhoneField.Text, @"^[0-9]{7}$"))
                errorMessage += "Неможливе значення в полi номер телефону!\n";
            if (!isFieldValid(HoursField.Text, @"^\d+$"))
                errorMessage += "Неможливе значення в полi години!\n";
            if (!isFieldValid(MinField.Text, @"^[0-5]?\d{1}$"))
                errorMessage += "Неможливе значення в полi хвилини!\n";
            if (!isFieldValid(SecField.Text, @"^[0-5]?\d{1}$"))
                errorMessage += "Неможливе значення в полi секунди!\n";
            if (OperatopField.Text == "" || OperatopField.Text == null)
                errorMessage += "Неможливе значення в полi оператор!\n";
            if (errorMessage.Length == 0)
                return true;
            else
            {
                MessageBox.Show(errorMessage);
                return false;
            }

        }

        private bool isFieldValid(string str, string pattern)
        {
            Regex reg = new Regex(pattern, RegexOptions.IgnoreCase);
            if (reg.IsMatch(str))
                return true;
            return false;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            if(isInputValid())
            {
                Enum.TryParse(OperatopField.Text, out TypeOperator temp);
                Abonent = new Abonent(NameField.Text, PhoneField.Text,
                            new Time(int.Parse(HoursField.Text), int.Parse(MinField.Text), int.Parse(SecField.Text)),
                            new Operator(temp, OperatorPrices.FirstOrDefault(q => q.Key == temp).Value));

                _okCkicked = true;
                Close();
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
