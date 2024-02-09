using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDerivado : ItemBase
{
    private Propiedades propiedades;

    public ItemBase espadaDiamante;



    private void Start()
    {
        espadaDiamante = new ItemBase();

        espadaDiamante.setPropiedadesGenerales("Espada de diamante", 7, "Arma cuerpo a cuerpo, utilizada para hacerle daño principalmente a criaturas y/o jugadores ", 1);
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