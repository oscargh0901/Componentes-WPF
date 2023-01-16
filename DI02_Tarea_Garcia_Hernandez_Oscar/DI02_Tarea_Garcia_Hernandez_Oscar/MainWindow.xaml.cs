using DI02_Tarea_Garcia_Hernandez_Oscar.DTO;
using DI02_Tarea_Garcia_Hernandez_Oscar.Logica;
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

namespace DI02_Tarea_Garcia_Hernandez_Oscar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Registro registro;
        private LogicaCitas logicaCitas;
        private Cita cita;
        private ModalPerfilCliente modalPerfilCliente;

        public MainWindow()
        {
            InitializeComponent();
            registro = new Registro(logicaCitas);
            logicaCitas = new LogicaCitas();
            cita = new Cita();
            modalPerfilCliente = new ModalPerfilCliente( logicaCitas);
        }

        /*Botones del menu bar*/
        private void MenuItem_Click_Crear(object sender, RoutedEventArgs e)
        {
            ModalCitas cita = new ModalCitas(logicaCitas);
            cita.Show();
        }
        
        private void MenuItem_Click_Registro(object sender, RoutedEventArgs e)
        {
            Registro registro = new Registro(logicaCitas);
            registro.Show();
        }
        
        private void MenuItem_Click_Salir(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /*Botones de acceso*/
        
        private void ButtonRegistro_Click(object sender, RoutedEventArgs e)
        {
            Registro registro = new Registro(this.logicaCitas);
            registro.ShowDialog();
        }
        
        private void ButtonCrear_Click(object sender, RoutedEventArgs e)
        {
            ModalCitas cita = new ModalCitas(logicaCitas);
            cita.Show();
        }
        
        private void ButtonPerfilCliente_Click (object sender, RoutedEventArgs e)
        {
            ModalPerfilCliente perfilCliente = new ModalPerfilCliente(logicaCitas);
            perfilCliente.Show();
        }
    }
}
