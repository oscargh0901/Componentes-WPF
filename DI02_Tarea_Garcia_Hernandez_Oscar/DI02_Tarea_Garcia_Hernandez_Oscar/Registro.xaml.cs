using DI02_Tarea_Garcia_Hernandez_Oscar.DTO;
using DI02_Tarea_Garcia_Hernandez_Oscar.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DI02_Tarea_Garcia_Hernandez_Oscar
{
    public partial class Registro : Window
    {
        private LogicaCitas logicaCitas;
        private Cita cita;

        public Registro(LogicaCitas logicaCitas)
        {
            InitializeComponent();
            this.logicaCitas = logicaCitas;
            dataGridCitas.DataContext = logicaCitas;
            this.cita = new Cita();
        }

        public Registro(LogicaCitas logicaCitas, Cita cita, int posicion)
        {
            InitializeComponent();
            this.logicaCitas = logicaCitas;
            this.cita = cita;
            this.DataContext = this.cita;
        }

        private void ButtonVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Boton de la barra del menu para editar a una cita previamente seleccionado en la tabla (grid)
        private void ButtonEditar_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridCitas.SelectedIndex != -1)
            {
                //Creo un nuevo objeto de la clase cita y le coloco los datos obtenidos de la tabla para asi poder visualizarlas y editarlas
                Cita cita = (Cita)dataGridCitas.SelectedItem;
                ModalCitas dialogoTrabajador = new ModalCitas(logicaCitas, (Cita)cita.Clone(), dataGridCitas.SelectedIndex);
                dialogoTrabajador.Show();
            }
            else //En caso de no tener seleccionado a ninguna cita, saltará esta ventana de error
            {
                MessageBox.Show("Debe seleccionar un item de la tabla", "Error selección", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //Boton de la barra del menu para eliminar a una cita previamente seleccionado en la tabla (grid)
        private void ButtonEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridCitas.SelectedIndex != -1)
            {
                logicaCitas.eliminarCita(dataGridCitas.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cita de la tabla.", "Error selección", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
