using UnityEngine;
using System.Collections;

public class LogoLoader : MonoBehaviour {
	public Sprite Logo01;
	public Sprite Logo02;
	public Sprite Logo03;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<SpriteRenderer> ().sprite = Logo01;
		Invoke ("SwitchLogoTo02", 2f);
		Invoke ("SwitchLogoTo03", 4f);
		Invoke ("FadeToNextScene", 6f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SwitchLogoTo02(){
		gameObject.GetComponent<SpriteRenderer> ().sprite = Logo02;
	}

	void SwitchLogoTo03(){
		gameObject.GetComponent<SpriteRenderer> ().sprite = Logo03;
	}

	void FadeToNextScene(){
		GameObject.Find ("FaderLayer").GetComponent<FadeToBlack> ().Fade("MainMenu");
	}
}
