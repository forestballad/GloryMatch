using UnityEngine;
using System.Collections;

public class FadeToClear : MonoBehaviour {
	public float FadeSpeed;
	
	public void Fade(){
		CanvasGroup canvasGroup = gameObject.GetComponent<CanvasGroup> ();
		canvasGroup.alpha = 1;
		StartCoroutine (DoFade ());
	}
	
	IEnumerator DoFade(){
		CanvasGroup canvasGroup = gameObject.GetComponent<CanvasGroup> ();
		while (canvasGroup.alpha > 0) {
			canvasGroup.alpha -= Time.deltaTime/FadeSpeed;
			yield return null;
		}
	}
}
