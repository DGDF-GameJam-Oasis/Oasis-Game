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
    public Texture2D newCursor;



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
        Cursor.SetCursor(newCursor, Vector2.zero, CursorMode.ForceSoftware);
        Toolbox.toolboxInstance.SetActiveTool((Toolbox.Tools) toolID, this);
        //Set to Selected Color
        gameObject.GetComponent<Image>().color = new Color32(114,238,111,255);

    }
    public void DeselectTool()
    {
        //Set to Normal Color
        gameObject.GetComponent<Image>().color = new Color32(255,255,255,255);
    }
}
