using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerFlooded : MonoBehaviour
{
    public GameObject luceCentrale;
    public GameObject portale;
    public GameObject infoA;
    public GameObject colliderUscita;
    private int contaLuci=0;
    private int contaChiavi; 
        
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
            luceCentrale.gameObject.GetComponent<Light>().enabled = true;
            portale.gameObject.SetActive(true);
            colliderUscita.gameObject.SetActive(true);
        }
    }

    public void RaccogliChiave()
    {
        contaChiavi++;
    }

    public bool IsOpenRecinto()
    {
        return contaChiavi == 1;
    }
    
}
