using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using System.Text.Json.Serialization;

public class SaveClass
{
    private string savePath;
    public float timeRemaining;
    private string SaveToString()
    {
        return JsonUtility.ToJson(this);
    }
    public SaveClass()
    {
        savePath = Path.Combine(Application.dataPath, "Saves", "Save.json");
        timeRemaining = 0f;
    }
    public void Save()
    {
        timeRemaining = TimeManager.instance.timeRemaining;
        File.WriteAllText(savePath,SaveToString());
    }
    public void Load()
    {
        if(File.Exists(savePath))
        {
            string jsonString = File.ReadAllText(savePath);
            timeRemaining = JsonUtility.FromJson<SaveClass>(jsonString).timeRemaining;
        }
        else
        {
            timeRemaining = 50000f;
        }
    }
}
public class TimeManager : MonoBehaviour
{
    public static TimeManager instance;
    public SaveClass Save;
    public Text timerCounter;
    private TimeSpan runningTime;
    private bool timerOn = false;
    private float premiumMultiplier = 1f;
    private float defaultTimeRate = 3f;

    //To be saved between sessions
    public float timeRemaining;
    private void Awake()
    {
        instance = this;
        Save = new SaveClass();
        Save.Load();
    }
    void Start()
    {
        timerCounter.text = "00:00:00";
        timeRemaining = Save.timeRemaining;
    }
    private void OnDestroy() 
    {
        EndTimer();
    }
    public void BeginTimer()
    {

        timerOn = true;
        StartCoroutine(UpdateTimer());
    }
    public void EndTimer()
    {
        Save.Save();
        timerOn = false;
        
    }
    public void AdjustTimeRate(float multiplier)
    {
        premiumMultiplier = multiplier;
    }
    private IEnumerator UpdateTimer()
    {
        while (timerOn)
        {
            timeRemaining -= Time.deltaTime * defaultTimeRate * premiumMultiplier;
            runningTime = TimeSpan.FromSeconds(timeRemaining);
            string runningTimeStr = runningTime.ToString("hh':'mm':'ss");
            timerCounter.text = runningTimeStr;
            yield return null;
        } 
    }
}
