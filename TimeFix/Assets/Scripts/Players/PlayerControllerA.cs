using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllerA : MonoBehaviour
{
    public Text textA;
    public Image sprite;
    public GameObject infoA;
    private Animator animator;
	private CharacterController controller;
	private float speed = 4f;
	private float jumpForce = 10f;
	private float gravity = 30f;
	private float rotation = 0f;
	public float timeToGathering = 0f;
	public float turnSpeed = 4f;
	private Vector3 moveDir;
	public bool tmp = false;
	public bool unlock = false;
	public bool finalStage = false;
    public bool openHint = false;

    //da implemetare per i collectible
    public int[] Collectible;
	private int indice = 0;

	private void Awake()
	{
	}


	// Start is called before the first frame update
	void Start()
	{
		animator = GetComponent<Animator>();
		controller = gameObject.GetComponent<CharacterController>();
		indice = 0;
		Collectible = new int[] { 4, 4, 4, 4, 4 };
	}

	// Update is called once per frame
	void FixedUpdate()
	{

		/*
		 * 
		 * movimenti
		 */


		float z = Input.GetAxis("VerticalA");
		float x = Input.GetAxis("HorizontalA");



		if (z != 0 && (((Time.time - timeToGathering) > 4.8) || timeToGathering == 0) /*&& !died*/)
		{
			animator.SetFloat("Velocity", z);
			animator.SetBool("Jump", true);
			animator.SetBool("IsMoving", true);
			moveDir = new Vector3(0, 0, z);
			moveDir = transform.TransformDirection(moveDir);
			moveDir *= speed;
			controller.Move(moveDir * Time.deltaTime);

			tmp = true;
		}
		else
		{
			tmp = false;
			animator.SetBool("IsMoving", false);
			animator.SetBool("Take", false);
		}

		rotation += x * turnSpeed;
		transform.eulerAngles = new Vector3(0, rotation, 0);

		if (Input.GetKeyDown(KeyCode.PageDown))
		{
			moveDir.y = jumpForce;
			animator.SetBool("Jump", true);
		}
		else
		{
			animator.SetBool("Jump", false);
		}

		if (Input.GetKeyDown(KeyCode.P) && tmp == false)
		{
			animator.SetBool("Take", true);
			timeToGathering = Time.time;
		}

		moveDir.x = 0;
		moveDir.z = 0;
		moveDir.y -= gravity * Time.deltaTime;
		controller.Move(moveDir * Time.deltaTime);



		//esplosione finale
		if (Input.GetKeyDown(KeyCode.K))
		{
			Explosion();
			finalStage = false;
		}


		//HINTS
		if (Input.GetKeyDown(KeyCode.H))
		{
			openHint = true;
		}

	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Collectible") && indice < 5)
		{
			other.gameObject.SetActive(false);
            sprite.gameObject.SetActive(true);
            Collectible[indice] = 1;
			indice++;
		}
        else
        {
            textA.text = "Massima capienza raggiunta!";
            infoA.gameObject.SetActive(true);
        }

        if (other.CompareTag("FinalStage"))
		{
            finalStage = true;
		}

		if (other.name == "Secret Room")
		{
			finalStage = false;
		}

	}

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("FinalStage"))
        {
            finalStage = true;
        }
    }


    private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "console" && !openHint)
		{
            textA.text = "Premi H per leggere!";
            infoA.gameObject.SetActive(true);
        }


		if (collision.gameObject.CompareTag("PlayerB"))
		{
			unlock = true;
		}
	}

	private void OnCollisionExit(Collision collision)
	{
        infoA.gameObject.SetActive(false);
        openHint = false;
    }


	private void OnCollisionStay(Collision collision)
	{
        if (collision.gameObject.name == "console" && !openHint)
        {
            textA.text = "Premi H per leggere!";
            infoA.gameObject.SetActive(true);
        }
        else
        {
            infoA.gameObject.SetActive(false);
        }
    }

	private void Explosion()
	{
		int conta = 0;

		for (int i = 0; i < 5; i++)
		{
			if (Collectible[i] == 1)
			{
				conta++;
			}
		}

		if (conta == 2)
		{
			Debug.Log("Esplosione atomica");
		}
	}
}


