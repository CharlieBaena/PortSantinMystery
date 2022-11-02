using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    [SerializeField] UserActions _controls;
    private InputAction OpenClose;
  


    private void Awake()
    {
        _controls = new UserActions();
    }

    public void OnEnable()
    {

        OpenClose = _controls.Player.Interactue;
        OpenClose.Enable();
        OpenClose.performed += UseMenu;

       
    }

    public void OnDisable()
    {
        OpenClose.Disable();
       
    }

    private void UseMenu(InputAction.CallbackContext context)
    {

    }
}
