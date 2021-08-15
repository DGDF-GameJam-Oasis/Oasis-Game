using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TimeManager.instance.BeginTimer();
        CountdownTimer.instance.BeginCountdown(40f);
        // GetComponent<MonetizedMode>().enabled = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
