using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyCollisionChecker : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
    }


}
