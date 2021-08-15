using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toolbox : MonoBehaviour



{
    //Variables
    string toolName;
    int toolID;
    string toolDescription;

    //TODO placeholders for instancilazing all the variables.
    string desc;
    string tempName;
    int id;

    // Start is called before the first frame update
    void Start()
    {

        SetVariables(tempName, desc, id);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetVariables(string name, string desc, int ID)
    {
        toolName = name;
        toolDescription = desc;
        int toolId = ID;
    }

    void SelectTool()
    {
        //TODO: Select a tool from a toolbox by clicking it
    }

    void UseTool()
    {
        //TODO Set it so that when a tool is used that it checks whether the ID matches the debris that it's being used on. 
        //We'll likely have another means of destroying an instance of a 
    }

    void DestroyDebris()
    {
        //Remove debris from a location based on the tool being used, if it matches the debris will be removed.  Otherwise it'll stay there, possible add in an error message of some sort.
    }
}
