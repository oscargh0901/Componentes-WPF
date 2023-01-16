using DI02_Tarea_Garcia_Hernandez_Oscar.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DI02_Tarea_Garcia_Hernandez_Oscar.Logica
{
    public class LogicaCitas
    {
        public ObservableCollection<Cita> listaCitas { get; set; }

        public LogicaCitas()
        {
            listaCitas = new ObservableCollection<Cita>();
            //Cita de ejemplo
            listaCitas.Add(new Cita(new DateTime(2022, 11, 12), "Nuevo", "Urgencia", "prueba@gmail.com"));
        }

        public void addCita(Cita cita)
        {
            listaCitas.Add(cita);
        }

        public void modificarCita(Cita cita, int posicion)
        {
            listaCitas[posicion] = cita;
        }

        public void eliminarCita(int posicion)
        {
            try
            {
                listaCitas.RemoveAt(posicion);
            }
            catch(ArgumentOutOfRangeException e)
            {
                MessageBox.Show("No hay mas registros que borrar. Error: " + e.Message);
            }
        }
    }
}
