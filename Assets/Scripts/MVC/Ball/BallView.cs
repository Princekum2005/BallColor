using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    [SerializeField]
    private BallController ballController;
    
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump"))
        {
            ballController.Jump();
        }
    }
}
