﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;

    private void Start()
    {
            score = GetComponent<Text>();
      
    }

    public void UpdateScore(int i)
    {
        scoreValue += i;
        score.text = scoreValue.ToString();
    }


}