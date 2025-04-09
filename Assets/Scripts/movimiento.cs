using UnityEngine; // Necesario para usar Unity

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Velocidad del personaje
    private Rigidbody2D rb;  // Referencia al Rigidbody2D

    void Start()
    {
        // Obtener el Rigidbody2D del personaje
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move(); // Llamar a la funci�n de movimiento
    }

    void Move()
    {
        // Obtener la direcci�n en X e Y seg�n las teclas presionadas
        float moveX = 0f;
        float moveY = 0f;

        // Izquierda
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }

        // Derecha
        if (Input.GetKey(KeyCode.D))
        {
            moveX = 1f;
        }

        // Arriba
        if (Input.GetKey(KeyCode.W)) { 
            moveY = 1f; 
        }

        // Abajo
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        } 

        // Normalizar el movimiento para que no sea m�s r�pido en diagonal
        Vector2 moveDirection = new Vector2(moveX, moveY).normalized;

        // Aplicar velocidad al Rigidbody2D
        rb.linearVelocity = moveDirection * speed;
    }
}
