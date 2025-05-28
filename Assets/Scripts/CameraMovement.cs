using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform playerTransform;
    public Vector3 offset;
    public Vector2 minPosition;
    public Vector2 maxPosition;
    private Vector3 desiredPosition;
    public float interpolationRatio = 0.5f;

    // Start is called before the first frame update


    void Awake()
    {
        playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        float clampX = Mathf.Clamp(desiredPosition.x,minPosition.x, maxPosition.x);

        float clampY = Mathf.Clamp(desiredPosition.y ,minPosition.y, maxPosition.y);

        transform.position = playerTransform.position + offset;
    }
}
