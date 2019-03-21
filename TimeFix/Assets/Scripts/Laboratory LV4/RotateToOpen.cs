using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToOpen : MonoBehaviour
{
	private Transform transform;
	private bool checkCollision = false;
	private BoxCollider boxCollider;
	

	// Start is called before the first frame update
	void Start()
	{
		transform = gameObject.GetComponent<Transform>();
		boxCollider = gameObject.GetComponent<BoxCollider>();
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			checkCollision = true;
			if (Input.GetKeyDown(KeyCode.R))
			{
				transform.eulerAngles += new Vector3(0, 90, 0);
			}
		}
	}

	private void OnCollisionStay(Collision collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			checkCollision = true;
			if (Input.GetKeyDown(KeyCode.R))
			{
				if (transform.eulerAngles.y == 270)
				{
					transform.eulerAngles = new Vector3(0,0,0);
				}
				else
				{
					transform.eulerAngles += new Vector3(0, 90, 0);
				}
			}
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		checkCollision = false;
	}


	void OnGUI()
	{
		if (checkCollision)
		{
			var centeredStyleLabel = GUI.skin.GetStyle("Label");
			centeredStyleLabel.alignment = TextAnchor.UpperCenter;
			GUI.Label(new Rect(Screen.width / 2 - 80, Screen.height / 2 - 25, 180, 100), "Premi R per ruotare", centeredStyleLabel);
		}
	}
}
