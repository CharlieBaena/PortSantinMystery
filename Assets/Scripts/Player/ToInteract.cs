using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToInteract : MonoBehaviour
{
   

    [SerializeField] UserActions _controls;
    private InputAction Interact;
    private InputAction Inventory;


    private void Awake()
    {
        _controls = new UserActions();
    }

    public void OnEnable()
    {

        Interact = _controls.Player.Interactue;
        Interact.Enable();
        Interact.performed += StartInteract;
       
        Inventory = _controls.Player.Inventory;
        Inventory.Enable();
        Inventory.performed += OpenInventory;
    }

    public void OnDisable()
    {
        Interact.Disable();
        Inventory.Disable();
    }


    private void OpenInventory(InputAction.CallbackContext context)
    {
        
        if (!GlobalBools._OpenInventory)
        {

            
            GlobalBools._OpenInventory = true;
            EventManager._OpenInventory.Invoke();

        }
        else
        {

            GlobalBools._OpenInventory = false;
            EventManager._CloseInventory.Invoke();


        }
    }

    private void StartInteract(InputAction.CallbackContext context)
    {
        
        if (GlobalBools._canTalk)
        {
            EventManager._Talk.Invoke();
            
        }

        if (GlobalBools._canOpenDoor)
        {
            EventManager._changeScene.Invoke();
        }
    }
}
