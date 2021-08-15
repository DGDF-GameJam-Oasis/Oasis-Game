using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBehavior : MonoBehaviour
{
    //Variables for the NPC
    private string npcName;
    private string npcMissionDialogue;
    private string npcMissionCompleteDialogue;
    private string missionName;
    // Start is called before the first frame update
    void Start()
    {
        // Variables needed here
        // setVariables();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetVariables(string name, string startDialogue, string endDialogue, string mission)
    {
        npcName = name;
        npcMissionDialogue = startDialogue;
        npcMissionCompleteDialogue = endDialogue;
        missionName = mission;
    }
}
