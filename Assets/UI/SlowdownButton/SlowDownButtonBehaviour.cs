using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SlowDownButtonBehaviour : MonoBehaviour
{
    public static SlowDownButtonBehaviour instance;
    public  bool buttonState;
    private bool onoff;
    Button btn;
    // Start is called before the first frame update

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        buttonState = MonetizationStatus.instance.currentStatus;
        onoff = buttonState;
        btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(ToggleTimeSpeed);
        if(!buttonState)
        {
            ColorBlock cb = btn.colors;
            cb.pressedColor = new Color32(255,0,0,255);
            btn.colors = cb;
        }
    }
    public void EnableButton()
    {
        buttonState = MonetizationStatus.instance.currentStatus;
        Debug.Log("Enabling Button");
        btn = gameObject.GetComponent<Button>();
        ColorBlock cb = btn.colors;
        cb.pressedColor = new Color32(0,255,0,255);
        btn.colors = cb;
    }
    void ToggleTimeSpeed()
    {
        if(!buttonState){return;}
        if(onoff)
        {
            Debug.Log("premium!");
            TimeManager.instance.AdjustTimeRate(MonetizedMode.premiumMode);
            ColorBlock cb = btn.colors;
            cb.selectedColor = new Color32(0,255,0,255);
            btn.colors = cb;
        }
        else
        {
            Debug.Log("Non Premium");
            TimeManager.instance.AdjustTimeRate(MonetizedMode.normalMode);
            ColorBlock cb = btn.colors;
            cb.selectedColor = new Color32(255,255,255,255);
            btn.colors = cb;
        }
        onoff = !onoff;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
