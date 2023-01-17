using System;
using System.Windows;
using System.Windows.Controls;

namespace DI02_Tarea_Garcia_Hernandez_Oscar.Componentes;

public partial class Dni : UserControl
{
    public string Numero { get; set; } = string.Empty;
    
    public Dni()
    {
        InitializeComponent();
        DataContext = this;
    }
    
    // Calculo el nif del dni
    public void ObtenerNif(object sender, EventArgs e)
    {
        string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
        int posicion = int.Parse(Numero.Substring(0, 8)) % 23;
        
        if (letras[posicion] >= 0 && letras[posicion] <= 22)
        {
            // Es correcto
        }
        else
        {
            MessageBox.Show("Escribe un DNI Valido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        } 
    }
}