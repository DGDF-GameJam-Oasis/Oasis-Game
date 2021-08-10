using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public static TimerController Instance;
    
    public Text TimerCounter;
    private TimeSpan RunningTime;
    private bool TimerOn;

    //To be saved between sessions
    public float ElapsedTime;
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        TimerCounter.text = "00:00";
        TimerOn = false;
         
    }
    public void BeginTimer()
    {
        TimerOn = true;

        // Update ElapsedTime from locally saved data
        StartCoroutine(UpdateTimer());
    }
    public void EndTimer()
    {
        TimerOn = false;
    }

    private IEnumerator UpdateTimer()
    {
        while (TimerOn)
        {
            ElapsedTime += Time.deltaTime;
            RunningTime = TimeSpan.FromSeconds(ElapsedTime);
            string RunningTimeStr = RunningTime.ToString("hh':'mm");
            TimerCounter.text = RunningTimeStr;
            yield return null;
        } 
    }
}
