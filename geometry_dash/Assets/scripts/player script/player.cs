using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    private float motion_force;
    [SerializeField]
    private float jump_force;
    private Transform transform;
    private Rigidbody2D myBody;
    private bool isGrounded = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform = GetComponent<Transform>();
        motion_force = 10;
        myBody = GetComponent<Rigidbody2D>();
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1, 0, 0) * motion_force * Time.deltaTime;
        Jump();
    }
    void Jump()
    {
        if (Keyboard.current.upArrowKey.isPressed && isGrounded == true)
        {
            myBody.AddForce(new Vector2(0f, jump_force), ForceMode2D.Impulse);
            isGrounded = false;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("ground"))
        {
            isGrounded = true;
        }
    }
}
