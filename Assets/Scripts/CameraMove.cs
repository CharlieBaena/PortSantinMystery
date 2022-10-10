using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    [SerializeField] float _FarAmount, _ZoomAmount;
    float _value;
    bool _IsFar;
    Camera _mainCamera;

    void Start()
    {
        EventManager._cameraFar.AddListener(FarCamera);
        EventManager._cameraZoom.AddListener(ZoomCamera);
        _mainCamera = Camera.main;

        _IsFar = false;

    }
    private void FarCamera()
    {
         _mainCamera.orthographicSize = _FarAmount;
        _IsFar = true;
    }

    private void ZoomCamera()
    {
        if(_IsFar)
        {
            _mainCamera.orthographicSize = _ZoomAmount;
            _IsFar = false;

        }
    }

    Ie

}
