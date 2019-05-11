using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class MobileInput : MonoBehaviour
{
    public FixedButton FixedButton;
    public FixedJoystick FixedJoyStick;
    public FixedTouchField FixedTouchField; 

    void Start()
    {
        // var fps = GetComponent<RigidbodyFirstPersonController>();
        var fps = GetComponent<RigidbodyFirstPersonController>();
        fps.RunAxis = FixedJoyStick.Direction;
        fps.JumpAxis = FixedButton.Pressed;
        fps.mouseLook.lookAxis = FixedTouchField.TouchDist;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
