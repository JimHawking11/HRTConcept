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
		CrowdCheer cheerScript = transform.parent.gameObject.GetComponent<CrowdCheer>();
		cheerScript.PlayCheerAudio(); 
		Destroy(this.gameObject);
	}
}

