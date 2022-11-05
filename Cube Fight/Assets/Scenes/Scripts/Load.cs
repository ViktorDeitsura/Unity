using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
	public static int sceneNum;
   	public Image LoadingImg;
   	public Text progressText;


   	void Start () {
        Debug.Log("Hello: " + sceneNum);
   		StartCoroutine (AsyncLoad ());
   	}

   	IEnumerator AsyncLoad(){
        Debug.Log("AsyncLoad");
   		AsyncOperation operation = SceneManager.LoadSceneAsync (sceneNum);
   		while (!operation.isDone) {
            Debug.Log("While");
   			float progress = operation.progress / 0.9f;
   			LoadingImg.fillAmount = progress;
   			progressText.text = string.Format ("{0:0}%", progress * 100);
   			yield return null;

   		}
   	}
}
