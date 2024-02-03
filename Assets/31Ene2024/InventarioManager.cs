using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ItemDerivado;

public class InventarioManager : MonoBehaviour
{
    public Inventario inventario;
    public ItemDerivado pollito;
    public ItemDerivado obsidiana;
    public ItemDerivado espadadediam;


    private void Awake()
    {

        inventario = new Inventario();


        pollito = new ItemDerivado("Pollito", Resources.Load<Sprite>("Sprites/pollito"), 10, "Un pollito que puede ser utilizado como alimento.", 10, Tipo.Comida, Rareza.Normal, Habilidad.AumentarVida);

        obsidiana = new ItemDerivado("Obsidiana", Resources.Load<Sprite>("Sprites/obsidiana"), 20, "Una roca dura y resistente.", 5, Tipo.Material, Rareza.Normal, Habilidad.AumentarDefensa);

        espadadediam = new ItemDerivado("Espada de Diamante", Resources.Load<Sprite>("Sprites/espadadediam"), 30, "Una espada de diamante poderosa.", 3, Tipo.Arma, Rareza.Raro, Habilidad.AumentarAtaque);

    }


    private void Start()
    {
        inventario.AgregarItem(new ItemBase {itemType = ItemType.Item, nombre = pollito.nombre, sprite = pollito.sprite, vida = pollito.vida, descripcion = pollito.descripcion, cantidad = 1});
        inventario.AgregarItem(new ItemBase {itemType = ItemType.Item, nombre = obsidiana.nombre, sprite = obsidiana.sprite, vida = obsidiana.vida, descripcion = obsidiana.descripcion, cantidad = 1});
        inventario.AgregarItem(new ItemBase {itemType = ItemType.Item, nombre = espadadediam.nombre, sprite = espadadediam.sprite, vida = espadadediam.vida, descripcion = espadadediam.descripcion, cantidad = 1});
    }
}