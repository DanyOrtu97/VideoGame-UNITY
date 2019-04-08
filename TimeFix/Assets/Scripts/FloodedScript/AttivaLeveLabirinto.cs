using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttivaLeveLabirinto : MonoBehaviour
{
    public GameObject luce1;
    public GameObject gameController; 
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
            luce1.gameObject.SetActive(true);
            gameController.gameObject.GetComponent<ControllerFlooded>().AddLight();
        }
    }
}
