using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerifyRotation : MonoBehaviour
{

	GameObject battery1, battery2, battery3;
	private BoxCollider boxCollider;
	private bool EnterCollision = false;
	private bool Pass = false;
	private int verifyCount = 0;
	private int controlOpen = 0;

	// Start is called before the first frame update
	void Start()
    {
		boxCollider = gameObject.GetComponent<BoxCollider>();
	}

    // Update is called once per frame
    void FixedUpdate()
    {

		

		battery1 = GameObject.FindGameObjectWithTag("battery1"); 
		battery2 = GameObject.FindGameObjectWithTag("battery2");
		battery3 = GameObject.FindGameObjectWithTag("battery3");


		Debug.Log(battery1.transform.eulerAngles.y+" "+ battery2.transform.eulerAngles.y+" "+ battery3.transform.eulerAngles.y);
		if(battery1.transform.eulerAngles.y == 0 
			&& battery2.transform.eulerAngles.y == 90
			&& battery3.transform.eulerAngles.y == 0)
		{
			Pass = true;
			boxCollider.isTrigger = true;
			Debug.Log("Porta Segreta Aperta");
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


	void OnGUI()
	{
		if (EnterCollision && !Pass)
		{
			var centeredStyleLabel = GUI.skin.GetStyle("Label");
			centeredStyleLabel.alignment = TextAnchor.UpperCenter;
			GUI.Label(new Rect(Screen.width / 2 - 80, Screen.height / 2 - 25, 180, 100), "Passaggio chiuso", centeredStyleLabel);
		}

		if (EnterCollision && Pass && controlOpen >0 && controlOpen < 60)
		{
			var centeredStyleLabel = GUI.skin.GetStyle("Label");
			centeredStyleLabel.alignment = TextAnchor.UpperCenter;
			GUI.Label(new Rect(Screen.width / 2 - 80, Screen.height / 2 - 25, 180, 100), "Passaggio chiuso", centeredStyleLabel);
		}

	}





}
