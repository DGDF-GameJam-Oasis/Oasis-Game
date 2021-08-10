using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeybindManager : MonoBehaviour
{   
    //Example keybinds
    public KeyCode wKey;
    public KeyCode aKey;
    public KeyCode sKey;
    public KeyCode dKey;
    // public KeyBindingManager KeyBinds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Super simplified for now
        if(Input.GetKeyDown(wKey))
        {
            //Do something
        }

        if(Input.GetKeyDown(aKey))
        {
            //Do something
        }

        if(Input.GetKeyDown(sKey))
        {
            //Do something
        }

        if(Input.GetKeyDown(dKey))
        {
            //Do something
        }

    }
}
