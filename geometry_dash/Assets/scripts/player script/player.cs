using UnityEngine;

public class player : MonoBehaviour
{
    private float motion_force;
    [SerializeField]
    private Transform transform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform = GetComponent<Transform>();
        motion_force = 10;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1, 0, 0) * motion_force * Time.deltaTime;
    }
}
