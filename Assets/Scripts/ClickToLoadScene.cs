using UnityEngine;
using System.Collections;

public class ClickToLoadScene : MonoBehaviour {
	public Sprite ClickImage;
	public string SceneName;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		gameObject.GetComponent<SpriteRenderer> ().sprite = ClickImage;
		GameObject.Find ("FaderLayer").GetComponent<FadeToBlack> ().Fade (SceneName);
	}
}
