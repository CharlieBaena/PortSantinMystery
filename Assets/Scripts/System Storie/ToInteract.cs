using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToInteract : MonoBehaviour
{

    private void Update()
    {
        
        if(GlobalBools._canTalk)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {

                GlobalBools._nowIsTalking = true;

            }
        }

    }

}
