using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : MonoBehaviour {

    public GameObject target;

    private void Awake()
    {
        target = GameObject.Find("PlayerSprite");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            if (target.transform.GetComponent<Player>().hasArmor == false)
            {
                target.transform.GetComponent<Player>().hasArmor = true;
                Destroy(this.gameObject);
            }
        }
    }
}
