using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolTip : MonoBehaviour {

	public Text name;
	public Text docket;
	public Text team;

	public GameObject target;

	void Start(){
		gameObject.SetActive (false);
	}


	void Update () {
		transform.position = Input.mousePosition;
		if (target != null) {
			if (Vector3.Distance (this.transform.position, target.transform.position) > 50.0f) {
				gameObject.SetActive (false);
				target = null;
			}
		} else {
			target = null;
		}
	}
}
