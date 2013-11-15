using UnityEngine;
using System.Collections;

public class BalanceScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	
    void OnMouseEnter() {
        renderer.material.color = Color.red;
    }
	   void OnMouseExit() {
        renderer.material.color = Color.green;
    }

	
	// Update is called once per frame
	void Update () {
	float speed  = 1.0f; //how fast the object should rotate
			this.transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * Time.deltaTime * speed);	
	}
	
void OnMouseDown() {
	
		//a = Input.mousePosition;
		
	}
	
	public void frack() {
		
		Debug.Log("hello"); 
		if (Input.GetMouseButton(0))
		{
			Debug.Log("mouse1 pressed");
			Vector3 Rot;
			Rot = new Vector3(1,0,0);
			//Destroy(this.gameObject); //This will take the objcet associated with this script and destoy it
		 //this.transform.eulerAngles.y = 360*( (Input.mousePosition.x - Screen.width / 2 )/Screen.width / 2 );
		   //this.transform.Rotate( Rot );
			 Update();
			
	 	}
	}
}

/* from unity help
 * var speed : float = 1.0; //how fast the object should rotate
 
 function Update(){
      transform.Rotate(Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * Time.deltaTime * speed);
 }
 */