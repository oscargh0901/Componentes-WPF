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
    public partial class ModalPerfilCliente : Window
    {
        private Cita cita;
        private int posicion;
        private bool modificar;
        private LogicaCitas citas;
        private int errores;

        public ModalPerfilCliente(LogicaCitas citas)
        {
            InitializeComponent();
            modificar = false;
            this.citas = citas;
            cita = new Cita();
            DataContext = cita;
        }

        public ModalPerfilCliente(LogicaCitas citas, Cita cita, int posicion)
        {
            InitializeComponent();
            modificar = true;
            this.citas = citas;
            this.cita = cita;
            DataContext = this.cita;
            this.posicion = posicion;
        }

        //Omite la creación/modificacion de un cita, cerrando la ventana modal
        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        //En el caso de estar creando una nueva cita, se añadirá como un nuevo objeto de la clase cita,
        //si se está modificando, creará de nuevo el objeto, sustituyendolo en la posicion con el original
        private void ButtonAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (CheckCertificado.IsChecked == false)
            {
                MessageBox.Show("Debes verificar tu edad.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }else
            
            if (string.IsNullOrEmpty(TextBoxName.Text))
            {
                MessageBox.Show("Completa el nombre", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }else
            
            if (string.IsNullOrEmpty(TextBoxSurnames.Text))
            {
                MessageBox.Show("Completa los apellidos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }else
            
            if (string.IsNullOrEmpty(TextBoxPhoneNumber.Text))
            {
                MessageBox.Show("Completa el numero de telefono", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }else
            
            if (string.IsNullOrEmpty(TextBoxAddress.Text))
            {
                MessageBox.Show("Completa la direccion fisica", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }else
            
            if (string.IsNullOrEmpty(DatePicker.Text))
            {
                MessageBox.Show("Completa la fecha", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (modificar)
                {
                    citas.modificarCita(cita, posicion);
                }
                else
                {
                    citas.addCita(cita);
                }
                Close();
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
                ButtonAceptar.IsEnabled = true;
            }
            else
            {
                ButtonAceptar.IsEnabled = false;
            }
        }

        //Valido el campo mail para que no esté vacio (regex obtenido de StackOverflow)
        private void TextBoxMail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxMail.Text) || !Regex.IsMatch(TextBoxMail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Debes completar el campo mail", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
