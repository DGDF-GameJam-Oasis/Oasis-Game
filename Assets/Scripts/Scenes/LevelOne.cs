using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOne : MonoBehaviour
{
    public static LevelOne instance;
    public int toClear;
    public int toWater;
    public int toPlant;

    private void Awake() 
    {
        instance = this; 
        toClear = 23;
        toWater = 10;
        toPlant = 10; 
        Deactivate();
    }

    public void Activate()
    {
        gameObject.SetActive(true);
    }
    public void Deactivate()
    {
        gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
