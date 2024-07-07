using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    public GameObject target;

    private void Awake()
    {
        target = GameObject.Find("PlayerSprite");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8 && target.transform.GetComponent<Player>().hasKey == false)
        {
            target.transform.GetComponent<Player>().hasKey = true;
            Destroy(this.gameObject);
        }
    }
}
