using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlappyBirdMovement : MonoBehaviour {

    public Vector3 jumpForce;

    private int score;
    public Text ScoreText;

    private Rigidbody rigidBody;

	void Start () {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	void Update () {
	    if(Input.GetButtonDown("Jump"))
        {
            rigidBody.AddForce(jumpForce * Time.timeScale);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "obstacle")
        {
            Time.timeScale = 0f;
        }

        if (other.tag == "score")
        {
           score++;
           SetScoreText();
        }
    }

    void SetScoreText()
    {
        ScoreText.text = "Score: " + score.ToString();
    }


}
