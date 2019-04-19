using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDownAccess : MonoBehaviour
{
    public Text textA, textB;
    public GameObject infoA, infoB;
    private BoxCollider boxCollider;
    public GameObject PlatrformA, PlatrformB;
    public bool LiamAccess = false;
    private bool RemyCollision = false;
    private bool LiamCollision = false;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = gameObject.GetComponent<BoxCollider>();
	}

    // Update is called once per frame
    void FixedUpdate()
    {

		if (PlatrformA.GetComponent<PlatformControllerAA>().on && PlatrformB.GetComponent<PlatformControllerB>().on)
		{
            LiamAccess = true;
            boxCollider.isTrigger = true;
            textA.text = "Passaggio inferiore aperto per Liam";
            textB.text = "Passaggio inferiore aperto per Liam";
        }

	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("PlayerA") && LiamAccess && RemyCollision)
        {
            LiamCollision = true;
            LiamAccess = true;
        }

        if (collision.gameObject.CompareTag("PlayerA") && LiamAccess && !RemyCollision)
        {
            boxCollider.isTrigger = true;
            infoA.gameObject.SetActive(true);
            textA.text = "Passaggio aperto";
            LiamCollision = true;
        }

        else if (collision.gameObject.CompareTag("PlayerA") && !LiamAccess)
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Passaggio chiuso";
            LiamCollision = true;
        }

        if (collision.gameObject.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Passaggio chiuso";
            RemyCollision = true;
        }

        if(RemyCollision && LiamCollision && LiamAccess)
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Puo' accedere solo Liam, Remy spostati altrimenti il campo di forza impedira' il passaggio ad entrambi!";
            infoB.gameObject.SetActive(true);
            textB.text = "Puo' accedere solo Liam, Remy spostati altrimenti il campo di forza impedira' il passaggio ad entrambi!";
        }


    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA") && LiamAccess && RemyCollision)
        {
            LiamCollision = true;
            LiamAccess = true;
        }

        if (collision.gameObject.CompareTag("PlayerA") && LiamAccess && !RemyCollision)
        {
            boxCollider.isTrigger = true;
            infoA.gameObject.SetActive(true);
            textA.text = "Passaggio aperto";
            LiamCollision = true;
        }
        else if (collision.gameObject.CompareTag("PlayerA") && !LiamAccess)
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Passaggio chiuso";
            LiamCollision = true;
        }


        if (collision.gameObject.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            RemyCollision = true;
        }

        if (RemyCollision && LiamCollision && LiamAccess)
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Puo' accedere solo Liam, Remy spostati altrimenti il campo di forza impedira' il passaggio ad entrambi!";
            infoB.gameObject.SetActive(true);
            textB.text = "Puo' accedere solo Liam, Remy spostati altrimenti il campo di forza impedira' il passaggio ad entrambi!";
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(false);
            LiamCollision = false;
        }

        if (collision.gameObject.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(false);
            RemyCollision = false;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Passaggio aperto";
        }

        if (other.CompareTag("PlayerB"))
        {
            boxCollider.isTrigger = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Passaggio aperto";

        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            if (other.GetComponent<Transform>().position.y <= 46)
            {
                LiamAccess = false;
                boxCollider.isTrigger = false;           
            }

            infoA.gameObject.SetActive(false);
        }

        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(false);
        }
    }




}
