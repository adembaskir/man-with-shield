using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFightTrigger : MonoBehaviour
{
    [Header("Scriptler")]
    public CharacterController controller;
    public BossFightController bossFightController;
    public CameraFollow cameraFollow;
    
    
    [Header("Transformlar")]
    public Transform boss;
    public Transform camera;
    
    public float hız;
    public bool bossStart;
    public GameManager gameManager;

    void Start()
    {
        bossStart = false;
    }
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            controller.moveSpeed += hız;
            controller.swipeSpeed = 1;
            controller.enabled = false;
            controller.anim.SetBool("IsRun",false);
            
            bossFightController.enabled = true;
            cameraFollow.distance = 30;
            cameraFollow.height = 12;
            cameraFollow.target = boss;
            camera.transform.rotation = Quaternion.Euler(30, 15, 0);
            bossStart = true;
            
        }
        
    }
    
}
