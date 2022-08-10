using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalManager : MonoBehaviour
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
        if (other.tag == "Portal+")
        {
            gameManager.characterLevel += 25;
            gameObject.transform.localScale += new Vector3(0.20f, 0.20f, 0.20f);
            
            

        }
        if (other.tag == "Portal-")
        {
            gameManager.characterLevel -= 25;
            gameObject.transform.localScale += new Vector3(-0.20f, -0.20f, -0.20f);
            
        }
    }
}
