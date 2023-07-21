using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform ball;

    public void CameraFollow()
    {
        if (ball.position.y >= -7)
        {
            Vector3 desPos = new Vector3(0f, ball.position.y + 3, -10);
            transform.position = Vector3.Lerp(transform.position,desPos,Time.deltaTime);
        }
    }
}
