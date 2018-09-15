using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
        Debug.Log("Start");
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.up * 100f * Time.deltaTime);
 		Death();        
		Jump();
        Roll();
	}

    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector3.up * 100f);
    }

	void Death()
    {
        Destroy(this.gameObject);
    }

    void Roll()
    {
        if (Input.GetKeyDown(KeyCode.Space)) this.transform.Translate(1, 0, 0);
    }
}
