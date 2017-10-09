using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Button button;
    public GameObject panel;
	
    public void PauseGame()
    {
        button.interactable = false;
        panel.SetActive(true);
        Time.timeScale = 0;
    }

    public void UnPauseGame()
    {
        button.interactable = true;
        panel.SetActive(false);
        Time.timeScale = 1;
    }
}
