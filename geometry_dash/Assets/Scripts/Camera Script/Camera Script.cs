using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private  Transform playerTransform;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + new Vector3(0,0,-5);
    }
}
