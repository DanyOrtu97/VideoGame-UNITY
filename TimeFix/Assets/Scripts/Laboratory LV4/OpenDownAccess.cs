using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDownAccess : MonoBehaviour
{
	private BoxCollider boxCollider;
	private bool EnterCollision = false;
	private int verifyCount = 0;
	private GameObject Player;
	private int controlOpen = 0;
	private float timeToAppearClose = 0f;

	// Start is called before the first frame update
	void Start()
    {
		boxCollider = gameObject.GetComponent<BoxCollider>();
	}

    // Update is called once per frame
    void FixedUpdate()
    {

		Player = GameObject.FindGameObjectWithTag("Player");

		if (Player.GetComponent<PlayerController>().unlock)
		{
			boxCollider.isTrigger = true;
			EnterCollision = false;
		}


		if(timeToAppearClose > 3)
		{
			EnterCollision = false;
			timeToAppearClose = 0;
		}




	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			EnterCollision = true;
		}
	}

	private void OnCollisionStay(Collision collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			EnterCollision = true;
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		EnterCollision = false;
	}


	private void OnTriggerEnter(Collider other)
	{
		controlOpen++;
	}

	private void OnTriggerStay(Collider other)
	{
		controlOpen++;
	}

	private void OnTriggerExit(Collider other)
	{
		controlOpen+=30;
	}


	void OnGUI()
	{

		if (EnterCollision)
		{
			timeToAppearClose = Time.time;
			var centeredStyleLabel = GUI.skin.GetStyle("Label");
			centeredStyleLabel.alignment = TextAnchor.UpperCenter;

			GUI.Label(new Rect(Screen.width / 2 - 80, Screen.height / 2 - 25, 180, 100), "Passaggio Chiuso", centeredStyleLabel);
		}

		if (Player.GetComponent<PlayerController>().unlock && controlOpen> 0 && controlOpen < 60)
		{
			var centeredStyleLabel = GUI.skin.GetStyle("Label");
			centeredStyleLabel.alignment = TextAnchor.UpperCenter;

			GUI.Label(new Rect(Screen.width / 2 - 80, Screen.height / 2 - 25, 180, 100), "Passaggio Aperto", centeredStyleLabel);
			
		}



	}

}
