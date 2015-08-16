using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CompassController : MonoBehaviour {

	public GameObject playerObject;
	public Image compassRing;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float yRotation = playerObject.transform.rotation.eulerAngles.y;
		
		print ("Rotation = " + yRotation);
		compassRing.transform.eulerAngles = new Vector3(0, 0, yRotation);
	}
}
