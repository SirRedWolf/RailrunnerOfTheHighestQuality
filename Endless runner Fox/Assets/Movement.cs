using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
	public Rigidbody body;
	public float jumpHeight = 5.0f;
	public float standardSpeed = 10.0f;
	Vector3 standardMovement;
	Vector3 jumpMovement;
	public bool isGrounded = true;

	public void Start ()
	{

		body = GetComponent <Rigidbody> ();
		standardMovement = new Vector3 (0.0f, 0.0f, standardSpeed);
		jumpMovement = new Vector3 (0.0f, jumpHeight, standardSpeed);
		body.velocity = standardMovement;
	}


	void FixedUpdate ()
	{
		isGrounded = Physics.Raycast (transform.position, Vector3.down, .51f);

		if (isGrounded && Input.GetKey (KeyCode.Space)) {

			body.velocity = jumpMovement;

		} else if (isGrounded) {

			body.velocity = standardMovement;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (-1, 0, 0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (1, 0, 0);

		}
	}
	// Update is called once per frame
	public void OnCollisionEnter (Collision col)
	{
		{
			if (col.gameObject.tag == "Obstacle")
			if (col.contacts [0].normal.y <= 0)
				Application.LoadLevel ("FreeCharacter_Sceen");
		}
	
	}
}
