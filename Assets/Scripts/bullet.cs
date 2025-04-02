using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 1f;
    public Vector2 direction;
    public float x;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = direction.normalized * speed*Time.deltaTime;
        //transform.position = new Vector2(transform.position.x + movement.x, transform.position.y + movement.y);
        //transform.Translate(movement);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space");
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("UP");
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("DOWN");
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("LEFT");
            x = x - 0.01f;
            transform.Translate(movement);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("RIGTH");
            x = x + 0.01f;
            transform.position = new Vector2(transform.position.x + x, transform.position.y + movement.y);
        }
    }
}
