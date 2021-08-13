using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public static TimeManager Instance;
    
    public Text TimerCounter;
    private TimeSpan RunningTime;
    private bool TimerOn = false;
    public float TimeMultiplier = 1f;

    //To be saved between sessions
    public float ElapsedTime;
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        TimerCounter.text = "00:00:00";
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
    public void AdjustTimeRate(float Multiplier)
    {
        TimeMultiplier = Multiplier;
    }
    private IEnumerator UpdateTimer()
    {
        while (TimerOn)
        {
            ElapsedTime += Time.deltaTime * TimeMultiplier;
            RunningTime = TimeSpan.FromSeconds(ElapsedTime);
            string RunningTimeStr = RunningTime.ToString("hh':'mm':'ss");
            TimerCounter.text = RunningTimeStr;
            yield return null;
        } 
    }
}