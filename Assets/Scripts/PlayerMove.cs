using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public Camera playerCamera;
    public CharacterController characterController;
    Vector3 velocity;
    public float speed;
    public float walkSpeed = 2f;
    public float runSpeed;
    public bool canJump = true;
    public Transform groundcheck;
    public float sphereRadius = 0.1f;
    public LayerMask groundMask;
    public float gravity = -9.81f;
    bool isGrounded;
    public float jumpHeight = 0.75f;
    public float gravityMultiplier = 2;

    private void Start()
    {
        speed = walkSpeed;
        runSpeed = speed * 2f; // Duplica la velocidad cuando el personaje está corriendo respecto de la velocidad andando
   }

    void Update()
    {
        Movement();
        CheckRun();
        CheckJump();
    }

    public void Movement()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z; // Aplica las rotaciones vertical y horizontal para crear un vector

        characterController.Move(speed * Time.deltaTime * move.normalized); // Aplica el vector creado ajustando la velocidad de movimiento del jugador(corriendo/andando)
        velocity.y += gravity * Time.deltaTime; // Modifica la velocidad vertical (salto) en función de la gravedad establecida
        characterController.Move(velocity * Time.deltaTime); // Aplica todos los movimientos al personaje
   }

    public void CheckJump()
    {

        if (IsGrounded() && velocity.y < 0) // Comprueba que el jugador esté en el suelo y no esté en movimiento
        {
            velocity.y = -2; // Establece una velocidad de caída fija para prevenir que esta no pare de crecer
        }

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded() && canJump) // Comprueba que se esté pulsando la tecla de salto, que esté en el suelo y que le esté permitido saltar
        {
            velocity.y = 4; // Establece la velocidad de salto
        }
   }

    public void CheckRun()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W)) // Comprueba que las teclas de avanzar y correr estén siendo pulsadas
        {
            speed = runSpeed; // Modifica la velocidad para establecer la velocidad de correr
        }
        else if (!Input.GetKey(KeyCode.LeftShift) || (!Input.GetKey(KeyCode.W) && speed != walkSpeed) )
        {
            speed = walkSpeed; // Modifica la velocidad para establecer la velocidad de andar
        }
    }
    
    private bool IsGrounded() => characterController.isGrounded; // Este método comprueba que el jugador esté en el suelo a través del caracter controller
}
