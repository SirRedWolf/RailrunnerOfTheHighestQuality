using UnityEngine;
using System.Collections;

public class WorldGenerator : MonoBehaviour
{
	public Transform[] segmentPrefabs;
	public GameObject player;

	private Transform previousSegment = null;
	private Transform currentSegment;
	private Transform nextSegment;

	public void Start ()
	{
		int whichPrefab;

		whichPrefab = Random.Range (0, segmentPrefabs.Length);
		currentSegment = (Transform)Instantiate (segmentPrefabs [whichPrefab], new Vector3 (0, 0, 0), Quaternion.identity);

		whichPrefab = Random.Range (0, segmentPrefabs.Length);
		currentSegment = (Transform)Instantiate (segmentPrefabs [whichPrefab], new Vector3 (0, 0, 70), Quaternion.identity);
	}
	public void Update ()
	{
		RaycastHit[] hits = Physics.RaycastAll (player.transform.position + Vector3.up, Vector3.down);

		bool onNextSegment = false;

		foreach (RaycastHit hit in hits) {
			if (hit.collider.gameObject.transform.parent == nextSegment) {
				onNextSegment = true;
			}

		}

		if (previousSegment) {
			if (previousSegment != null) {
				Destroy (previousSegment.gameObject);
			}
		}

	}
	
}
