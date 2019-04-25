using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
