using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public void PauseGM()
    {
        Time.timeScale = 0f;
    }
    public void ContinueGM()
    {
        Time.timeScale = 1f;
    }
}
