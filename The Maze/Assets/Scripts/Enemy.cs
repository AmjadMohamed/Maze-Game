using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public Animator anim;
   // public float movementspeed = 0.1f;

    public float damage = 10;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Vector3.Distance(player.position , this.transform.position) < 9)
        {
            Vector3 direction = player.position - this.transform.position;
            direction.y = 0;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);
            anim.SetBool("IsIdle", false); 
            if (direction.magnitude > 2)
            {
                this.transform.Translate(0, 0, 0.025f);
                anim.SetBool("IsWalking", true);
                anim.SetBool("IsAttacking", false);
                gameObject.GetComponent<damaging>().IsAttacking = false;
              //  SoundManager.instance.PlayOneShot(SoundManager.instance.EnemyHit);
            }

            else
            {
                anim.SetBool("IsAttacking", true);
                anim.SetBool("IsWalking", false);
                gameObject.GetComponent<damaging>().IsAttacking = true;
            }
        }
        else
        {
            anim.SetBool("IsIdle", true);
            anim.SetBool("IsWalking", false);
            anim.SetBool("IsAttacking", false);
            gameObject.GetComponent<damaging>().IsAttacking = false;
        }
    }

    
}


