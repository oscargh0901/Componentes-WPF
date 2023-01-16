using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DI02_Tarea_Garcia_Hernandez_Oscar.DTO
{
    public class Cita : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        private DateTime _fecha;
        public DateTime Fecha
        {
            get
            {
                return _fecha;
            }
            set
            {
                _fecha = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Fecha"));

            }
        }

        private string _cliente;
        public string Cliente
        {
            get
            {
                return _cliente;
            }
            set
            {
                _cliente = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Cliente"));
            }
        }

        private string _motivo;
        public string Motivo
        {
            get
            {
                return _motivo;
            }
            set
            {
                _motivo = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Motivo"));
            }
        } 
        
        private string _mail;
        public string Mail
        {
            get
            {
                return _mail;
            }
            set
            {
                _mail = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Mail"));
            }
        }

        public Object Clone()
        {
            return this.MemberwiseClone();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Error => throw new NotImplementedException();

        public string this[string columnName]
        {
            get
            {
                string result = "";

                if (columnName == "Clientes")
                {
                    if (string.IsNullOrEmpty(_cliente.ToString()))
                    {
                        result = "El campo cliente no debe estar vacio";
                    }
                }

                if (columnName == "Motivo")
                {
                    if (string.IsNullOrEmpty(_motivo.ToString()))
                    {
                        result = "El campo motivo no debe estar vacio";
                    }
                }
                
                //A pesar de escribir bien tras la validación en el csModal, salta esta validación y al darle aceptar, todo OK
                if (columnName == "Mail")
                {
                    if (string.IsNullOrEmpty(_mail))
                    {
                        result = "El campo mail no debe estar vacio";
                    }
                }

                return result;
            }
        }

        public Cita(DateTime fecha, string cliente, string motivo, string mail)
        {
            _fecha = fecha;
            _cliente = cliente;
            _motivo = motivo;
            _mail = mail;
        }

        public Cita()
        {
            _fecha = System.DateTime.Now;
        }
    }
}
