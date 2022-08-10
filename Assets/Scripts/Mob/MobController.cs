using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MobController : MonoBehaviour
{
    public GameManager gameManager;
    public CharacterController controller;

    [Header("MobLevel")]
    public int mobLevel;
    private Animator animator;
    [Header("Text")]
    public TextMeshPro mobLevelText;
    private Rigidbody rb;
    
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        mobLevelText.text = "Lv." + mobLevel; 
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && gameManager.characterLevel >= mobLevel)
        {
            
            gameManager.characterLevel += mobLevel;
            
            animator.SetTrigger("MobDead");
            
            collision.transform.localScale += new Vector3(0.8f, 0.8f, 0.8f);
            Vibrator.Vibrate(gameManager.vibrateMilisc);
            Debug.Log("Değdi");
            
        }
        
        else if (collision.gameObject.tag == "Player" && gameManager.characterLevel <= mobLevel)
        {
            gameManager.characterLevel -= mobLevel;
            rb.isKinematic = true;
            animator.SetTrigger("MobDamage");
            controller.anim.SetTrigger("MainDead");
            collision.transform.localScale += new Vector3(0.20f, 0.20f, 0.20f);
            Vibrator.Vibrate(gameManager.vibrateMilisc);
            Debug.Log("Değdi");
            controller.enabled = false;
        }
        
    }
}
