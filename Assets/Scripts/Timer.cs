using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float time = 120f;
    public Text timer;

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime; // Resta el tiempo para el cronómetro cada segundo
        if(time > 0) {
            timer.text = $"Time: {time.ToString("0")}"; // Si el tiempo no es cero, modifica el valor del cronómetro con el tiempo restante
        } else {
            CursorManager.ToggleCursor(true);
            SceneManager.LoadScene(2); // Cambia de escena
        }
    }
}
