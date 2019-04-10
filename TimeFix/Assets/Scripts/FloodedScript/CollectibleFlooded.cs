using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleFlooded : MonoBehaviour
{
    public GameObject controller;
    public string nome;
    public float speed = 1f;
    public Vector3 rotationVector= new Vector3(0, 30, 0);


    private void Start()
    {
        rotationVector = new Vector3(0, 30, 0);
    }

    void FixedUpdate()
    {
        transform.Rotate(rotationVector * Time.deltaTime * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            controller.gameObject.GetComponent<InventarioFlooded>().AddItem(nome, "A");
            this.gameObject.SetActive(false);
        }

        if (other.CompareTag("PlayerB"))
        {
            controller.gameObject.GetComponent<InventarioFlooded>().AddItem(nome, "B");
            this.gameObject.SetActive(false);
        }
    }
}
