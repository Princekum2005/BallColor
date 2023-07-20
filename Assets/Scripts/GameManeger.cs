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
    [SerializeField]
    private GameObject changeBallPanel;
    [SerializeField]
    private GameObject redImage;
    [SerializeField]
    private GameObject blueImage;
    [SerializeField]
    private BallDeta ballDeta;
    // Start is called before the first frame update

    private void Awake()
    {
        Time.timeScale = 0f;
        mainPanel.SetActive(true);
        finishPanel.SetActive(false);
        changeBallPanel.SetActive(false);
        ballDeta.redBall.SetActive(false);
    }
    public void PlayButton()
    {
        mainPanel.SetActive(false);
        changeBallPanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void ChangeButton()
    {
        changeBallPanel.SetActive(true);
        mainPanel.SetActive(false);
    }
    public void BlueButton()
    {
        redImage.SetActive(false);
        blueImage.SetActive(true);
        ballDeta.redBall.SetActive(false);
        ballDeta.blueBall.SetActive(true);
    }
    public void RedButton()
    {
        redImage.SetActive(true);
        blueImage.SetActive(false);
        ballDeta.redBall.SetActive(true);
        ballDeta.blueBall.SetActive(false);
    }
    public void ReplayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    

}
