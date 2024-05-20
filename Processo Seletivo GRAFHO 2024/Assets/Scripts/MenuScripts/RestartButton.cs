using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    public void OnButtonPress()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
        Player.dead = false;
    }
}
