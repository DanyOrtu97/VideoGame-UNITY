//using SunTemple;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class OpenTempleDoor : MonoBehaviour
{

    private List<string> rightStatue = new List<string>();
    public GameObject door;
    public GameObject allerGUIA;
    public GameObject allerGUIB;
    private float startTime;

    void FixedUpdate()
    {
        if (rightStatue.Count == 3)//statue corrette da dover girare a 90°
        {
            if (Time.time-startTime > 5&&Time.time - startTime < 6)
            {
                allerGUIA.gameObject.SetActive(false);
                allerGUIB.gameObject.SetActive(false);

            }
        }
    }
    public void AddStatue(string tag)//aggiunta statua posizione corretta
    {
        rightStatue.Add(tag);
        if (rightStatue.Count == 3)
        {
            startTime = Time.time;
            door.gameObject.GetComponent<DoorController>().isOpen = true;
            allerGUIA.gameObject.SetActive(true);
            allerGUIB.gameObject.SetActive(true);
            allerGUIA.gameObject.GetComponent<Text>().text = "Porta Aperta";
            allerGUIB.gameObject.GetComponent<Text>().text = "Porta Aperta";
        }
    }
    public void RemoveStatue(string tag)//rimozione statua dall'elenco delle statue corrette
    {
        rightStatue.Remove(tag);
        if (rightStatue.Count == 2)
        {
            door.gameObject.GetComponent<DoorController>().isOpen = false;
        }

    }
}
