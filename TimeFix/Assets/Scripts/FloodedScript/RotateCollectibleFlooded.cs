using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCollectibleFlooded : MonoBehaviour
{

    private float speed = 5f;


    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, -30, 0) * Time.deltaTime * speed);
    }
}
