using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonManager : MonoBehaviour {

	public Object nextScene;


	public void ChangeScene(){
		SceneManager.LoadScene (nextScene.name);
	}

}
