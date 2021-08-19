using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SlowDownButtonBehaviour : MonoBehaviour
{
    public static SlowDownButtonBehaviour instance;
    public  bool buttonState;
    Button btn;
    // Start is called before the first frame update

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        ColorBlock cb = btn.colors;
        cb.pressedColor = new Color32(255,0,0,255);
        buttonState = MonetizationStatus.instance.currentStatus;
        btn = gameObject.GetComponent<Button>();
    }
    public void EnableButton()
    {
        buttonState = true;
        ColorBlock cb = btn.colors;
        cb.pressedColor = new Color32(0,255,0,255);
    }
    void ToggleTimeSpeed()
    {
        if(!buttonState)
        {
            
        }
        TimeManager.instance.AdjustTimeRate(MonetizedMode.premiumMode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
