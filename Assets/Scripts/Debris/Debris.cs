using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debris : MonoBehaviour
{
    //Variables
    [FMODUnity.EventRef]
    public string selectSound;
    FMOD.Studio.EventInstance soundEvent;
    public string debrisName;
    public int requiredToolID;
    public string debrisDesc;

    public float fadeOutSpeed = 2.0f;
    private bool fadedOut = false;
    private bool cleared = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Create  Event");
        soundEvent = FMODUnity.RuntimeManager.CreateInstance(selectSound);
    }

    // Update is called once per frame
    void Update()
    {
        if(cleared)
        {
            ClearDebris();
        }
        int position;
        soundEvent.getTimelinePosition(out position);
        if(position >= 490)
        {
            soundEvent.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }
    }

    private void OnMouseDown()
    {
        if((int) Toolbox.toolboxInstance.activeTool != requiredToolID)
        {
            //Display wrong tool prompt
            Debug.Log("Wrong Tool!");
            return;
        }
        soundEvent.start();
        // Playsound();
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
            // if (objectColor.a <= 0.5)
            // {
                
            // }
            if (objectColor.a <= 0)
            {
                fadedOut = true;
                soundEvent.release();
                soundEvent.clearHandle();
                Destroy(gameObject);
            }
        }
    }
    void SetVariables()
    {

    }
}
