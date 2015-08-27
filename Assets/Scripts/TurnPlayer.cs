using UnityEngine;
using System.Collections;

public class TurnPlayer : MonoBehaviour {

	public GameObject playerObject;
	public float speed = 70.0f;
	private bool isLeft = false;
	private bool isRight = false;
	
	public void Update()
	{
		if(isLeft && isRight)
		{
			return;
		}
		else if (isLeft)
		{
			playerObject.transform.Rotate(-Vector3.up * speed * Time.deltaTime);
		}
		else if (isRight)
		{
			playerObject.transform.Rotate(Vector3.up * speed * Time.deltaTime);
		}
	}
	
	public void LeftPointerDown()
	{
		isLeft = true;
	}
	
	public void LeftPointerUp()
	{
		isLeft = false;
	}
	
	public void RightPointerDown()
	{
		isRight = true;
	}
	
	public void RightPointerUp()
	{
		isRight = false;
	}
	
	
}
