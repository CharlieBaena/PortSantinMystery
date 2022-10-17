using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    [SerializeField] float _FarAmount, _ZoomAmount;
    [SerializeField]float _currentTime, _duration;

    public Transform _Target;
    [SerializeField] float _smooth;
    [SerializeField] Vector3 _offset;


    bool _IsFar;
    Camera _mainCamera;
    Coroutine _coroutine;

    void Start()
    {
        EventManager._cameraFar.AddListener(FarCamera);
        EventManager._cameraZoom.AddListener(ZoomCamera);
        _mainCamera = Camera.main;
        
        _IsFar = false;

    }

    void FixedUpdate()
    {

        Vector3 DestinyPosition = _Target.position + _offset;
        Vector3 SmoothMove = Vector3.Lerp(transform.position, DestinyPosition, _smooth);
        transform.position = SmoothMove;


        transform.LookAt(_Target);
    }

    private void FarCamera()
    {
        _currentTime = 0;
        if(_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }

        _coroutine = StartCoroutine(FarSmooth());
        _IsFar = true;
    }

    private void ZoomCamera()
    {
        if(_IsFar)
        {
            _currentTime = 0;
            if (_coroutine != null)
            {
                StopCoroutine(_coroutine);
            }
            _coroutine = StartCoroutine(ZoomSmooth());
         
            _IsFar = false;
        }
    }


    IEnumerator FarSmooth()
    {

        while(_currentTime < _duration)
        {
            _currentTime += Time.deltaTime;
            _mainCamera.fieldOfView = Mathf.Lerp(_mainCamera.fieldOfView, _FarAmount, _currentTime/_duration * Time.fixedDeltaTime);
           
            yield return null;
        }
    }

    IEnumerator ZoomSmooth()
    {

        while (_currentTime < _duration)
        {
            _mainCamera.fieldOfView = Mathf.Lerp(_mainCamera.fieldOfView, _ZoomAmount, _currentTime / _duration * Time.fixedDeltaTime);
           

            _currentTime += Time.deltaTime;
            yield return null;
        }

    }
   

}
