using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public bool IsPaused { get { return isPaused; } }
    private bool isPaused;

    void Awake() {
        if (Instance == null) {
            Instance = this;
        } else {
            Debug.Log("So many GameManagers error");
        }
    }

    public void Pause(bool pause)
    {
        isPaused = pause;
    }
    
    // public bool IsPaused()
    // {
    //     return isPaused;
    // }
}