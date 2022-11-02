using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] int _indexScene;
    private void Start()
    {
        EventManager._changeScene.AddListener(NextScene);
    }


    public void NextScene()
    {

        SceneManager.LoadScene(_indexScene);

    }
}
