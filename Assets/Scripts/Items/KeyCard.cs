using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCard : MonoBehaviour {

    public GameObject target;

    private void Awake()
    {
        target = GameObject.Find("PlayerSprite");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8 && target.transform.GetComponent<Player>().hasKeyCard == false)
        {
            target.transform.GetComponent<Player>().hasKeyCard = true;
            Destroy(this.gameObject);
        }
    }
}
