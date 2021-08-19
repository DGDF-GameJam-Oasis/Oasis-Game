using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MissionPopup : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string openSound;
     [FMODUnity.EventRef]
    public string closeSound;
    FMOD.Studio.EventInstance openSoundEvent;
    FMOD.Studio.EventInstance closeSoundEvent;

    public GameObject popUpBox;
    public Animator animator;
    private bool menuState;
    // public TMP_Text popUpText1;
    // public TMP_Text popUpText2;
    // public TMP_Text popUpText3;
    void Start()
    {
        openSoundEvent = FMODUnity.RuntimeManager.CreateInstance(openSound);
        closeSoundEvent = FMODUnity.RuntimeManager.CreateInstance(closeSound);
    }

    public void CloseMenu()
    {
        closeSoundEvent.start();
        animator.SetTrigger("close");
        gameObject.GetComponent<Button>().onClick.AddListener(OpenMenu);
        gameObject.GetComponent<Button>().onClick.RemoveListener(CloseMenu);
    }
    public void OpenMenu()
    {
        openSoundEvent.start();
        animator.SetTrigger("pop");
        gameObject.GetComponent<Button>().onClick.AddListener(CloseMenu);
        gameObject.GetComponent<Button>().onClick.RemoveListener(OpenMenu);

    }
}
