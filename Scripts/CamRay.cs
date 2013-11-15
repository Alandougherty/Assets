using UnityEngine;
using System.Collections;

public class CamRay : MonoBehaviour {
	Transform objectHit;
	Transform LastObject;
	RaycastHit phit = new RaycastHit() ;
	
	// Use this for initialization
	void Start () {
	
		objectHit = null;
			Transform cam   = Camera.main.transform;
		//RaycastHit hit = null;
			Ray ray = new Ray(cam.position, cam.forward);
		
		if (Physics.Raycast(ray,out phit)) 
		{
			
		}
	}
	
	// Update is called once per frame, also it maitains all variables from previous call.
	void Update () {
	
		//if (hit != null )
		//{
		RaycastHit hit;
		LineRenderer RAY = new LineRenderer();
		
		//RAY.enabled = true;
		
		//RAY.SetVertexCount(2);
		
 
		//}
		
		Transform cam   = Camera.main.transform;

		Ray ray = new Ray(cam.position, cam.forward);
		
		bool flag  = false;



		Debug.DrawRay (ray.origin, ray.direction*10 , Color.yellow);
		
		//Physics.Raycast(ray,hit)
		if (Physics.Raycast(ray,out hit)) 
		{
			//RAY.SetPosition(0,ray.origin);
			//RAY.SetPosition(1,hit.point);
			//check if churrent hit object is the same as last hit object
			if (hit.transform != phit.transform)
			{
				phit.collider.gameObject.renderer.material.color = Color.red;
				Debug.Log("excetion");
				hit.collider.gameObject.renderer.material.color = Color.green;
				/*
				if (hit.transform == objectHit)
				{
						//hit.collider.gameObject.renderer.material.color = Color.green;
				}
				else
				{
						//objectHit.renderer.material.color = Color.red;
						//hit.collider.gameObject.renderer.material.color = Color.red;
				}
						
				objectHit  = hit.transform;
    			Debug.Log(objectHit.name);
			
			
   				 if (objectHit.name == "balance"){
    					Debug.Log("HIT");
    					flag = true;
    				}
    			else{
    					flag = false;
   					}
   					*/
			} //if it wasn't the same object then need to undo any changes
			else 
			{
				//objectHit.renderer.material.color = Color.green;
				//hit.collider.gameObject.renderer.material.color = Color.green;
				
			}
			//assign global hit to current hit for object detection, i.e. checking when object 
			//no longer being looked at
			phit = hit;
			//objectHit  = hit.transform;
			hit.collider.gameObject.renderer.material.color = Color.green;
			
 		}   
   
		if (flag) {
    
   				//hit.collider.gameObject.GetComponent<BalanceScript>().frack();
				//Color startColor = hit.collider.gameObject.renderer.material.color;
			//hit.collider.gameObject.renderer.material.color = Color.green;
    
    
    }
		
	}
}

//#pragma strict

//function Start () {

//}

//function Update () {

    
	// Do something with the object that was hit by the raycast.

//}