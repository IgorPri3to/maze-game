using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance { get; private set; }
    GameObject masterKey;
    public GameObject door;
    string masterKeyresource = "MasterKey";
    public Text message;
    public int collectedKeys = 0;
    public int keysToCollect = 8;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        CursorManager.ToggleCursor(false);
        masterKey = Resources.Load<GameObject>(masterKeyresource); // Carga el recurso de la llave maestra para posteriormente ser instanciado
        if(message) {
            message.gameObject.SetActive(false); // Oculta el mensaje de la llave maestra
        }
    }
    
    void OnTriggerEnter(Collider other) // Se ejecuta cuando el jugador colisiona con un objeto con un collider trigger
    {
        if(other.CompareTag("Key")) { // Si el objeto colisionado es una llave...
            other.gameObject.SetActive(false); // Hace desaparecer la llave
            collectedKeys++; // Suma una llave al conteo de llaves recolectadas
            if(collectedKeys == keysToCollect) { // Si el conteo de llaves recolectadas es igual al total de llaves a recolectar
                Vector3[] positions = {
                    new Vector3(-83,2,-3),
                    new Vector3(19,2,-1),
                    new Vector3(-80,2,-16),
                    new Vector3(-24,2,-66),
                    new Vector3(-29,2,48),
                    new Vector3(14,2,61),
                    new Vector3(-30,2,45)
                };
                int random = Random.Range(0, positions.Length);
                Instantiate(masterKey, positions[random], Quaternion.Euler(90,0,90)); // Instancia la llave maestra en la posición dada
                message.gameObject.SetActive(true); // Muestra el mensaje de la llave maestra
            }
        }
        if(other.CompareTag("MasterKey")) { // Si el objeto colisionado es la llave maestra...
            door.SetActive(false); // Abre la puerta de salida del laberinto
            other.gameObject.SetActive(false); // Hace desaparecer la llave maestra
            message.text = "La puerta ha sido abierta, corre para salir del laberinto"; // Modifica el contenido del mensaje de la llave maestra por el de puerta abierta
        }
    }
}
