using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : MonoBehaviour
{
    public ItemDerivado espadaDiamante;
    public ItemDerivado2 polloAsado;
    public ItemDerivado3 obsidiana;


    private PropiedadesGenerales propiedadesGenerales;
    public void setPropiedadesGenerales(string nombre, int vida, string descripcion, int cantidad)
    {
        //Inicializo la variable
        propiedadesGenerales = new PropiedadesGenerales();
        //Asigna valores a las variables
        propiedadesGenerales.nombre = nombre;
        propiedadesGenerales.vida = vida;
        propiedadesGenerales.descripcion = descripcion;
        propiedadesGenerales.cantidad = cantidad;

    }

    public PropiedadesGenerales getPropiedadesGenerales()
    {
        return propiedadesGenerales;
    }


    private void Start()
    {
        espadaDiamante = new ItemDerivado();

        espadaDiamante.setPropiedades("Arma", "Legendario", "Aumentar ataque");

        //espadaDiamante.PrintPropierties();


        polloAsado = new ItemDerivado2();

        polloAsado.setPropiedades("Comida", "Normal", "Aumentar vida");

        //polloAsado.PrintPropierties();


        obsidiana = new ItemDerivado3();

        obsidiana.setPropiedades("Material", "Raro", "Aumentar defensa");

        //obsidiana.PrintPropierties();

        
    }


}