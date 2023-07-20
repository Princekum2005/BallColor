using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private float jumpForce = 10f;
    [SerializeField]
    private string objectTag;
    [SerializeField]
    private GameObject finishLine;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
            
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(objectTag))
        {
            Debug.Log("Continue");
        }
        else if (collision.gameObject.CompareTag("FinishLine"))
        {
            GameFinish();
        }
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void GameFinish()
    {
        finishLine.SetActive(true);
        Time.timeScale = 0f;
    }
}
