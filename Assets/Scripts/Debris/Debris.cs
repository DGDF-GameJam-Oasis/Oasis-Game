using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

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
    private void WetSeeds()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color32(152,48,48,255);
    }
    private void OnMouseDown()
    {
        if((int) Toolbox.toolboxInstance.activeTool != requiredToolID)
        {
            incorrectSoundEvent.start();
            return;
        }
        clearSoundEvent.start();
        
        if((int)Toolbox.toolboxInstance.activeTool == 3)
        {
            LevelOne.instance.toPlant--;
            if(LevelOne.instance.toPlant <= 0)
            {
                requiredToolID = 4;
            }
        }
        if((int)Toolbox.toolboxInstance.activeTool == 4)
        {
            WetSeeds();
            LevelOne.instance.toWater--;
            if(LevelOne.instance.toWater <= 0)
            {
                LevelOne.instance.Deactivate();
                LevelTwo.instance.Activate();
                GameController.gameControllerInstance.UpdateLevel1();
            }

        }
        if((int)Toolbox.toolboxInstance.activeTool == 0 || (int)Toolbox.toolboxInstance.activeTool == 1)
        {
            cleared = true;
            LevelOne.instance.toClear--;
            Debug.Log(LevelOne.instance.toClear);
            if(LevelOne.instance.toClear <= 0)
            {
                Seeds.instance.Activate();
                CompleteTask.instance.UpdateMenu();
            }
        }
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