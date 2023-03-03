using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameDetector : MonoBehaviour
{
    public void OnTriggerEnter()
    {
        CursorManager.ToggleCursor(true);
        SceneManager.LoadScene(2); // Cambia de escena
    }
}
