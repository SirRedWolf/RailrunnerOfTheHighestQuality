using UnityEngine;
using System.Collections;

public class PillarController : MonoBehaviour
{
	public Transform rightEndpoint;
	public Transform leftEndpoint;
	public float speed = 0.1f;

	private int direction = 1;

	public void Update ()
	{
		transform.Translate (direction * speed, 0, 0);
		Debug.Log (transform.position);

		if (transform.position.x >= rightEndpoint.localPosition.x) {
			direction = -1;
		} else if (transform.position.x <= leftEndpoint.localPosition.x) {
			direction = 1;
		}
	}
}


