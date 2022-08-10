using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public CharacterController controller;
    public CameraFollow cameraFollow;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            controller.moveSpeed += 20;
            cameraFollow.distance = 15;
            cameraFollow.height = 27;
        }
    }
}
