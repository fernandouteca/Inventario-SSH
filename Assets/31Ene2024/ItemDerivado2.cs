using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDerivado2 : ItemBase
{
    private Propiedades propiedades;

    public ItemBase polloAsado;


    private void Start()
    {
        polloAsado = new ItemBase();

        polloAsado.setPropiedadesGenerales("Pollo Asado", 3, "Alimento que restaura la salud y el hambre", 1);
    }


    // Constructor de la clase ItemDerivado
    public void setPropiedades(string tipo, string rareza, string habilidad)
    {
        propiedades = new Propiedades();
        propiedades.tipo = tipo;
        propiedades.rareza = rareza;
        propiedades.habilidad = habilidad;
    }

    public Propiedades getPropiedades()
    {
        return propiedades;
    }

}
