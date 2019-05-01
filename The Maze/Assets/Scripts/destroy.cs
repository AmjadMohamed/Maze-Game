using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject sound;
    void Start()
    {
        Destroy(sound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
