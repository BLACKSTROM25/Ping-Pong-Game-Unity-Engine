using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButton : MonoBehaviour
{
    public void EnterGame(int Scene_No)
    {
        SceneManager.LoadScene(Scene_No);
    }
}
