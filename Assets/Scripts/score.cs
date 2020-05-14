﻿using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public float scoreAmount = 10f;
    public float poinIncreasedPerSecond = 10f;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (int)scoreAmount + "";
        scoreAmount += poinIncreasedPerSecond * Time.deltaTime;
    }
}