using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Sword : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    public static int score = 0;

    void Start()
    {

    }

    void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            score++;
            scoreText.text = "Score: " + score;
        }
    }
}
