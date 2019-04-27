using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damaging : MonoBehaviour
{// remove that script 
    public float damage = 10;
    public bool IsAttacking;

    GameObject player;
    HealthBar playerhealth;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerhealth = player.GetComponent<HealthBar>();
    }

    void Update()
    {
        
            if (IsAttacking)
            {
                playerhealth.takedamage(damage);
            }


        
    }

  /*  private void OnCollisionStay(Collision collision)
    {

        
        if (collision.transform.tag == "Player")
        {
            if (IsAttacking)
            {
                playerhealth.takedamage(damage);
            }


        }
    }*/
}