using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class NPCTextLogic
{



    public string name;
    [TextArea(3, 10)]
    public string missionStartDialogue;
    [TextArea(3, 10)]
    public string missionCompleteDialogue;
    [TextArea(3, 10)]
    public string missionFailedDialogue;
    public string[] paragraphs;

}