using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feedback : MonoBehaviour
{
    bool _start = false, _canSee = false;

    [SerializeField] float TimeTotal, CurrentTime;

    void Start()
    {
        //EventManager._StartFeedback.AddListener(StartTimer);
        //EventManager._StopFeedback.AddListener(StopTimer);
    }

    // Update is called once per frame
    void Update()
    {
        if(!_start)
        {
            StopCoroutine(Feed_Back_Coru());
        }
        else
        {
            StartCoroutine(Feed_Back_Coru());
        }

        if(_canSee)
        {
            
        }
        else
        {

        }
    }

    public void StartTimer()
    {
        _start = true;
    }

    public void StopTimer()
    {
        _start = false;
        _canSee = false;
    }


    IEnumerator Feed_Back_Coru()
    {
        CurrentTime = 0;
        
        while(CurrentTime < TimeTotal)
        {
            CurrentTime += Time.deltaTime;
            yield return null;
        }

        if(CurrentTime == TimeTotal)
        {
            _canSee = true;
            yield return null;
        }

        yield return null;
    }
}
