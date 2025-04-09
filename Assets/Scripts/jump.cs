using UnityEngine; // Necesario para usar Unity

public class PlayerJump : MonoBehaviour
{
    public float speed = 5f;       // Velocidad del personaje
    public float jumpForce = 7f;   // Fuerza del salto
    public Transform groundCheck;  // Punto de verificaci�n para saber si est� en el suelo
    public LayerMask groundLayer;  // Capa que representa el suelo

    private Rigidbody2D rb;        // Referencia al Rigidbody2D
    private bool isGrounded;       // Indica si el personaje est� tocando el suelo

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtener el Rigidbody2D del personaje
    }

    void Update()
    {
        Move();  // Llamar a la funci�n de movimiento
        Jump();  // Llamar a la funci�n de salto
    }

    void Move()
    {
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
        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1f;
        }

        // Abajo
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }

        Vector2 moveDirection = new Vector2(moveX, moveY).normalized;
        rb.linearVelocity = new Vector2(moveDirection.x * speed, rb.linearVelocity.y);
    }

    void Jump()
    {
        // Verificar si el personaje est� tocando el suelo
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);

        // Si presiona espacio y est� en el suelo, salta
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }
}
