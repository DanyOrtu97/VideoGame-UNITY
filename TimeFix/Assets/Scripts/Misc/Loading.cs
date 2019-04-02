using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour
{

    public RectTransform loadingImage;
    public float rotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rotation = 90f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        loadingImage.eulerAngles += new Vector3(0, 0, (rotation%360)) * Time.deltaTime;

    }
}
