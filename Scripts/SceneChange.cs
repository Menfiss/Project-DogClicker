using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    
    public void ChangeSceneToMain() 
    {
        SceneManager.LoadScene("Main");
    }

    public void ChangeSceneToSettings() 
    {
        SceneManager.LoadScene("Settings"); 
    }

    public void ChangeSceneToDogCoinFactory() 
    {
        SceneManager.LoadScene("DogCoinFactory"); 
    }
}
