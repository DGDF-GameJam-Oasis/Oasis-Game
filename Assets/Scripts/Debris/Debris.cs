using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debris : MonoBehaviour
{

    //Variables
    public string debrisName;
    public int requiredToolID;
    public string debrisDesc;

    public float fadeOutSpeed = 0.8f;
    private bool fadedOut = false;
    private bool cleared = false;

    // Start is called before the first frame update
    void Start()
    {
        
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
            //Display wrong tool prompt
            Debug.Log("Wrong Tool!");
            return;
        }
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
                Destroy(gameObject);
            }
        }
    }
    void SetVariables()
    {

    }
}
