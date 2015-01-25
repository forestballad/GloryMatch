using UnityEngine;
using System.Collections;

public class FadeToBlack : MonoBehaviour {
	public float FadeSpeed;
	CanvasGroup FadePanel;

	public void Fade(){
		FadePanel = gameObject.GetComponent<CanvasGroup> ();
		FadePanel.alpha = 0;
		StartCoroutine (DoFade ());
	}

	public void Fade(string sceneName){
		FadePanel = gameObject.GetComponent<CanvasGroup> ();
		FadePanel.alpha = 0;
		StartCoroutine (DoFade());
		StartCoroutine (LoadNextScene (sceneName));
	}

	IEnumerator DoFade(){
		while (FadePanel.alpha < 1) {
			FadePanel.alpha += Time.deltaTime/FadeSpeed;
			yield return null;
		}
	}

	IEnumerator LoadNextScene(string sceneName){
		while (FadePanel.alpha < 1) {
			yield return null;
		}
		Application.LoadLevel (sceneName);
		yield return null;
	}
	
}
