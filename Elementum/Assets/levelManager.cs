using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("TutorialScene",LoadSceneMode.Single);
    }


     public void Quit()
    {
        Debug.Log("Si esto fuera una Build, el juego se habría cerrado.");
        Application.Quit();
    }
    
}
