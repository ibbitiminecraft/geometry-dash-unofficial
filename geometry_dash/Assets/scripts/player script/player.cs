using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class player : MonoBehaviour
{
    private float motion_force;
    [SerializeField]
    private float jump_force;
    private Transform transform;
    private Rigidbody2D myBody;
    private bool isGrounded = true;
    public float rotationspeed = 720f;
    public float targetrotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform = GetComponent<Transform>();
        motion_force = 10;
        myBody = GetComponent<Rigidbody2D>();
        float currentz = transform.eulerAngles.z;
        float newz = Mathf.MoveTowardsAngle(currentz, targetrotation, rotationspeed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(0, 0, newz);
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1, 0, 0) * motion_force * Time.deltaTime;
        Jump();
        float currentz = transform.eulerAngles.z;
        float newz = Mathf.MoveTowardsAngle(currentz, targetrotation, rotationspeed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(0, 0, newz);
    }
    void Jump()
    {
        if (Keyboard.current.upArrowKey.isPressed && isGrounded == true)
        {
            myBody.AddForce(new Vector2(0f, jump_force), ForceMode2D.Impulse);
            isGrounded = false;
            targetrotation += 180f;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("ground"))
        {
            isGrounded = true;
        }
        if (collision.collider.CompareTag("obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
