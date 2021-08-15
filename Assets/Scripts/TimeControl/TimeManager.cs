using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public static TimeManager instance;
    
    public Text timerCounter;
    private TimeSpan runningTime;
    private bool timerOn = false;
    private float premiumMultiplier = 1f;
    private float defaultTimeRate = 3f;

    //To be saved between sessions
    public float elapsedTime;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        timerCounter.text = "00:00:00";
    }
    public void BeginTimer()
    {
        timerOn = true;
        // Update ElapsedTime from locally saved data
        StartCoroutine(UpdateTimer());
    }
    public void EndTimer()
    {
        timerOn = false;
    }
    public void AdjustTimeRate(float multiplier)
    {
        Debug.Log("Updated TimeRate");
        premiumMultiplier = multiplier;
    }
    private IEnumerator UpdateTimer()
    {
        while (timerOn)
        {
            elapsedTime += Time.deltaTime * defaultTimeRate * premiumMultiplier;
            runningTime = TimeSpan.FromSeconds(elapsedTime);
            string runningTimeStr = runningTime.ToString("hh':'mm':'ss");
            timerCounter.text = runningTimeStr;
            yield return null;
        } 
    }
}
