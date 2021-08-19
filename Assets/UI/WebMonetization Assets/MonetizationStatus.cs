using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonetizationStatus : MonoBehaviour
{
    public static MonetizationStatus instance;
    public bool currentStatus;
    public Sprite offTexture;
    public Sprite onTexture;

    // Start is called before the first frame update

    private void Awake() 
    {
        instance = this;
        currentStatus = false;
    }
    public void EnableFeatures()
    {
        currentStatus = true;
        SlowDownButtonBehaviour.instance.EnableButton();
    }
    void Start()
    { 
        
    }
    public void SetOnLogo()
    {
        gameObject.GetComponent<UnityEngine.UI.Image>().sprite= onTexture;
    }
    public void SetOffLogo()
    {
        gameObject.GetComponent<UnityEngine.UI.Image>().sprite= offTexture;
    }
}
