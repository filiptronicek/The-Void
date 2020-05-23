using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetHighscore : MonoBehaviour
{

    public void ClearStats()
    {
        PlayerPrefs.SetInt("highScore", 0);
        PlayerPrefs.Save();
    }
}
