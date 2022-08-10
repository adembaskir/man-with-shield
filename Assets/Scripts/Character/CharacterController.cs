using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterController : MonoBehaviour
{
    [Header("Animasyon")] public Animator anim;
    float touchPosX;
    public GameManager manager;
    [Header("Karakter Hızı & Swipe Hızı")]
    public float moveSpeed;
    public float swipeSpeed;
    [Header("LevelBoundaries")]
    public float min = -6.5f;
    public float max = 5.8f;

    [Header("MermiHasarı")] 
    public int bulletDamage = 10;

    void Start()
    {
        
    }
    
    void Update()
    {
        transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        if (TouchController.Instance.canMove)

        {

            touchPosX = TouchController.Instance.touch.deltaPosition.x * Time.deltaTime * swipeSpeed;

            transform.position += Vector3.right * touchPosX;
            
            Vector3 pos = transform.position;

            pos.x = Mathf.Clamp(pos.x, min, max);

            transform.position = pos;

        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mob")
        {
            anim.SetTrigger("Attack");
            other.gameObject.SetActive(false);
        }
        else
        {
            anim.SetBool("MobAttack",false);
        }
        
        if (other.tag == "Bullet")
        {
            manager.characterLevel -= bulletDamage;
            gameObject.transform.localScale += new Vector3(-0.1f, -0.1f, -0.1f);
            Debug.Log("ateş");
            
            Vibrator.Vibrate(manager.vibrateMilisc);
        }
    }

    


}
