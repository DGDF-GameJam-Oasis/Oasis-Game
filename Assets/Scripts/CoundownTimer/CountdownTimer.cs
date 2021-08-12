using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountdownTimer : MonoBehaviour
{
    public static CountdownTimer Instance;
    public Text TimerCounter;
    private float TimerAmount = 0f;
    private bool TimerOn;
     private TimeSpan RunningTime;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        TimerCounter.text = TimerAmount.ToString("mm':'ss");
        TimerOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
       public void BeginCountdown(float CountdownAmount)
    {
        TimerAmount = CountdownAmount;
        TimerOn = true;

        // Update ElapsedTime from locally saved data
        StartCoroutine(UpdateTimer());
    }
    public void EndCountdown()
    {
        TimerOn = false;
    }

    private IEnumerator UpdateTimer()
    {
        while (TimerOn && TimerAmount >= 0f)
        {
            TimerAmount -= Time.deltaTime;
            RunningTime = TimeSpan.FromSeconds(TimerAmount);
            string RunningTimeStr = RunningTime.ToString("mm':'ss");
            TimerCounter.text = "Time left: " + RunningTimeStr;
            yield return null;
        } 
    }
}

