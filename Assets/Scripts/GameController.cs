using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public int keyCount = 1;
	public string nextLevel = @"";
	
	public AudioClip levelOverClip;
	
	// Use this for initialization
	public void Start () {
		Screen.orientation = ScreenOrientation.Portrait;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void keyPickedUp ()
	{
		keyCount--;
		if (keyCount <= 0)
		{
			print("Level Over");

			AudioSource audioSource = gameObject.AddComponent<AudioSource>();
			audioSource.clip = levelOverClip;
			audioSource.Play();

			Invoke("goToNextLevel", levelOverClip.length);
		}
	}
	
	public void goToNextLevel ()
	{
		Application.LoadLevel(nextLevel);
	}
}
