using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : MonoBehaviour
{
    //Propiedades comunes de los objetos en el inventario
    public string nombre;
    public Sprite sprite;
    public int vida;
    public string descripcion;
    public int cantidad;

    //Constructor de la clase de ItemBase
    public ItemBase(string nombre, Sprite sprite, int vida, string descripcion, int cantidad)
    {
        //Asigna los valores de las propiedades comunes a los objetos en el inventario
        this.nombre = nombre;
        this.sprite = sprite;
        this.vida = vida;
        this.descripcion = descripcion;
        this.cantidad = cantidad;
    }

    //Método para obtener y asignar las propiedades a los objetos en el inventario
                    //Get: Obtiene
    public string GetNombre()
    { 
        return nombre; 
    }

                    //Set: Asigna
    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public Sprite GetSprite() 
    {
        return sprite;
    }

    public void SetSprite(Sprite sprite)
    {
        this.sprite = sprite;
    }

    public int GetVida()
    {
        return vida;
    }

    public void SetVida(int vida)
    {
        this.vida = vida;
    }

    public string GetDescription()
    {
        return descripcion;
    }

    public void SetDescription(string description)
    {
        this.descripcion= description;
    }

    public int GetCantidad()
    {
        return cantidad;
    }

    public void SetCantidad(int cantidad)
    {
        this.cantidad= cantidad;
    }
}