using UnityEngine;
using System.Collections;

public class CrowdCheer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void PlayCheerAudio () 
	{
		AudioSource cheerSound = GetComponent<AudioSource>();
		cheerSound.Play();
	}
}
