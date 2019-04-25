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
    public int numberSlot = 6;

    public GameObject slotHolder;

    public GameObject alertGUI;

    public GameObject gameController;


    private void Start()
    {
        allSlots = numberSlot;
        slot = new GameObject[allSlots];

        for (int i = 0; i < allSlots; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;

            if (slot[i].GetComponent<Slot>().item == null)
            {
                slot[i].GetComponent<Slot>().empty = true;
            }
        }
    }


    private void Update()
    {
        if (this.gameObject.CompareTag("PlayerA"))
        {


            //INTERFACE a
            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInventario"]) && inventoryEnabled)
            {

                inventoryEnabled = !inventoryEnabled;
                inventory.SetActive(false);
            }
            else if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInventario"]) && !inventoryEnabled)
            {

                inventoryEnabled = !inventoryEnabled;
                inventory.SetActive(true);

            }
        }
        else
        {
            //INTERFACE b
            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInventario"]) && inventoryEnabled)
            {
                inventoryEnabled = !inventoryEnabled;

                inventory.SetActive(false);
            }
            else if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInventario"]) && !inventoryEnabled)
            {
                inventoryEnabled = !inventoryEnabled;
                inventory.SetActive(true);

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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            alertGUI.gameObject.SetActive(true);
            alertGUI.gameObject.GetComponent<Text>().text = "Premi E per raccogliere";
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                GameObject itemPickedUp = collision.gameObject;
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

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            alertGUI.gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Item"))
        {
            alertGUI.gameObject.SetActive(true);
            alertGUI.gameObject.GetComponent<Text>().text = "Premi E per raccogliere";
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.CompareTag("Item"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                GameObject itemPickedUp = collision.gameObject;
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

    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Item"))
        {
            alertGUI.gameObject.SetActive(false);
        }
    }


    void AddItem(GameObject itemObject, int itemID, string itemType, string itemDescription, Sprite itemIcon)
    {
        for (j = j; j < allSlots; j++)
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
                j++;
            }
            return;
        }
    }


    public void removeItemByType(string tipo)
    {
        int countDeletedItems = 0;

        for (int i = 0; i < allSlots; i++)
        {
            if (slot[i].GetComponent<Slot>().type.Equals(tipo))
            {
                countDeletedItems++;

                slot[i].GetComponent<Slot>().freeSlot();
            }
        }

        for (int i = 0; i < countDeletedItems; i++)
        {
            j--;
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

