using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Apertura porte generico, derivante da asset esternis*/
public class OpenDoor : MonoBehaviour
{
	public bool colliderr = false;

	private Animator animator;
	// Start is called before the first frame update
	void Start()
	{
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		if (colliderr)
		{
			animator.SetBool("character_nearby", true);
		}
		else
		{
			animator.SetBool("character_nearby", false);
		}
	}


	private void OnTriggerEnter(Collider other)
	{
		if (other.attachedRigidbody)
		{
			colliderr = true;
		}
	}


	private void OnTriggerExit(Collider other)
	{
		if (other.attachedRigidbody)
		{
			colliderr = false;
		}
	}
}
