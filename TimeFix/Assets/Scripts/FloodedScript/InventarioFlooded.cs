using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Gestione dell'inventario per il 3 livello.*/
public class InventarioFlooded : MonoBehaviour
{
    private List<string> inventarioA = new List<string>();
    private List<string> inventarioB = new List<string>();
    public void AddItem(string name, string player)
    {
        if (player.Equals("A"))
        {
            inventarioA.Add(name);
        }
        else
        {
            inventarioB.Add(name);
        }

    }

    /*isValid verifica la completezza dell'inventario di entrambi i giocatori*/
    public bool isValidA()
    {

        if (inventarioA.Contains("Nebulizzatore") && inventarioA.Contains("TurboSpazzola") && inventarioA.Contains("Carburante"))
        {
            return true;
        }
        return false;
    }

    public bool isValidB()
    {

        if (inventarioB.Contains("Nebulizzatore") && inventarioB.Contains("TurboSpazzola") && inventarioB.Contains("Carburante"))
        {
            return true;
        }
        return false;
    }
}
