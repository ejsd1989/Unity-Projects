using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIHandler : MonoBehaviour {
	
	public Button button1;
	public GameObject btn1Prefab;
	
	void OnGUI() {
	
	}

	void Update() {
//		button1.onClick(){
//			CreatePrefab();
//		};
	}

	public void CreatePrefab() {
		Debug.Log("Triggered");
		Instantiate(btn1Prefab);
	}
}
