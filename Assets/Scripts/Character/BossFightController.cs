using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFightController : MonoBehaviour
{
    public GameManager gameManager;
    public BossController bossController;
    public CharacterController controller;
    public int BossDamage;

    public GameObject bossScale;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            bossController.BossLevel += -10;
            bossScale.transform.localScale += new Vector3(-0.5f, -0.5f, -0.5f);
            Vibrator.Vibrate(gameManager.vibrateMilisc);
            BossDamage++;
            FindObjectOfType<CharacterController>().anim.SetBool("BossAttack",true);
            controller.anim.SetBool("BossAttack",true);
            if (BossDamage % 3 == 0)
            {
                bossController.bossAnim.SetBool("Hit",true);
                gameManager.characterLevel += -10;
            }
        }
        
    

    }
    
}
