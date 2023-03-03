using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeysCounter : MonoBehaviour
{
    public Text counter;

    // Update is called once per frame
    void Update()
    {
        counter.text = $"Keys: {PlayerManager.Instance.collectedKeys}/{PlayerManager.Instance.keysToCollect}"; // Cambia el texto del contador de llaves recolectadas utilizando las variables de otro script en el que se cuentan
    }
}
