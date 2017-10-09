using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

    private Rigidbody rigidBody;
    private Renderer theRenderer;

    public int force;

    
    // Use this for initialization
    void Start () {
        theRenderer = GetComponent<Renderer>();
        rigidBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Jump"))
        {
            // Vector3 oldPosition = transform.position;
            //transform.position = new Vector3(oldPosition.x + 0.4f, oldPosition.y, oldPosition.z);
            rigidBody.AddForce(new Vector3(0, force, 0));
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        theRenderer.material.color = Color.red;

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter");
        theRenderer.material.color = Color.blue;
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("exit");
        theRenderer.material.color = Color.green;
    }








}
