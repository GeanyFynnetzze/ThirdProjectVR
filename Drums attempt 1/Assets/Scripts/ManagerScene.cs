using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{

    public void LoadBottleGame()
    {
        SceneManager.LoadScene("BottleGame");
    }

    public void LoadDrums()
    {
        SceneManager.LoadScene("Drums");
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("Select");
    }
}
