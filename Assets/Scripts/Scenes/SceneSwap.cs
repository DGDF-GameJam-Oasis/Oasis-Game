using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwap : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public  void StartGame()
    {
        LoadingWait.instance.Activate();
        Invoke("StartOnInvoke",5f);
    }

    public  void SimulateMonetization()
    {
        LoadingWait.instance.Activate();
        Invoke("SimulateOnInvoke",5f);
        
    }
    private void SimulateOnInvoke()
    {
        SceneManager.LoadScene("Premium Scene");
    }
    private void StartOnInvoke()
    {
        SceneManager.LoadScene("Development Scene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
