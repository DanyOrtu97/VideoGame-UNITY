using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Slot per l'inventario
public class Slot : MonoBehaviour
{
    public GameObject item;
    public int ID;
    public string type;
    public string description;
    public bool empty;
    public Sprite icon;
    public Transform slotIconGO;
    public Sprite emptyIcon;

    public void Start()
    {
        slotIconGO = transform.GetChild(0);
    }

    public void UpdateSlot()
    {
        slotIconGO.GetComponent<Image>().sprite = icon;
    }

    public void freeSlot()
    {
        item = null;
        ID = 0;
        type = "";
        description = "";
        empty = true;
        icon = emptyIcon;
        slotIconGO.GetComponent<Image>().sprite = icon;

    }
}
