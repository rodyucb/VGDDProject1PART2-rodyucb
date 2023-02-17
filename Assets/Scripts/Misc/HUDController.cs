using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("The part of the health that decreases")]
    private RectTransform m_HealthBar;
    #endregion

    #region Private Variables
    [SerializeField] Text countdownText;
    private float p_HealthBarOrigWidth;
    private float currentTime;
    private float startingTime = 0f;
    #endregion

    #region Initialization
    private void Awake()
    {
        p_HealthBarOrigWidth = m_HealthBar.sizeDelta.x;
        currentTime = startingTime;
    }
    #endregion

    #region Update Health Bar
    public void UpdateHealth(float percent)
    {
        m_HealthBar.sizeDelta = new Vector2(p_HealthBarOrigWidth * percent, m_HealthBar.sizeDelta.y);
    }
    #endregion
    #region Update Timer
    public void UpdateTime()
    {
        currentTime += 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
    }
    #endregion 
}
