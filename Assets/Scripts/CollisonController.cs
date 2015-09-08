using UnityEngine;
using System.Collections;

public class CollisonController : MonoBehaviour {

	Queue collisionQueue; 
	
	// Use this for initialization
	void Start () {
		collisionQueue = new Queue();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter (Collider col)
	{
		string objectName = col.gameObject.name;
		
		if(objectName.Equals("Boundry")){
			//IGNORE
		}else if(collisionQueue.Contains(objectName)){
			//IGNORE
		}else{
			addCollision(objectName);
			print("Trigger Enter " + col.gameObject.name);
		}
	}
	
	void OnTriggerStay (Collider col)
	{
		string objectName = col.gameObject.name;
		
		if(objectName.Equals("Boundry")){
			//IGNORE
		}else if(collisionQueue.Contains(objectName)){
			//IGNORE 
		}else{
			addCollision(objectName);
			print("Trigger Enter " + col.gameObject.name);
		}
	}
	
	void OnTriggerExit (Collider col)
	{
		string objectName = col.gameObject.name;
		
		if(objectName.Equals("Boundry")){
			if(collisionQueue.Contains(objectName)){
				print("Still Colliding - Skipping");
			}else{
				print("Trigger Exit " + col.gameObject.name);
				addCollision(objectName);
			}
		}
	}
	
	void addCollision(string objectName)
	{
		collisionQueue.Enqueue(objectName);
		Invoke("removeCollison", 1.0f);
		//VIBRATE
	}
	
	void removeCollison()
	{
		collisionQueue.Dequeue();
	}
}
