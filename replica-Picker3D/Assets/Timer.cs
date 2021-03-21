using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float _timeRemaining = 1;
    private bool _isTimerRunning = false;
    void Update()
    {
        if (_isTimerRunning)
        {
            if (_timeRemaining > 0)
            {
                _timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                _timeRemaining = 0;
                _isTimerRunning = false;
            }
        }
    }
    public void StartTimer()
    {
        _isTimerRunning = true;
    }
    public void TimeRemain(float timeRemain)
    {
        _timeRemaining = timeRemain;
    }
    public bool isTimerRunning()
    {
        return _isTimerRunning;
    }
}
