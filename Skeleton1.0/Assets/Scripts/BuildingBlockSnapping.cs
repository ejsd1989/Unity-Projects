using UnityEngine;
using System.Collections;

public class BuildingBlockSnapping : MonoBehaviour {

	private Collider coll;
	private GameObject go;

	// Use this for initialization
	void Start () {
		coll = GetComponent<Collider> ();
		go = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider c) {
		Debug.Log ("collision entered");

		// when within collision distance to another building
		// block side, snap to nearest surface.

		Vector3 closestPoint = c.ClosestPointOnBounds (gameObject.transform.position);

		float distX = Vector3.Distance (gameObject.transform.position, closestPoint);

		// Offset of gameobject scale width

		Vector3 gameObjectScaleOffset = new Vector3 (c.transform.localScale.x / 2, 0, 0);

		closestPoint += gameObjectScaleOffset;

//		Vector3 snapVector = Vector3.Distance(gameObject.transform.position, c.transform.position);
//		Vector3 current = gameObject.transform.position;
//		Vector3 collider = c.transform.position;
//		Vector3 newPos;
//		newPos.x = current.x - collider.x;
//		newPos.y = current.y - collider.y;
//		newPos.z = current.z - collider.z;

//		closestPoint += new Vector3 (0.25f, 0, 0);

		gameObject.transform.position = closestPoint;
	}

	void SnapToNearestEdge() {

	}
}
