using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BossController : MonoBehaviour
{
    public GameManager gameManager;
    public Animator bossAnim;
    
    [Header("MobLevel")]
    public int BossLevel;

    [Header("Text")]
    public TextMeshPro mobLevelText;
    public GameObject normalScreen;
    public GameObject youWinScreen;
    
    void Start()
    {
        bossAnim = GetComponentInChildren<Animator>();
    }

    
    void Update()
    {
        mobLevelText.text = "Lv." + BossLevel; 
        if (BossLevel == 0)
        {
            bossAnim.SetTrigger("BossDied");
            youWinScreen.SetActive(true);
            normalScreen.SetActive(false);
            
        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && gameManager.characterLevel >= BossLevel)
        {
            Debug.Log("Değdi");
        }
        else if (collision.gameObject.tag == "Player" && gameManager.characterLevel <= BossLevel)
        {
            
            Debug.Log("Değdi");
        }
        
        
    }
}
