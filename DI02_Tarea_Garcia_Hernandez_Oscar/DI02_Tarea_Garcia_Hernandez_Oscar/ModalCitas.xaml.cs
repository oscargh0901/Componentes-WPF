using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using DI02_Tarea_Garcia_Hernandez_Oscar.DTO;
using DI02_Tarea_Garcia_Hernandez_Oscar.Logica;

namespace DI02_Tarea_Garcia_Hernandez_Oscar
{
    /// <summary>
    /// Lógica de interacción para ModalCitas.xaml
    /// </summary>
    public partial class ModalCitas : Window
    {
        private Cita cita;
        private int posicion;
        private bool modificar;
        private LogicaCitas citas;
        private int errores;

        public ModalCitas(LogicaCitas citas)
        {
            InitializeComponent();
            this.modificar = false;
            this.citas = citas;
            this.cita = new Cita();
            this.DataContext = this.cita;
        }

        public ModalCitas(LogicaCitas citas, Cita cita, int posicion)
        {
            InitializeComponent();
            this.modificar = true;
            this.citas = citas;
            this.cita = cita;
            this.DataContext = this.cita;
            this.posicion = posicion;
        }

        //Omite la creación/modificacion de un cita, cerrando la ventana modal
        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        //En el caso de estar creando una nueva cita, se añadirá como un nuevo objeto de la clase cita,
        //si se está modificando, creará de nuevo el objeto, sustituyendolo en la posicion con el original
        private void ButtonAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Motivo.SelectionBoxItem.ToString()))
            {
                MessageBox.Show("No puedes dejar sin seleccionar un motivo.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (string.IsNullOrEmpty(Cliente.SelectionBoxItem.ToString()))
            {
                MessageBox.Show("No puedes dejar sin seleccionar un cliente.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (CheckCertificado.IsChecked == false)
            {
                MessageBox.Show("Debes tener un certificado para realizar la cita.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {

                if (modificar)
                {
                    citas.modificarCita(this.cita, this.posicion);
                }
                else
                {
                    citas.addCita(this.cita);
                }
                this.Close();
            }
        }

        //Este método se ocupa de deshabilitar el botón de aceptar siempre y cuando salte un error
        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
            {
                errores++;
            }
            else
            {
                errores--;
            }

            if (errores == 0)
            {
                this.ButtonAceptar.IsEnabled = true;
            }
            else
            {
                this.ButtonAceptar.IsEnabled = false;
            }
        }

        //Valido el campo mail para que no esté vacio (regex obtenido de StackOverflow)
        private void TextBoxMail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxMail.Text) || Regex.IsMatch(TextBoxMail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Debes completar el campo mail", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
