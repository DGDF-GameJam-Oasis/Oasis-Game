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

    public void SetVariables(string name, string startDialogue, string endDialogue, string mission)
    {
        npcName = name;
        npcMissionDialogue = startDialogue;
        npcMissionCompleteDialogue = endDialogue;
        missionName = mission;
    }

    void OnMouseDown()
    {
        //DisplayMission
        StartMission(mission);
    }

    public void StartMission(NPCTextLogic missionText)
    {
        Debug.Log(missionText.name + ":" + missionText.missionStartDialogue);
        Debug.Log(missionText.name + ":" + missionText.missionCompleteDialogue);
        Debug.Log(missionText.name + ":" + missionText.missionFailedDialogue);

        paragraphs.Clear();

        foreach(string paragraph in missionText.paragraphs)
        {
            paragraphs.Enqueue(paragraph);
        }

        // void DisplayNextMessage()
        // {
        //     if(paragraphs.Count == 0)
        //     {
        //         EndDialogue();
        //         return;
        //     }

        //     string paragraph = paragraphs.Dequeue();
        //     Debug.Log(paragraph);
        // }

        // void EndDialogue()
        // {
        //     Debug.Log(missionText.missionCompleteDialogue);
        // }
    }
}