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
    public static void StartGame()
    {
        SceneManager.LoadScene("Development Scene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
