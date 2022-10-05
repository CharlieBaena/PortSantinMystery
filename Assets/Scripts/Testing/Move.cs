using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    [SerializeField] float _speed;

    private void Start()
    {

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
        if(other.gameObject.CompareTag("Far"))
        {
            EventManager._cameraFar.Invoke();
        }

        if(other.gameObject.CompareTag("Zoom"))
        {
            EventManager._cameraZoom.Invoke();
        }
        

    }
}
