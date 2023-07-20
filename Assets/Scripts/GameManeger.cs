using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{
    [SerializeField]
    private GameObject mainPanel;
    [SerializeField]
    private GameObject finishPanel;
    // Start is called before the first frame update

    private void Awake()
    {
        Time.timeScale = 0f;
        mainPanel.SetActive(true);
        finishPanel.SetActive(false);
    }
    public void PlayButton()
    {
        mainPanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void ReplayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
