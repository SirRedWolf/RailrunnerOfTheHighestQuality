using UnityEngine;
using System.Collections;

public class FlatPillarController : MonoBehaviour
{

	public Transform topEndpoint;
	public Transform bottomEndpoint;
	public float speed = 0.1f;
	
	private int direction = 1;
	
	public void Update ()
	{
		transform.Translate (0, direction * speed, 0);

		
		if (transform.position.x >= bottomEndpoint.localPosition.y) {
			direction = -1;
		} else if (transform.position.x <= topEndpoint.localPosition.y) {
			direction = 1;
		}
	}
	

}
