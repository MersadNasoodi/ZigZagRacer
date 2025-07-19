using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TMP_Text record;
    

    private void Start()
    {
        record.text = PlayerPrefs.GetInt("HighestScore").ToString();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    
    }
}
