using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public Canvas menu;
    public Canvas instructions;

    public void Play()
    {
        CursorManager.ToggleCursor(false);
        SceneManager.LoadScene(1); // Cambia de escena
    }
    
    public void Instructions()
    {
        menu.gameObject.SetActive(false); // Cambia el menú mostrado para mostrar las instrucciones
        instructions.gameObject.SetActive(true);        
    }

    public void Back()
    {
        menu.gameObject.SetActive(true); // Cambia el menú mostrado para volver al menú de inicio
        instructions.gameObject.SetActive(false);        
    }

    public void Exit()
    {
        Application.Quit(); // Cierra el juego
    }
}
