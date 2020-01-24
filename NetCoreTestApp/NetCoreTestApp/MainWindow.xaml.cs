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

namespace NetCoreTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Person> people;
        public MainWindow()
        {
            InitializeComponent();
            //Initialize Person Collection
            people = new ObservableCollection<Person>();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query =
            from person in people
            orderby person.FullName
            select new
            {
                person.FullName,
                person.Age,
                person.BirthYear
            };

            dataGrid1.ItemsSource = query.ToList();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            //    var whereClause = GetWhereClause(sender[]);

            //    var query = 
            //    from person in people
            //    orderby person.FullName
            //    where 
            //    select new
            //    {
            //        person.FullName,
            //        person.Age,
            //        person.BirthYear
            //    };

            //    dataGrid1.ItemsSource = query.ToList();
        }

        private void AddPerson_Click(object sender, RoutedEventArgs e)
        {
            //people.Add();
        }

        //private string GetWhereClause(string rawString) 
        //{
        //    int i = 
        //    switch (c)
        //    {
        //        case (searchString.Trim < 4 && searchString.Trim):
        //            Console.WriteLine("Case 1");
        //            break;
        //        case 2:
        //            Console.WriteLine("Case 2");
        //            break;
        //        default:
        //            Console.WriteLine("Default case");
        //            break;
        //    }
        //}

        //private int FineCase(string searchString)
    }
}
