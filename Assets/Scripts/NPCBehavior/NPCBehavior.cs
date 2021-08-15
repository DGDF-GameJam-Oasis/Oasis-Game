using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBehavior : MonoBehaviour
{
    public NPCTextLogic mission;
    //Variables for the NPC
    private string npcName;
    private string npcMissionDialogue;
    private string npcMissionCompleteDialogue;
    private string missionName;
    private Queue<string> paragraphs;
    // Start is called before the first frame update
    void Start()
    {
        paragraphs = new Queue<string>();
        // Variables needed here
        // setVariables();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setVariables(string name, string startDialogue, string endDialogue, string mission)
    {
        npcName = name;
        npcMissionDialogue = startDialogue;
        npcMissionCompleteDialogue = endDialogue;
        missionName = mission;
    }

    void OnMouseDown()
    {
        startMission(mission);
    }

    public void startMission(NPCTextLogic missionText)
    {
        Debug.Log(missionText.name + ":" + missionText.missionStartDialogue);
        Debug.Log(missionText.name + ":" + missionText.missionCompleteDialogue);
        Debug.Log(missionText.name + ":" + missionText.missionFailedDialogue);
    }
}