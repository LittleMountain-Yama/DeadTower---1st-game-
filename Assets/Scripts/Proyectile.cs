using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectile : MonoBehaviour {

    public SpriteRenderer bullet;
    private float speed = 7f;
        
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
        
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer != 11 && collision.gameObject.layer != 16)
        {
            Destroy(this.gameObject);
        }
    }

}
