using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TimerController.Instance.BeginTimer();
        CountdownTimer.Instance.BeginCountdown(40f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
