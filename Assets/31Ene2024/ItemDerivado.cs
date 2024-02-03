using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDerivado : ItemBase
{
    // Propiedades adicionales específicas de los objetos derivados
    public enum Tipo
    {
        Comida,
        Material,
        Arma
    }


    public enum Rareza
    {
        Normal,
        Raro,
        Legendario
    }


    public enum Habilidad
    {
        AumentarVida,
        AumentarDefensa,
        AumentarAtaque
    }

    // Constructor de la clase ItemDerivado
    public ItemDerivado(string nombre, Sprite sprite, int vida, string descripcion, int cantidad, Tipo tipo, Rareza rareza, Habilidad habilidad)
        : base(nombre, sprite, vida, descripcion, cantidad)
    {
        // Asignar los valores de las propiedades adicionales específicas de los objetos derivados
        this.tipo = tipo;
        this.rareza = rareza;
        this.habilidad = habilidad;
    }
}