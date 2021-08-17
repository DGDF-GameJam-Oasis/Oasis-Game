using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountdownTimer : MonoBehaviour
{
    public static CountdownTimer instance;
    public Text timerCounter;
    public float timerAmount = 0f;
    private bool timerOn = false;
    private TimeSpan runningTime;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        timerCounter.text = timerAmount.ToString("mm':'ss");
    }
    // Update is called once per frame
    void Update()
    {
    }
       public void BeginCountdown(float countdownAmount)
    {
        timerAmount = countdownAmount;
        timerOn = true;

        // Update ElapsedTime from locally saved data
        StartCoroutine(UpdateTimer());
    }
    public void EndCountdown()
    {
        timerOn = false;
    }

    private IEnumerator UpdateTimer()
    {   
        while (timerOn)
        {
            timerAmount -= Time.deltaTime;
            runningTime = TimeSpan.FromSeconds(timerAmount);
            string runningTimeStr = runningTime.ToString("mm':'ss");
            timerCounter.text = "Time left: " + runningTimeStr;

            if(timerAmount<= 0)
            {
                timerOn = false;
            }
            yield return null;
        } 
    }
}

