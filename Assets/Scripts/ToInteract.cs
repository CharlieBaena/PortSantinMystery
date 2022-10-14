using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToInteract : MonoBehaviour
{
    void Update()
    {
        
        if(GlobalBools._canTalk)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                EventManager._Talk.Invoke();
            }
        }


    }
}
