using UnityEngine;
using System.Collections;

public class PlayPickupSound : MonoBehaviour {
	
	public void PlayPickupAudio () 
	{
		AudioSource PickupSound = GetComponent<AudioSource>();
		PickupSound.Play();
	}
}
