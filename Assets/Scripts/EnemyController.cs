using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void GotHit()
    {
        animator.SetTrigger("GotHit");


        // Notify GameManager
        if (GameManager.instance != null)
        {
            GameManager.instance.AddScore(1); // Add 1 point per hit
        }
    }
}


