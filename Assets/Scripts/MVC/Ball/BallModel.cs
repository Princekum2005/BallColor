using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallModel
{
    public void GameFinish()
    {
        Time.timeScale = 0f;
    }
    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GameContinue()
    {
        Debug.Log("Continue");
    }
}
