using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipScene : MonoBehaviour
{
    public int level;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            SceneManager.LoadScene(level);
        }
    }

    public void skip()
    {
        SceneManager.LoadScene(level);
    }
}
