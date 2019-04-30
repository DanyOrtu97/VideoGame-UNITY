using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Controllo apertura animazione porte*/
public class DoorControllerLeft : MonoBehaviour
{
    public bool isOpen = false;
    public float startAngle;
    public float speed = 3;


    void Update()
    {
        if (isOpen)
        {
            Open();
        }
        else
        {
            Close();
        }
    }
    void Open()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, startAngle + 90, 0), Time.deltaTime * speed);
    }



    void Close()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, startAngle, 0), Time.deltaTime * speed);
    }
}
