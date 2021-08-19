using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompleteTask : MonoBehaviour
{
    public Sprite newMenu;
    public static CompleteTask instance;
    // Start is called before the first frame update
    private void Awake() 
    {
        instance = this;
    }
    public void UpdateMenu()
    {
        gameObject.GetComponent<UnityEngine.UI.Image>().sprite = newMenu;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
