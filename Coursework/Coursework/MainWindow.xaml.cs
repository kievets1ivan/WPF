using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Coursework.Models;

namespace Coursework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*Dictionary<TypeOperator, decimal> OperatorPrices = new Dictionary<TypeOperator, decimal>
            {
                [TypeOperator.Kyivstar] = 0.002m,
                [TypeOperator.Lifecell] = 0.003m,
                [TypeOperator.Vodafone] = 0.005m
            };

            var items = new ObservableCollection<Abonent>();
            items.Add(new Abonent("Fido","2131", new Time(2, 3), new Operator(OperatorPrices.Keys.ElementAt(0), OperatorPrices.Values.ElementAt(0))));
            items.Add(new Abonent("Bodsadasdasdsadasdsadasdsb", "32154", new Time(2, 13), new Operator(TypeOperator.Lifecell, 23.3m)));
            items.Add(new Abonent("Rot", "54343", new Time(2, 3), new Operator(TypeOperator.Kyivstar, 23.3m)));

            // ... Assign ItemsSource of DataGrid.
            grid.DataContext = items;*/
        }

        //List<Abonent> abo = new List<Abonent> { new Abonent("dsada", "sdsa", new Time(1, 3, 5), new Operator(TypeOperator.Kyivstar, 0.02m)) };
    }
}
