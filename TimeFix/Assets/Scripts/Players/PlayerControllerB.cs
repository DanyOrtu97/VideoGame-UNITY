using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllerB : MonoBehaviour
{
    public Text textB;
    public Image sprite1, sprite2, sprite3, sprite4, sprite5;
    public GameObject infoB;
    private Animator animator;
	private CharacterController controller;
	private float speed = 2f;
	private float jumpForce = 10f;
	private float gravity = 30f;
	private float rotation = 0f;
	public float timeToGathering = 0f;
	public float turnSpeed = 2f;
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


		float z = Input.GetAxis("VerticalB");
		float x = Input.GetAxis("HorizontalB");



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

		if (Input.GetKeyDown(KeyCode.Space))
		{
			moveDir.y = jumpForce;
			animator.SetBool("Jump", true);
		}
		else
		{
			animator.SetBool("Jump", false);
		}

		if (Input.GetKeyDown(KeyCode.F) && tmp == false)
		{
			animator.SetBool("Take", true);
			timeToGathering = Time.time;
		}

		moveDir.x = 0;
		moveDir.z = 0;
		moveDir.y -= gravity * Time.deltaTime;
		controller.Move(moveDir * Time.deltaTime);



		//esplosione finale
		if (Input.GetKeyDown(KeyCode.Z))
		{
			Explosion();
		}


        //HINTS
        if (Input.GetKeyDown(KeyCode.X))
        {
            openHint = true;
        }



    }

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Collectible") && indice < 5)
		{
			other.gameObject.SetActive(false);
			Collectible[indice] = 1;

            switch (indice)
            {
                case 0:
                    sprite1.gameObject.SetActive(true);
                    break;
                case 1:
                    sprite2.gameObject.SetActive(true);
                    break;
                case 2:
                    sprite3.gameObject.SetActive(true);
                    break;
                case 3:
                    sprite4.gameObject.SetActive(true);
                    break;
                case 4:
                    sprite5.gameObject.SetActive(true);
                    break;
            }
            indice++;
        }

        if (other.CompareTag("Collectible") && indice == 5)
        {
            textB.text = "Massima capienza raggiunta!";
            infoB.gameObject.SetActive(true);
        }

	}



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "console" && !openHint)
        {
            textB.text = "Premi X per leggere!";
            infoB.gameObject.SetActive(true);
        }

        if (collision.gameObject.CompareTag("PlayerA"))
        {
            unlock = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        infoB.gameObject.SetActive(false);
        openHint = false;
        
    }


    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "console" && !openHint)
        {
            textB.text = "Premi X per leggere!";
            infoB.gameObject.SetActive(true);
        }
        else
        {
            infoB.gameObject.SetActive(false);
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

		if (conta == 5)
		{
			Debug.Log("Esplosione atomicaB");
		}
	}

}