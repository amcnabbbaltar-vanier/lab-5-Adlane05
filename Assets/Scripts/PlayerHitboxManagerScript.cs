using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitboxManagerScript : MonoBehaviour
{
    public Collider[] attackColliders;
    void Start()
    {
                DisableHitbox();

    }
    public void EnableHitbox()
    {
        foreach( Collider attackCollider in attackColliders)
        {
            attackCollider.enabled = true;
        }
    }

    public void DisableHitbox()
    {
        foreach( Collider attackCollider in attackColliders)
        {
            attackCollider.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
