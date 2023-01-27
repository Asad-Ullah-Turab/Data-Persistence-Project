using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuManagerUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameText;

    private string username;

    public void StartNew()
    {
        GameManager.instance.username = nameText.text;
        SceneManager.LoadScene(1);
    }
}
