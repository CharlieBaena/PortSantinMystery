using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // Start is called before the first frame update
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
        direction = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
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


    }
}
