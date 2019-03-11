using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LiamMovement : NetworkBehaviour
{

	private Animator animator;
	private Rigidbody rb;
	public float speed = 1f;
	public float velocity = 0;
	public float turnSpeed = 1f;
	public float turnVelocity = 0.1f;
	public float time = 0f;
	public bool tmp = false;
    public int life = 100;
    public bool died = false;

	// Start is called before the first frame update
	void Start()
    {
		animator = GetComponent<Animator>();
		rb = this.gameObject.GetComponent<Rigidbody>();
    }

	// Update is called once per frame

    void FixedUpdate()
    {
        if (hasAuthority == false) {
            return;
        }
		float y = Input.GetAxis("Vertical");
		float x = Input.GetAxis("Horizontal");
		velocity = y * speed;

		turnVelocity = x * turnSpeed;

		animator.SetBool("Kick", false);
		animator.SetBool("Punch", false);


		if (velocity != 0 && ( ((Time.time - time) > 4.7) || time == 0))
		{
			time = 0f;
			animator.SetBool("Take", false);
			animator.SetBool("IsMoving", true);
			animator.SetFloat("Velocity", y);
			animator.SetBool("Fight", false);
			
			tmp = true;
			rb.velocity = transform.forward * velocity;
		}
		else
		{
			animator.SetBool("IsMoving", false);
			animator.SetBool("Take", false);
			tmp = false;
		}


		if (Input.GetKeyDown(KeyCode.F) && tmp==false)
		{
			animator.SetBool("Take", true);
			time = Time.time;
		}

        CapsuleCollider collider = this.gameObject.GetComponent<CapsuleCollider>();

		if (Input.GetKeyDown(KeyCode.Space) )
		{
			animator.SetBool("Jump", true);
		}
		else
		{
           animator.SetBool("Jump", false);
        }
		

		Vector3 rotationToApply = new Vector3(0, turnVelocity, 0);

		rb.rotation = Quaternion.Euler(rb.rotation.eulerAngles + rotationToApply);

		animator.SetFloat("TurnRate", x);

        if(life <= 0)
        {
            animator.SetBool("Died", true);
            died = true;
        }

        /*
        if (died)
        {
            Destroy(this.gameObject);
        }
		*/

		if (Input.GetKeyDown(KeyCode.G))
		{
			animator.SetBool("Fight", true);

		}

		if (Input.GetKeyDown(KeyCode.Q))
		{
			animator.SetBool("Kick", true);
		}

		if (Input.GetKeyDown(KeyCode.E))
		{
			animator.SetBool("Punch", true);
		}
	}
}
