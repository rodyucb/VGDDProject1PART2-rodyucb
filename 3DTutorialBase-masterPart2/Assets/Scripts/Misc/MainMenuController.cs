using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    #region Editor Variables 
    [SerializeField]
    [Tooltip("The text component housing the current high score")]
    private Text m_HighScore;
    #endregion

    #region Private Variables
    private string m_DefaultHighScoreTest;
    #endregion 

    #region Initialization
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        m_DefaultHighScoreTest = m_HighScore.text;
    }
    private void Start()
    {
        UpdateHighScore();
    }
    #endregion



    #region Play Button Methods
    public void PlayArena()
    {
        SceneManager.LoadScene("Arena");
    }
    #endregion

    #region General Application Button Methods
    public void Ouit()
    {
        Application.Quit();
    }
    #endregion

    #region High Score Methods
    private void UpdateHighScore()
    {
        if (PlayerPrefs.HasKey("HS"))
        {
            m_HighScore.text = m_DefaultHighScoreTest.Replace("%S", PlayerPrefs.GetInt("HS").ToString());
        }
        else
        {
            PlayerPrefs.SetInt("HS", 0);
            m_HighScore.text = m_DefaultHighScoreTest.Replace("%S", "0");
        }
    }
    public void ResetHighScore()
    {
        PlayerPrefs.SetInt("HS", 0);
        UpdateHighScore();
    }
    #endregion 
}
