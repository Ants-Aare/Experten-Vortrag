using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressed : MonoBehaviour
{
    [SerializeField] Material activated;
    private bool isPressed = false;

    void Update()
    {
        if(isPressed == true)
        {
            GetComponent<Renderer>().material = activated;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isPressed = true;
    }

}
