using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void OnClickLoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void LeaveGame()
    {
        Application.Quit();
    }
}
