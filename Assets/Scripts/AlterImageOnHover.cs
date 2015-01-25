using UnityEngine;
using System.Collections;

public class AlterImageOnHover : MonoBehaviour {
	public Sprite defaultImage;
	public Sprite hoverImage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter() {
		gameObject.GetComponent<SpriteRenderer> ().sprite = hoverImage;
	}

	void OnMouseExit(){
		gameObject.GetComponent<SpriteRenderer> ().sprite = defaultImage;
	}
}
