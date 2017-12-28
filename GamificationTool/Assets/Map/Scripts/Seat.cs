using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seat : MonoBehaviour {

	public string name;
	public int docket;
	public string team;
	private ToolTip _ToolTip;
	//Function that shows on the ToolTip the information of this seat.
	public void ShowInfo(){
		_ToolTip.gameObject.SetActive (true);
		_ToolTip.name.text = name;
		_ToolTip.docket.text = docket.ToString();
		_ToolTip.team.text = team;
		_ToolTip.target = this.gameObject;
	}

	void Awake(){
		_ToolTip = GameObject.Find ("ToolTip").GetComponent<ToolTip>();
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
