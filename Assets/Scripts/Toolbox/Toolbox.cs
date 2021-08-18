using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toolbox : MonoBehaviour
{
    public static Toolbox toolboxInstance;
    //Variables
    public Tool lastSelectedTool;
    public enum Tools
    {
        Hammer,
        Axe,
        Hoe,
        Seeds,
        WateringCan,
        Sapling,
        None
    }

    public Tools activeTool;

    private void Awake()
    {
        toolboxInstance = this;
        activeTool = Tools.None;
    }
    public void SetActiveTool(Tools activatedTool, Tool selectedTool)
    {
        if(lastSelectedTool != null)
        {
            lastSelectedTool.DeselectTool();
        }
        lastSelectedTool = selectedTool;
        activeTool = activatedTool;

        
    }

    // Start is called before the first frame update
}