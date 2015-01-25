using UnityEngine;
using System.Collections;

public class FadeInWhileEnterScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find ("FaderLayer").GetComponent<FadeToClear> ().Fade();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
