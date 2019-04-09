using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerFlooded : MonoBehaviour
{
    public GameObject luceCentrale;
    public GameObject portale;
    private int contaLuci=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddLight()
    {

        contaLuci++;
        if(contaLuci == 4)
        {
            luceCentrale.gameObject.SetActive(true);
            portale.gameObject.SetActive(true);

        }
    }
}
