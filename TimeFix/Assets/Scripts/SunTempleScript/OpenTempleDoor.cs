//using SunTemple;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class OpenTempleDoor : MonoBehaviour
{
   
    private List<string> rightStatue = new List<string>();
    public GameObject door;

    public void AddStatue(string tag){
        rightStatue.Add(tag);
        if (rightStatue.Count == 3) {
            door.gameObject.GetComponent<DoorController>().isOpen = true;
        }
    }
    public void RemoveStatue(string tag)
    {
        rightStatue.Remove(tag);
        if (rightStatue.Count == 2)
        {
            door.gameObject.GetComponent<DoorController>().isOpen = false;
        }
        
    }
}
