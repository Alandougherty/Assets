using UnityEngine;
using System.Collections;

public class CamRay : MonoBehaviour {
	Transform objectHit;
	// Use this for initialization
	void Start () {
	
		objectHit = null;
		
	}
	
	// Update is called once per frame
	void Update () {
	
		
		Transform cam   = Camera.main.transform;

		Ray ray = new Ray(cam.position, cam.forward);
		RaycastHit hit ;
		bool flag  = false;



		Debug.DrawRay (ray.origin, ray.direction*10 , Color.yellow);
		
		//Physics.Raycast(ray,hit)
		if (Physics.Raycast(ray,out hit)) 
		{
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