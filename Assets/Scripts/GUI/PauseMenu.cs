using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenuObj;
    bool isPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            Time.timeScale = 0.0f;
            pauseMenuObj.SetActive(true);
            isPaused = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused)
        {
            Time.timeScale = 1.0f;
            pauseMenuObj.SetActive(false);
            isPaused = false;
        }
    }
}
