using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameplayUI : MonoBehaviour
{
    public TextMeshProUGUI nameText;

    public void Awake()
    {
        GameManager.instance.Load();
        nameText.text = "Best Score: " + GameManager.instance.highscoreHolder + " " + GameManager.instance.highscore;
    }
}
