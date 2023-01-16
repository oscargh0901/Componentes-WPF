using System;
using System.Windows.Controls;

namespace DI02_Tarea_Garcia_Hernandez_Oscar.Componentes;

public partial class Dni : UserControl
{
    public string Numero { get; set; } = string.Empty;
    public bool EsValido { get; set; } = false;
    
    public Dni()
    {
        InitializeComponent();
        DataContext = this;
    }
    
    // Obtengo los numeros del dni
    public string ObtenerNumeros()
    {
        return Numero.Substring(0, 8);
    }
    
    // Calculo el nif del dni
    public void ObtenerNif(object sender, EventArgs e)
    {
        string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
        int posicion = int.Parse(ObtenerNumeros()) % 23;
        
        if (letras[posicion] >= 0 && letras[posicion] <= 22)
        {
            EsValido = true;
        }
        else
        {
            EsValido = false;
        }
        
    }
}