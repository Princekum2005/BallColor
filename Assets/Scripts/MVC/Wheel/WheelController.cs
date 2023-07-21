using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    [SerializeField]
    private float rotateSpeed = 1f;
    public void WheelRotating()
    {
        transform.Rotate(0f,0f,rotateSpeed*Time.deltaTime);
    }
}
