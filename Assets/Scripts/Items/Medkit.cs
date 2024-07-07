using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medkit : MonoBehaviour {

    public GameObject target;

    private void Awake()
    {
        target = GameObject.Find("PlayerSprite");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            if (target.transform.GetComponent<Player>().life <= 4)
            {
                target.transform.GetComponent<Player>().life = target.transform.GetComponent<Player>().life + 2;
                Destroy(this.gameObject);
            }
            else if (target.transform.GetComponent<Player>().life == 5)
            {
                target.transform.GetComponent<Player>().life = target.transform.GetComponent<Player>().life + 1;
                Destroy(this.gameObject);
            }
        }
    }
}
