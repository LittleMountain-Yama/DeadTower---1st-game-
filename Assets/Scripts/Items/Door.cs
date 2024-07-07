using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject target;
   
    private void Awake()
    {
        target = GameObject.Find("PlayerSprite");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8 && target.GetComponent<Player>().hasKey == true)
        {
            Destroy(this.gameObject);
            target.transform.GetComponent<Player>().hasKey = false;
        }
    }
}
