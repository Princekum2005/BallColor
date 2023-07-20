using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotet : MonoBehaviour
{
    [SerializeField]
    private float rotateSpeed = 1f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,0f,rotateSpeed*Time.deltaTime);
    }
}
