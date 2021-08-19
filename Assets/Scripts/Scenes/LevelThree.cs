using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelThree : MonoBehaviour
{
    public static LevelThree instance;

    private void Awake() 
    {
        instance = this;  
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
