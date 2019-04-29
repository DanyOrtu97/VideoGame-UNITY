using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    private bool inventoryEnabled = true;
    public GameObject inventory;

    private int allSlots;
    private int enabledSlots;
    private int j;
    private GameObject[] slot;
    public int numberSlot=6;

    public GameObject slotHolder;

    public GameObject alertGUI;

    public GameObject gameController;


    private void Start()
    {
        allSlots = numberSlot;
        slot = new GameObject[allSlots];

        for(int i = 0; i<allSlots; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;

            if(slot[i].GetComponent<Slot>().item == null)
            {
          
                slot[i].GetComponent<Slot>().empty = true;
            }
        }
    }


    private void Update()
    {
        if (this.gameObject.CompareTag("PlayerA"))
        {
            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInventario"]))
            {
                inventoryEnabled = !inventoryEnabled;
            }

            if (inventoryEnabled == true)
            {
                inventory.SetActive(true);
            }
            else
            {
                inventory.SetActive(false);
            }
        }
        else {
            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInventario"]))
            {
                inventoryEnabled = !inventoryEnabled;
            }

            if (inventoryEnabled == true)
            {
                inventory.SetActive(true);
            }
            else
            {
                inventory.SetActive(false);
            }
        }
           



    }

    /*
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Item")
        {
            GameObject itemPickedUp = other.gameObject;
            Item item = itemPickedUp.GetComponent<Item>();

            AddItem(itemPickedUp, item.ID, item.type, item.description, item.icon);
        }
    }
    */

    
    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.CompareTag("PlayerA"))
        {
            if (other.CompareTag("Item"))
            {
                alertGUI.gameObject.SetActive(true);
                alertGUI.gameObject.GetComponent<Text>().text = "Premi  " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per raccogliere";
            }
        }
        else {
            if (other.CompareTag("Item"))
            {
                alertGUI.gameObject.SetActive(true);
                alertGUI.gameObject.GetComponent<Text>().text = "Premi  " + InputAssign.keyDictInteractString["PlayerBInteract"] + " per raccogliere";
            }
        }
            
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            if (this.gameObject.CompareTag("PlayerA"))
            {
                if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
                {
                    GameObject itemPickedUp = other.gameObject;
                    Item item = itemPickedUp.GetComponent<Item>();

                    AddItem(itemPickedUp, item.ID, item.type, item.description, item.icon);

                    if (item.type.Equals("barca"))
                    {
                        gameController.gameObject.GetComponent<GameController>().setCounterBarca();
                    }

                    if (item.type.Equals("food"))
                    {
                        gameController.gameObject.GetComponent<GameController>().setCounterFood();
                    }

                    if (item.type.Equals("iron"))
                    {
                        gameController.gameObject.GetComponent<GameController2>().setCounterIron();
                    }

                    if (item.type.Equals("tool"))
                    {
                        gameController.gameObject.GetComponent<GameController2>().setCounterTool();
                    }

                    if (item.type.Equals("hammer"))
                    {
                        gameController.gameObject.GetComponent<GameController2>().setCounterHammer();
                    }

                    alertGUI.gameObject.SetActive(false);
                }
            }
            else {
                if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInteract"]))
                {
                    GameObject itemPickedUp = other.gameObject;
                    Item item = itemPickedUp.GetComponent<Item>();

                    AddItem(itemPickedUp, item.ID, item.type, item.description, item.icon);

                    if (item.type.Equals("barca"))
                    {
                        gameController.gameObject.GetComponent<GameController>().setCounterBarca();
                    }

                    if (item.type.Equals("food"))
                    {
                        gameController.gameObject.GetComponent<GameController>().setCounterFood();
                    }

                    if (item.type.Equals("iron"))
                    {
                        gameController.gameObject.GetComponent<GameController2>().setCounterIron();
                    }

                    if (item.type.Equals("tool"))
                    {
                        gameController.gameObject.GetComponent<GameController2>().setCounterTool();
                    }

                    if (item.type.Equals("hammer"))
                    {
                        gameController.gameObject.GetComponent<GameController2>().setCounterHammer();
                    }

                    alertGUI.gameObject.SetActive(false);
                }
            }
           
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            alertGUI.gameObject.SetActive(false);
        }
    }


    void AddItem(GameObject itemObject, int itemID, string itemType, string itemDescription, Sprite itemIcon)
    {
        for (j = 0; j < allSlots; j++)
        {
        
            if (slot[j].GetComponent<Slot>().empty)
            {
             
                itemObject.GetComponent<Item>().pickedUp = true;


                slot[j].GetComponent<Slot>().item = itemObject;
                slot[j].GetComponent<Slot>().icon = itemIcon;
                slot[j].GetComponent<Slot>().type = itemType;
                slot[j].GetComponent<Slot>().description = itemDescription;
                slot[j].GetComponent<Slot>().ID = itemID;


                itemObject.transform.parent = slot[j].transform;
                itemObject.SetActive(false);

                slot[j].GetComponent<Slot>().UpdateSlot();
                slot[j].GetComponent<Slot>().empty = false;

                return;
            }
            
            
        }
    }

    
    public void removeItemByType(string tipo)
    {
        int countDeletedItems = 0;

        for (int i = 0; i < allSlots; i++)
        {
            if(slot[i].GetComponent<Slot>().type.Equals(tipo))
            {
                countDeletedItems++;
               
                slot[i].GetComponent<Slot>().freeSlot();
            }
        }

       
    }

    public bool checkItem(string tipo)
    {

        for (int i = 0; i < allSlots; i++)
        {
            if (slot[i].GetComponent<Slot>().type.Equals(tipo))
            {
                return true;
            }
        }

        return false;
    }
    


    

}

