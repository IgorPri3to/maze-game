using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuManager : MonoBehaviour
{
    public Canvas HUD;
    public AudioSource music;
    CanvasGroup canvasGroup;
    CanvasGroup hud;
   
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        hud = HUD.gameObject.GetComponent<CanvasGroup>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canvasGroup.alpha == 1) {
                canvasGroup.alpha = 0;
                hud.alpha = 1;
                CursorManager.ToggleCursor(false);
                Time.timeScale = 1;
                music.volume = 0.2f;
                GameManager.Instance.Pause(false);
            } else {
                canvasGroup.alpha = 1;
                hud.alpha = 0;
                CursorManager.ToggleCursor(true);
                Time.timeScale = 0;
                music.volume = 0.05f;
                GameManager.Instance.Pause(true);
            }
        }    
    }


}
