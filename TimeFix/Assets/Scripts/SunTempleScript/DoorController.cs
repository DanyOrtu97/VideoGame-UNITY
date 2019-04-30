using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Controller apertura porta, con rotazione 
public class DoorController : MonoBehaviour
{
    public bool isOpen=false;
    public float startAngle;
    public float speed = 3;


    // Update is called once per frame
    void Update()
    {
        if (isOpen)
        {
            Open();
        }
        else {
            Close();
        }
    }
    void Open()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, startAngle-90, 0), Time.deltaTime * speed);
    }



    void Close()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, startAngle, 0), Time.deltaTime * speed);
    }
}
