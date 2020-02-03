﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{

    public string TextInScore = "Score :";
    public Text Score;
    public Transform LifeToSpawn;
    GameManager GameManager;
    public GameObject lifePrefab0, lifePrefab1, lifePrefab2;
    int playerLife;


    void activeUi()                                                                         //funzione per far cambiare a schermo le vite del giocatore
    {
        if (playerLife == 3)
        {
            lifePrefab0.SetActive(true);
            lifePrefab1.SetActive(true);
            lifePrefab2.SetActive(true);
        }

        if (playerLife == 2)
        {
            lifePrefab0.SetActive(true);
            lifePrefab1.SetActive(true);
            lifePrefab2.SetActive(false);
        }

        if (playerLife == 1)
        {
            lifePrefab0.SetActive(true);
            lifePrefab1.SetActive(false);
            lifePrefab2.SetActive(false);
        }

        if (playerLife == 0)
        {
            lifePrefab0.SetActive(false);
            lifePrefab1.SetActive(false);
            lifePrefab2.SetActive(false);
        }
    }

    void SetCurrentShipLife()                                                               //funzione per settare la vita del giocatore
    {
        playerLife = GameManager.ActualShip.Life;
    }


    private void Awake()
    {
        GameManager = FindObjectOfType<GameManager>();
        Score.text = TextInScore + GameManager.ActualScore;
        SetCurrentShipLife();
    }

    private void Update()
    {
        Score.text = TextInScore + GameManager.ActualScore;
        SetCurrentShipLife();
        activeUi();
    }
}
