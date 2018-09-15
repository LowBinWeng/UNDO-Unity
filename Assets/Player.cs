using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Start");
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.up * 100f * Time.deltaTime);
        Jump();

	}

    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector3.up * 100f);
    }
}
