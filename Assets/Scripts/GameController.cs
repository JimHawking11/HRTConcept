using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public int keyCount = 1;
	public string nextLevel = @"";
	
	// Use this for initialization
	void Start () {
	
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
			Application.LoadLevel(nextLevel);
		}
	}
}
