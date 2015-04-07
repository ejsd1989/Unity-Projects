using UnityEngine;
using System.Collections;

public class MouseRubberBand : MonoBehaviour
{
	private Vector3 mousePosition;
	private bool isMoving;
	private BoxCollider bxC;
	private GameObject currentPrefab;
	private Rigidbody rbCurrentPrefab;
	private BuildingBlockSnapping snapScript;
	private BoxCollider coll;

	public float moveSpeed = 0.1f;
	
	// Use this for initialization
	void Start () {
		isMoving = true;
		currentPrefab = gameObject;
		bxC = currentPrefab.GetComponent<BoxCollider> ();
		snapScript = GetComponent<BuildingBlockSnapping> ();
		coll = GetComponent<BoxCollider> ();
		// ensure rigidbody attached for Snapping

		if (currentPrefab.rigidbody == null) {
			rbCurrentPrefab = currentPrefab.AddComponent<Rigidbody> ();
			rbCurrentPrefab.isKinematic = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(isMoving) {
			mousePosition = Input.mousePosition;
			mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
			transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);

			coll.size = new Vector3(1.5f, 1.5f, 1.5f);
			bxC.isTrigger = true;

			if (Input.GetMouseButton(1)) {
				isMoving = false;
				bxC.isTrigger = false;
				coll.size = new Vector3(1, 1, 1);

				Destroy(rbCurrentPrefab);
				Destroy(snapScript);
			}
		}
	}
}

