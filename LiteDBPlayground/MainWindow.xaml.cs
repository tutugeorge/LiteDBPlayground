using System;
using System.Collections.Generic;
using System.Data.SQLite;
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

namespace LiteDBPlayground
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitDB();
        }

        void InitDB()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=main.db");

            con.Open();
            var cmd = con.CreateCommand();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS tab1(id int, name varchar(30), age int)";
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
