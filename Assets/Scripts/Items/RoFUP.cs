using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoFUP : MonoBehaviour {

    public GameObject target;

    private void Awake()
    {
        target = GameObject.Find("PlayerSprite");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            if (target.transform.GetComponent<Player>().rofActive == false)
            {
                target.transform.GetComponent<Player>().rofActive = true;
                target.transform.GetComponent<Player>().rofTime = 0;
                Destroy(this.gameObject);
            }
        }
    }
}
