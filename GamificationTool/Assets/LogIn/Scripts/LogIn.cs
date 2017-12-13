using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogIn : MonoBehaviour {

	public InputField userID;
	public InputField password;

	public Text errorText;
	// Use this for initialization
	void Start () {
		errorText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void tryLogIn(){
		if (CheckUser ()) {
			SceneManager.LoadScene("MainMenu");
		}
	}

	public bool CheckUser(){
		Debug.Log (userID.text);
		Debug.Log (password.text);
		if (userID.text == "Alex" && password.text == "sofdos") {
			return true;
		} else {
			errorText.text = "User or Password Incorrect.";
			return false;
		}
	}


}
