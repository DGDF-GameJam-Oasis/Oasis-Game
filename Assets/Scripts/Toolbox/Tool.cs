using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Tool : MonoBehaviour
{
    public static string Name;
    //Variables
    public string toolName;
    public int toolID;
    public string toolDescription;



    void Awake()
    {
        toolName = gameObject.name;
    }
    // Start is called before the first frame update
    void Start()
    {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(SelectTool);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SelectTool()
    {
        Toolbox.toolboxInstance.SetActiveTool((Toolbox.Tools) toolID, this);
        //Set to Selected Color
        gameObject.GetComponent<Image>().color = new Color32(114,238,111,255);
    }
    public void DeselectTool()
    {
        //Set to Normal Color
        gameObject.GetComponent<Image>().color = new Color32(255,255,255,255);
    }

    int UseTool()
    {
        //TODO Set it so that when a tool is used that it checks whether the ID matches the debris that it's being used on. 
        //We'll likely have another means of destroying an instance of a 
        return toolID;
    }

    void DestroyDebris()
    {
        //Remove debris from a location based on the tool being used, if it matches the debris will be removed.  Otherwise it'll stay there, possible add in an error message of some sort.
    }
}
