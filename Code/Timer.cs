using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Target : MonoBehaviour
{
    public TextMeshProUGUI timerLbl;
    public float timer = 10f;

    private void update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            timerLbl.text = "Game Over";
        }
    }

    private void DisplayTIme (float displayTIme)
    {
        float minutes = Mathf.FloorToInt(displayTIme / 60);
        float seconds = Mathf.FloorToInt(displayTIme % 60);
        timerLbl.text = $"{minutes}:{seconds}";
    }
}