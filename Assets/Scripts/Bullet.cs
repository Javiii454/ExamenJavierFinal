using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10;
    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.AddForce(transform.right * bulletSpeed, ForceMode2D.Impulse);
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 3)
        {
            BulletDeath();
        }
        
    }

    void BulletDeath()
    {
        Destroy(gameObject);
    }
}
