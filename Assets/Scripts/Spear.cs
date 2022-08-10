using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : MonoBehaviour
{
    public Animator animator;
    
    public void Bow()
    {
        animator.SetBool("Spear",true);
    }
    public void BowOff()
    {
        animator.SetBool("Spear",false);
    }
}
