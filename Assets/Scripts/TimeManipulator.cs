using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManipulator : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {

        if (Input.GetButtonDown("Accelerate"))
        {
            Debug.Log("accelerate");
            Time.timeScale *= 2;//Time.timeScale = Time.timeScale *2
        }
        if (Input.GetButtonDown("SlowDown"))
        {
            Debug.Log("slow down");
            Time.timeScale /= 2;
        }
    }

    public void SetTime(float value)
    {
        Debug.Log(value);
        Time.timeScale = value;
    }
}
