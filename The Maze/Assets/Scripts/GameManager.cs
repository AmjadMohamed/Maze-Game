using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static bool isplayerdead;
    static bool haswon;
  //  public GameObject losescreen;
  //  public GameObject wonscreen;
  //  public GameObject welcomescreen;

    void Start()
    {
        isplayerdead = false;
      //  losescreen.SetActive(false);
      //  wonscreen.SetActive(false);
      //  welcomescreen.SetActive(true);
      //  Destroy(welcomescreen, 3);
    }

    
    void Update()
    {
        if(isplayerdead)
        {
            //  losescreen.SetActive(true);
            SceneManager.LoadScene(1);
        }
        else if (haswon)
        {
            SceneManager.LoadScene(2);
        }
    }

    public static void playerdead()
    {
        isplayerdead = true;
       
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    
    public static void playerwon()
    {
        haswon = true;
    }
}
