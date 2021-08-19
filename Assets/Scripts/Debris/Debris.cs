using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debris : MonoBehaviour
{
    //Variables
    [FMODUnity.EventRef]
    public string selectSound;
     [FMODUnity.EventRef]
    public string incorrectSound;
    FMOD.Studio.EventInstance clearSoundEvent;
    FMOD.Studio.EventInstance incorrectSoundEvent;
    public string debrisName;
    public int requiredToolID;
    public string debrisDesc;

    public float fadeOutSpeed = 2.0f;
    private bool fadedOut = false;
    private bool cleared = false;

    // Start is called before the first frame update
    void Start()
    {
        clearSoundEvent = FMODUnity.RuntimeManager.CreateInstance(selectSound);
        incorrectSoundEvent = FMODUnity.RuntimeManager.CreateInstance(incorrectSound);

    }

    // Update is called once per frame
    void Update()
    {
        if(cleared)
        {
            ClearDebris();
        }
    }

    private void OnMouseDown()
    {
        if((int) Toolbox.toolboxInstance.activeTool != requiredToolID)
        {
            incorrectSoundEvent.start();
            return;
        }
        clearSoundEvent.start();
        cleared = true;
    }

    private void ClearDebris()
    {
        if(!fadedOut)
        {
            Color objectColor = this.GetComponent<Renderer>().material.color;
            float fadeAmount = objectColor.a - (fadeOutSpeed * Time.deltaTime);

            objectColor.a = fadeAmount;
            this.GetComponent<Renderer>().material.color = objectColor;

            if (objectColor.a <= 0)
            {
                fadedOut = true;
                clearSoundEvent.release();
                clearSoundEvent.clearHandle();
                Destroy(gameObject);
            }
        }
    }
}