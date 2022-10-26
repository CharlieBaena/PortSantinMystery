using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    [SerializeField] float _speed;
    bool isActiveZoom, isActiveFar;

    private void Start()
    {

        isActiveFar = false;
        isActiveZoom = true;

    }

    void Update()
    {
        
        if(Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + _speed * Time.deltaTime, transform.position.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x - _speed * Time.deltaTime, transform.position.y);

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        //if(other.gameObject.CompareTag("Far") && !isActiveFar)
        //{
        //    EventManager._cameraFar.Invoke();
        //    isActiveFar = true;
        //    isActiveZoom = false;
        //}

        //if(other.gameObject.CompareTag("Zoom") && !isActiveZoom)
        //{
        //    EventManager._cameraZoom.Invoke();
        //    isActiveZoom = true;
        //    isActiveFar = false;
        //}
        

    }
}
