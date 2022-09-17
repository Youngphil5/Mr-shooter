using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private int seconds;
    private float starttime;
    
    [SerializeField] private TextMeshProUGUI timerUIText;

    private void Start()
    {
        starttime = Time.time;
    }

    void Update()
    {
        seconds = (int)(Time.time - starttime);
        updateTimer();

    }

    private void updateTimer()
    {
        timerUIText.text = seconds+" Sec";
    }
}
