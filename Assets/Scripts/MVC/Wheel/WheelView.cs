using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelView : MonoBehaviour
{
    [SerializeField]
    private WheelController wheelController;
    void Update()
    {
        wheelController.WheelRotating();
    }
}
