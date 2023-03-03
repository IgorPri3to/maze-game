using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameMenuManager : MonoBehaviour
{
    public void Restart()
    {
        CursorManager.ToggleCursor(false);
        SceneManager.LoadScene(1); // Cambia de escena
    }

    public void Exit()
    {
        CursorManager.ToggleCursor(true);
        SceneManager.LoadScene(0); // Cambia de escena
    }
}
