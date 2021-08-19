using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MissionPopup : MonoBehaviour
{
    public GameObject popUpBox;
    public Animator animator;
    public TMP_Text popUpText1;
    public TMP_Text popUpText2;
    public TMP_Text popUpText3;

    public void PopUp(string text, string text2, string text3)
    {
        popUpBox.SetActive(true);
        popUpText1.text = text;
        popUpText2.text = text2;
        popUpText3.text = text3;
        animator.SetTrigger("pop");
    }
}
