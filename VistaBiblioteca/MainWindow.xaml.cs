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
using Modelo;

namespace VistaBiblioteca
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Alumno> alumnos = new ObservableCollection<Alumno>();

        public ObservableCollection<Alumno> Alumnos
        {
            get { return alumnos; }
            set { alumnos = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public DataGrid Library
        {
            get { return LibraryDataGrid; }
            set { LibraryDataGrid = value; }
        }

        public Button Delete
        {
            get { return DeleteButton; }
            set { DeleteButton = value; }
        }

        public TextBox id
        {
            get { return IdTextBox; }
            set { IdTextBox = value; }
        }

        private void createButtonClick(object sender, RoutedEventArgs e)
        {

        }

        public void setAlumnos(ObservableCollection<Alumno> alumnos)
        {
            Console.WriteLine("hola desde vista");
            this.alumnos = alumnos;
        }

    }
}
