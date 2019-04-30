using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Rotazione dei collectible*/
public class RotateCollectibleFlooded : MonoBehaviour
{

    private float speed = 5f;

    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, -30, 0) * Time.deltaTime * speed);
    }
}
