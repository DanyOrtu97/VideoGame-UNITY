using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//rotate circle per il loading
public class Loading : MonoBehaviour
{
    public RectTransform loadingImage;
    public float rotation = 0f;

    void Start()
    {
        rotation = 90f;
    }

    void FixedUpdate()
    {
        loadingImage.eulerAngles += new Vector3(0, 0, (rotation%360)) * Time.deltaTime;

    }
}
