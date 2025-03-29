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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private List<Profesor> listaProfesores = new List<Profesor>();
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<Profesor> profesores = new List<Profesor>();
            profesores.Add(new Profesor { Apellidos= "Gomez", Nombres = "Jaime"} );
            profesores.Add(new Profesor { Apellidos = "Eddy", Nombres = "Anthony" });

            dgProfesores.ItemsSource = profesores;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            List<Curso> cursos = new List<Curso>();
            cursos.Add(new Curso { CodigoCurso = 1, NombreCurso = "comunicacion", DescripcionCurso = "es un curso de comu" });

            dgCursos.ItemsSource = cursos;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            {
                
                if (!string.IsNullOrEmpty(txtNombres.Text) && !string.IsNullOrEmpty(txtApellidos.Text))
                {
                    
                    Profesor nuevoProfesor = new Profesor
                    {
                        Nombres = txtNombres.Text,
                        Apellidos = txtApellidos.Text
                    };

                    
                    listaProfesores.Add(nuevoProfesor);

                   
                    dgProfesores.ItemsSource = null; 
                    dgProfesores.ItemsSource = listaProfesores;

                    
                    txtNombres.Clear();
                    txtApellidos.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese ambos nombres y apellidos.");
                }


            }
        }
    }
}
