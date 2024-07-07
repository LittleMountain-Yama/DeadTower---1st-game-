using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnPlayerContact : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            Destroy(this.gameObject);
        }
    }
}
