using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Inventario : MonoBehaviour
{
    // Lista para almacenar los objetos del inventario
    public List<Item> items = new List<Item>();

    // Método para agregar un objeto al inventario
    public void AgregarItem(Item item)
    {
        // Variable para verificar si el item ya existe en el inventario
        bool itemExiste = false;

        // Recorrer la lista de items en el inventario
        foreach (Item i in items)
        {
            // Si el nombre del item coincide con el nombre del item a agregar
            if (i.nombre == item.nombre)
            {
                // Incrementar la cantidad del item existente en el inventario
                i.cantidad += item.cantidad;
                itemExiste = true;
                break;
            }
        }

        // Si el item no existe en el inventario, agregarlo a la lista
        if (!itemExiste)
        {
            items.Add(item);
        }
    }

    // Método para eliminar una cantidad específica de un objeto del inventario
    public void EliminarItem(Item item, int cantidad)
    {
        // Recorrer la lista de items en el inventario
        foreach (Item i in items)
        {
            // Si el nombre del item coincide con el nombre del item a eliminar
            if (i.nombre == item.nombre)
            {
                // Restar la cantidad especificada del item en el inventario
                i.cantidad -= cantidad;

                // Si la cantidad del item es menor o igual a cero, eliminarlo del inventario
                if (i.cantidad <= 0)
                {
                    items.Remove(i);
                }

                break;
            }
        }
    }

    // Método para obtener la cantidad de un objeto en el inventario
    public int GetCantidad(Item item)
    {
        // Recorrer la lista de items en el inventario
        foreach (Item i in items)
        {
            // Si el nombre del item coincide con el nombre del item buscado, devolver la cantidad
            if (i.nombre == item.nombre)
            {
                return i.cantidad;
            }
        }

        // Si el item no se encuentra en el inventario, devolver 0
        return 0;
    }
}