using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LV4_OpenUpAccess : MonoBehaviour
{
	private BoxCollider boxCollider;
	private string mWord;
	private bool EnterCollision = false;
	private bool click = false;
	private bool openUp = false;
	private float ControlTime = 0;

	// Start is called before the first frame update
	void Start()
    {
		boxCollider = gameObject.GetComponent<BoxCollider>();
	}

    // Update is called once per frame
    void FixedUpdate()
    {

    }

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("PlayerA") || collision.gameObject.CompareTag("PlayerB"))
		{
			EnterCollision = true;
		}

		if (openUp)
		{
			EnterCollision = false;
		}
	}


	private void OnCollisionStay(Collision collision)
	{
		if (collision.gameObject.CompareTag("PlayerA") || collision.gameObject.CompareTag("PlayerB"))
		{
			EnterCollision = true;

		}
		if (openUp)
		{
			EnterCollision = false;
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		EnterCollision = false;
	}


	/*
	//digita password
	void OnGUI()
	{

		if (EnterCollision)
		{
			var centeredStyleLabel = GUI.skin.GetStyle("Label");
			centeredStyleLabel.alignment = TextAnchor.UpperCenter;

			GUI.Label(new Rect(Screen.width / 2 - 80, Screen.height / 2 - 25, 180, 100), "Inserisci password per passare", centeredStyleLabel);


			mWord = GUI.TextField(new Rect(Screen.width / 2 - 50, (Screen.height / 2 - 25)+20, 100, 30), mWord);

			
			if(GUI.Button(new Rect(Screen.width / 2 - 50, (Screen.height / 2 - 25) + 52, 100, 20), "Ok"))
			{
				click = true;
			}

			if (mWord == "serpente" && click)
			{
				boxCollider.isTrigger = true;
				EnterCollision = false;
				openUp = true;
			}
		}


		if (openUp && ControlTime < 60)
		{
			var centeredStyleLabel = GUI.skin.GetStyle("Label");
			centeredStyleLabel.alignment = TextAnchor.UpperCenter;

			GUI.Label(new Rect(Screen.width / 2 - 80, Screen.height / 2 - 25, 180, 100), "Passaggio Aperto", centeredStyleLabel);
			ControlTime++;
		}
		}

		*/
		
		
	}

