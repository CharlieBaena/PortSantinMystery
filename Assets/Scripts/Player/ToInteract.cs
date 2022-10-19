using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToInteract : MonoBehaviour
{
    public KeyCode _Interact, _Inventory;

    void Update()
    {
        
        if(Input.GetKeyDown(_Interact))
          {
            if (GlobalBools._canTalk)
            {
                EventManager._Talk.Invoke();
            }

            if(GlobalBools._canOpenDoor)
            {
                EventManager._DoorDetect.Invoke();
            }
          }


        if (Input.GetKeyDown(_Inventory))
        {
            if (!GlobalBools._OpenInventory)
            {

                print("Va");
                GlobalBools._OpenInventory = true;
                EventManager._OpenInventory.Invoke();

            }
            else
            {
                
                    GlobalBools._OpenInventory = false;
                    EventManager._CloseInventory.Invoke();

                
            }

        }

    }
}
