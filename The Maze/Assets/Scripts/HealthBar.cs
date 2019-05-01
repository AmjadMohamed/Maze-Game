using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image currenthealthbar;
 //   public Text ratiotext;

    public float hitpoint = 150;
    public float maxhitpoint = 150;
   // public GameObject player;

    void Start()
    {
        updatehealthbar();
    }

    void Update()
    {
        
    }

    public void updatehealthbar()
    {
        float ratio = hitpoint / maxhitpoint;
        currenthealthbar.rectTransform.localScale = new Vector3(ratio, 1, 1);
      //  ratiotext.text = (ratio * 100).ToString("0") + '%';
    }

    public void takedamage(float damage)
    {
        hitpoint = hitpoint - damage;

        if(hitpoint < 0)
        {
            hitpoint = 0;
           // Destroy(this.gameObject);
            GameManager.playerdead();

        }

        updatehealthbar();
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.transform.tag =="Finish")
        {
            Debug.Log("entered");
            GameManager.playerwon();
        }
    }
}
