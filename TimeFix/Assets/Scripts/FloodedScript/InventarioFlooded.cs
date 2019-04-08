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
    public bool isValid()
    {
        List<string> total = new List<string>();
        total.AddRange(inventarioA);
        total.AddRange(inventarioB);

        if (total.Contains("Nebulizzatore") && total.Contains("TurboSpazzola") && total.Contains("Carburante"))
        {
            return true;
        }
        return false;
    }
}
