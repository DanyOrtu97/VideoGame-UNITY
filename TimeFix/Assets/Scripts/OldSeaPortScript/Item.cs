using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Identità per ogni oggetto raccoglibile
public class Item : MonoBehaviour
{
    
    public int ID;
    public string type;
    public string description;
    public Sprite icon;
    public bool pickedUp;
}
