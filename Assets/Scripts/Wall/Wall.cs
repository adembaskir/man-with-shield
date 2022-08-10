using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameManager gameManager;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameManager.characterLevel += -10;
            other.transform.localScale += new Vector3(-0.05f, -0.05f, -0.05f);
            Vibrator.Vibrate(gameManager.vibrateMilisc);
        }
    }
}
