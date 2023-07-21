using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private GameObject finishLine;
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private float jumpForce = 8f;
    [SerializeField]
    private string objectTag;

    BallModel ballModel = new BallModel();
    public void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(objectTag))
        {
            ballModel.GameContinue();
        }
        else if (other.gameObject.CompareTag("FinishLine"))
        {
            ballModel.GameFinish();
            finishLine.SetActive(true);
        }
        else
            ballModel.GameOver();
    }
}
