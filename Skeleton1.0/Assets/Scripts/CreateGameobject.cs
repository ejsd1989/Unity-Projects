using UnityEngine;
using System.Collections;

public class CreateGameobject : MonoBehaviour {

	public GameObject btn1Prefab;

	void Start() {

	}

	public void CreatePrefab() {
		Debug.Log("Triggered");
		Vector3 mousePos = Input.mousePosition;
		mousePos = Camera.main.ScreenToWorldPoint (mousePos);
		Instantiate(btn1Prefab, mousePos, Quaternion.identity);


	
//		if(btn1Prefab.rigidbody == null)
//			btn1Prefab.AddComponent<Rigidbody>();
//		btn1Prefab.rigidbody.useGravity = false;
//		btn1Prefab.transform.position = new Vector3(15, 15, 0);
	}
}
