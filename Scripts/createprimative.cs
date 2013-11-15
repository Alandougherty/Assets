using UnityEngine;
using System.Collections;

public class cte : MonoBehaviour {
	


	void Start() {
		for (int y = 0; y < 5; y++) {
			for (int x = 0; x < 5; x++) {
				GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
				cube.AddComponent<Rigidbody>();
				cube.transform.position = new Vector3(x, y, 0);
			}
		}
	}

	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	void Update () {
	
	}
}
