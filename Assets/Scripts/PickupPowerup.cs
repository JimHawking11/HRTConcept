using UnityEngine;
using System.Collections;


public class PickupPowerup : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter (Collider other) {
		PlayPickupSound audioScript = transform.parent.gameObject.GetComponent<PlayPickupSound>();
		audioScript.PlayPickupAudio(); 
		Destroy(this.gameObject);
	}
}

