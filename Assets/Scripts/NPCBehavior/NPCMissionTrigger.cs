using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMissionTrigger : MonoBehaviour
{
    public NPCTextLogic mission;

    public void Talk()
    {
        FindObjectOfType<NPCBehavior>().startMission(mission);
    }
}
