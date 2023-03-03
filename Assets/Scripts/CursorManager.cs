using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CursorManager 
{
    public static void ToggleCursor(bool state)
    {
        if (state) {
            Cursor.lockState = CursorLockMode.None; // Desbloquea el movimiento del cursor
            Cursor.visible = true; // Hace que el cursor sea visible
        } else {
            Cursor.lockState = CursorLockMode.Locked; // Bloquea el movimiento del cursor
            Cursor.visible = false; // Hace que el cursor sea invisible
        }
    }
}