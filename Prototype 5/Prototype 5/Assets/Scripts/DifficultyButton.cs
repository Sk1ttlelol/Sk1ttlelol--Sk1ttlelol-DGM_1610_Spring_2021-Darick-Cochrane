﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DifficultyButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    public int difficulty;
    
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty); // on button click, activates SetDifficulty function
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); //This grabs the game manager script
    }

    void SetDifficulty() //Function that tells us which button was clicked, also tells the game manager what difficulty to put the game at
    {
        Debug.Log(gameObject.name + " was clicked!");
        gameManager.StartGame(difficulty);
    }
}
