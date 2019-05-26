using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Change : MonoBehaviour {

	public void SceneChange(int SceneNumber) {
		SceneManager.LoadScene (SceneNumber);
	}
}
