using UnityEngine;
using System.Collections;

public class LionAttack : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter (Collider other) {
		GameObject CollideObject = other.gameObject.transform.parent.gameObject;

		CollideObject.transform.position = new Vector3(0,1,0);
		
		AudioSource screemSound = GetComponent<AudioSource>();
		screemSound.Play();
	}
}
