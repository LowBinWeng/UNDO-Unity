using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerA : MonoBehaviour {

    float speed = 10f; 

	// Use this for initialization
	void Start () {
		
        
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.D))Move(Vector2.right);
	}

     void Move(Vector2 dir)
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
