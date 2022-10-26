using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    [SerializeField] Vector3[] FarPostion;
    [SerializeField]float _currentTime, _duration;

    public Transform _player;
    [SerializeField] float _smooth;
    [SerializeField] Vector3 _offset, targetPosition;

    bool changingCamera = false, fixedCamera = false;

    bool _IsFar;
    Camera _mainCamera;
    Coroutine _coroutine;

    void Start()
    {
        EventManager._cameraFarChurch.AddListener(FarCameraChurch);
        EventManager._cameraFarHotel.AddListener(FarCameraHotel);
        EventManager._cameraZoomChurch.AddListener(ZoomCameraChurch);
        EventManager._cameraZoomHotel.AddListener(ZoomCameraHotel);
        _mainCamera = Camera.main;
        
        _IsFar = false;

    }

    void FixedUpdate()
    {

        if(!changingCamera)
        {
            if (!fixedCamera)
            {


                targetPosition = _player.position + _offset;
                Vector3 smoothMove = Vector3.Lerp(transform.position, targetPosition, _smooth);
                transform.position = smoothMove;
                transform.LookAt(_player);
            }
            
        }
        
    }

    private void FarCameraChurch()
    {
        _currentTime = 0;
        if(_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }

        _coroutine = StartCoroutine(FarSmoothChurch());
        _IsFar = true;
    }

    private void ZoomCameraChurch()
    {
        if(_IsFar)
        {
            _currentTime = 0;
            if (_coroutine != null)
            {
                StopCoroutine(_coroutine);
            }
            _coroutine = StartCoroutine(ZoomSmoothChurch());
         
            _IsFar = false;
        }
    }


    private void FarCameraHotel()
    {
        _currentTime = 0;
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }

        _coroutine = StartCoroutine(FarSmoothHotel());
        _IsFar = true;
    }

    private void ZoomCameraHotel()
    {
        if (_IsFar)
        {
            _currentTime = 0;
            if (_coroutine != null)
            {
                StopCoroutine(_coroutine);
            }
            _coroutine = StartCoroutine(ZoomSmoothHotel());

            _IsFar = false;
        }

    }


    IEnumerator FarSmoothChurch()
    {
        changingCamera = true;
        while(_currentTime < _duration)
        {
            _currentTime += Time.deltaTime;
            _mainCamera.transform.position = Vector3.Lerp(_mainCamera.transform.position, FarPostion[1], _currentTime / _duration);
           // print(_currentTime);
           
            yield return null;
    
       }
        changingCamera = false;
        fixedCamera = true;

    }


    IEnumerator ZoomSmoothChurch()
    {
        changingCamera = true;
        while (_currentTime < 1)
        {
            _mainCamera.transform.position = Vector3.Lerp(_mainCamera.transform.position, targetPosition, _currentTime);
           
            float _smoothSpeed = 0.1f;
            _currentTime += Time.deltaTime * _smoothSpeed;
            print(_currentTime + "    " + (_currentTime / _duration));
            yield return null;
        }
        changingCamera = false;
        fixedCamera = false;
    }


    IEnumerator FarSmoothHotel()
    {
        changingCamera = true;
        while (_currentTime < _duration)
        {
            _currentTime += Time.deltaTime;
            _mainCamera.transform.position = Vector3.Lerp(_mainCamera.transform.position, FarPostion[0], _currentTime/_duration);

            yield return null;
        }
        changingCamera = false;
        fixedCamera = true;
    }

    IEnumerator ZoomSmoothHotel()
    {
        changingCamera = true;
        while (_currentTime < _duration)
        {
            _mainCamera.transform.position = Vector3.Lerp(_mainCamera.transform.position, targetPosition, _currentTime / _duration);


            _currentTime += Time.deltaTime;
            yield return null;
        }
        changingCamera = false;
        fixedCamera = false;
    }


}
