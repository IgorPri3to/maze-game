using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public Canvas menu;
    public Canvas instructions;
    public AudioSource buttonsSound;

    public void Play()
    {
        CursorManager.ToggleCursor(false);
        SceneManager.LoadScene(1); // Cambia de escena
        buttonsSound.Play();
    }
    
    public void Instructions()
    {
        menu.gameObject.SetActive(false); // Cambia el menú mostrado para mostrar las instrucciones    
        instructions.gameObject.SetActive(true); // Cambia el menú mostrado para mostrar las instrucciones    
        buttonsSound.Play();
    }

    public void Back()
    {
        instructions.gameObject.SetActive(false); // Cambia el menú mostrado para mostrar las instrucciones    
        menu.gameObject.SetActive(true); // Cambia el menú mostrado para volver al menú de inicio
        buttonsSound.Play();
    }

    public void Exit()
    {
        buttonsSound.Play();
        Application.Quit(); // Cierra el juego
    }
}
