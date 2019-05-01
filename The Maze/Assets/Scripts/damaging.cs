using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class damaging : MonoBehaviour
{
    public Texture texture;

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
              OnGUI();
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

    void OnGUI()
    {
        if (IsAttacking)
        {
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), texture);
        }
    }
}