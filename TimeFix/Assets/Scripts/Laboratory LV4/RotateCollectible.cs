using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCollectible : MonoBehaviour
{
    private float speed = 5f;
    public GameObject gameController;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime * speed);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PlayerA") && gameController.gameObject.GetComponent<Controller_Laboratory>().getIndiceA() < 5)
        {
            gameController.gameObject.GetComponent<Controller_Laboratory>().collectibleA();
            this.gameObject.SetActive(false);
        }

        if (other.CompareTag("PlayerB") && gameController.gameObject.GetComponent<Controller_Laboratory>().getIndiceB() < 5)
        {
            gameController.gameObject.GetComponent<Controller_Laboratory>().collectibleB();
            this.gameObject.SetActive(false);
        }
    }


}
