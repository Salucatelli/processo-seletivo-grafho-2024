using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    public void OnButtonPress()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        scoreText.text = " ";
        Player.dead = false;
    }
}
