using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Inventario Helios
public class InventorySunTemple : MonoBehaviour
{
    [Serializable]
    public struct Dict {//Dizionario per l'assegnazione di oggetti e sprite
        public string name;
        public Sprite image;
    }
    public Dict[] listSprite;
    private List<string> inventarioA =new List<string>();
    private List<string> inventarioB = new List<string>();
    public GameObject[] boxSpriteA;//box dell'inventario
    public GameObject[] boxSpriteB;

    private bool inventoryEnabledA = true, inventoryEnabledB = true;
    public GameObject InterfaceCollectibleA, InterfaceCollectibleB;

    private void Update()
    {
        //Apertura e chiusura inventario A
        if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInventario"]) && inventoryEnabledA)
        {
            Debug.Log("AInventario");
            inventoryEnabledA = !inventoryEnabledA;

            InterfaceCollectibleA.SetActive(false);
        }
        else if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInventario"]) && !inventoryEnabledA)
        {
            Debug.Log("AInventario");
            inventoryEnabledA = !inventoryEnabledA;
            InterfaceCollectibleA.SetActive(true);

        }




        //Apertura e chiusura inventario B
        if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInventario"]) && inventoryEnabledB)
        {
            Debug.Log("BInventario");
            inventoryEnabledB = !inventoryEnabledB;

            InterfaceCollectibleB.SetActive(false);
        }
        else if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInventario"]) && !inventoryEnabledB)
        {
            Debug.Log("BInventario");
            inventoryEnabledB = !inventoryEnabledB;
            InterfaceCollectibleB.SetActive(true);

        }
    }
    public void AddItem(string name,string player) {//aggiunta dell'elemento sia nella lista che nei vari box
        Sprite add=null;
        foreach( Dict it in listSprite){
            if(it.name.Equals(name)){
                add=it.image;
            }
        }
        if (player.Equals("A"))
        {
            inventarioA.Add(name);
            boxSpriteA[inventarioA.Count-1].gameObject.GetComponent<Image>().sprite=add;

        }
        else {
            inventarioB.Add(name);
            boxSpriteB[inventarioB.Count-1].gameObject.GetComponent<Image>().sprite=add;
        }
        
    }
    public bool isValid() {//funzione spostamento pietra finale 
        List<string> total = new List<string>();
        total.AddRange(inventarioA);
        total.AddRange(inventarioB);

        if (total.Contains("Fulcro")&& total.Contains("Asse")&& total.Contains("Peso")) {
            return true;
        }
        return false;
    }
}
