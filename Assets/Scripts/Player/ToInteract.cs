using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToInteract : MonoBehaviour
{
    public KeyCode _Interact, _Inventory;
    bool _OpenInventory = false;

    void Update()
    {
        
        if(GlobalBools._canTalk)
        {
            if(Input.GetKeyDown(_Interact))
            {
                EventManager._Talk.Invoke();
            }
        }


        if(!_OpenInventory)
        {

            if(Input.GetKeyDown(_Inventory))
            {
                print("Va");
                _OpenInventory = true;
                EventManager._OpenInventory.Invoke();

            }

        }
        else
        {

            if (Input.GetKeyDown(_Inventory))
            {

                _OpenInventory = false;
                EventManager._CloseInventory.Invoke();

            }

        }


    }
}
