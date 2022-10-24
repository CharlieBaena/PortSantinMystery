using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//In case of forgetting to add the rigidbody, unity will automatically add it
[RequireComponent(typeof(Rigidbody))]

public class PlayerMovement : MonoBehaviour
{
    //To select the type of movement to test, we create an enum to contain the opcions in the inspector
    enum MoveType { addingForce, velocityMove, movePositionMove}

    [Header("Type of movement")]
    [SerializeField] MoveType moveType;


    //The speed at the player moves
    [SerializeField]
    float speed;


    //The vector that holds the direction of movement
    Vector3 direction;

    //The rigidbody of the player
    Rigidbody myRB;

    //Detecte if more or less distance
    bool isActiveZoom, isActiveFar;


    [SerializeField] UserActions _controls;
    private InputAction move;
    private InputAction sprint;


    private void Awake()
    {
        _controls = new UserActions();
    }

    public void OnEnable()
    {

        move = _controls.Player.Movement;
        move.Enable();
    }

    public void OnDisable()
    {
        move.Disable();
    }

    void Start()
    {
        //Gets the rigidbody component from the player
        myRB = GetComponent<Rigidbody>();

        //Set value
        isActiveFar = false;
        isActiveZoom = true;
    }

    // Update is called once per frame
    void Update()
    {
        //We ge the direction from the input horizontal (a / d)
        // direction = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        direction = move.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        //After selecting the move type we can test any of them thanks to this switch case 
        switch (moveType)
        {
            case MoveType.addingForce:
                AddingForceMovement();
                break;
            case MoveType.velocityMove:
                VelocityMovement();
                break;
            case MoveType.movePositionMove:
                MovePositionMovement();
                break;
        }
    }

    private void AddingForceMovement()
    {
        //Adds a force that pushes the player
        myRB.AddForce(direction * speed);
    }

    private void VelocityMovement()
    {
        //Stablished the velocity of the rigidbody
        myRB.velocity = direction * speed;
    }

    private void MovePositionMovement()
    {
        //Moves the player in a direction
        myRB.MovePosition(transform.position + (direction * speed * Time.fixedDeltaTime));
    }


    //This detect the triggers in the scene, change the cam fields of view
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Far") && !isActiveFar)
        {
            EventManager._cameraFar.Invoke();
            isActiveFar = true;
            isActiveZoom = false;
        }

        if (other.gameObject.CompareTag("Zoom") && !isActiveZoom)
        {
            EventManager._cameraZoom.Invoke();
            isActiveZoom = true;
            isActiveFar = false;
        }


        if(other.gameObject.CompareTag("Puerta"))
        {
            EventManager._StartFeedback.Invoke();
            GlobalBools._canOpenDoor = true;
        }

        if(other.gameObject.CompareTag("Driver"))
        {
            EventManager._StartFeedback.Invoke();
            GlobalBools._canTalk = true;
            GlobalBools._driverTalking = true;
        }

        if(other.gameObject.CompareTag("Reviewer"))
        {
            EventManager._StartFeedback.Invoke();
            GlobalBools._canTalk = true;
            GlobalBools._reviewerTalking = true;
        }

        if(other.gameObject.CompareTag("Luna"))
        {
            EventManager._StartFeedback.Invoke();
            GlobalBools._canTalk = true;
            GlobalBools._lunaTalking = true;
        }

        if(other.gameObject.CompareTag("Centurion"))
        {
            EventManager._StartFeedback.Invoke();
            GlobalBools._canTalk = true;
            GlobalBools._centurionTalking = true;
        }

        if (other.gameObject.CompareTag("Jorge"))
        {
            EventManager._StartFeedback.Invoke();
            GlobalBools._canTalk = true;
            GlobalBools._jorgeTalking = true;
        }

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Puerta"))
        {
            EventManager._StopFeedback.Invoke();
            GlobalBools._canOpenDoor = false;
        }

        if (other.gameObject.CompareTag("Driver"))
        {
            EventManager._StopFeedback.Invoke();
            GlobalBools._canTalk = false;
            GlobalBools._driverTalking = false;
        }

        if (other.gameObject.CompareTag("Reviewer"))
        {
            EventManager._StopFeedback.Invoke();
            GlobalBools._canTalk = false;
            GlobalBools._reviewerTalking = false;
        }

        if (other.gameObject.CompareTag("Luna"))
        {
            EventManager._StopFeedback.Invoke();
            GlobalBools._canTalk = false;
            GlobalBools._lunaTalking = false;
        }

        if (other.gameObject.CompareTag("Centurion"))
        {
            EventManager._StopFeedback.Invoke();
            GlobalBools._canTalk = false;
            GlobalBools._centurionTalking = false;
        }

        if (other.gameObject.CompareTag("Jorge"))
        {
            EventManager._StopFeedback.Invoke();
            GlobalBools._canTalk = false;
            GlobalBools._jorgeTalking = false;
        }

    }
}
