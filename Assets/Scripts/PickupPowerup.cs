using UnityEngine;
using System.Collections;


public class PickupPowerup : MonoBehaviour {
	
	private bool isCollided = false;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter (Collider other) {
		if (!isCollided){
			GameController gameControllerScript = other.gameObject.GetComponent<GameController>();
			
			if(gameControllerScript)
			{
				isCollided = true;
				gameControllerScript.keyPickedUp();
				
				if(gameControllerScript.keyCount > 0){
					PlayPickupSound audioScript = transform.parent.gameObject.GetComponent<PlayPickupSound>();
					audioScript.PlayPickupAudio();
				}
			
				Destroy(this.gameObject);
			}
		}	
	}
}

