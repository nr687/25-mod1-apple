using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartButton : MonoBehaviour
{
  
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        SceneManager.LoadScene( "_Scene_0" );
    }
}
