using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController gameControllerInstance;
    public float Level;

    private void Awake() 
    {
        gameControllerInstance = this;
        Level = 1f;
    }
    // Start is called before the first frame update
    void Start()
    {
        TimeManager.instance.BeginTimer();
        LevelOne.instance.Activate();
    }
    public void UpdateLevel1()
    {
        FMODUnity.StudioEventEmitter[] components = GameObject.FindObjectsOfType<FMODUnity.StudioEventEmitter>();
        foreach (FMODUnity.StudioEventEmitter Emitter in components)
        {
            Emitter.SetParameter("Level",2);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
