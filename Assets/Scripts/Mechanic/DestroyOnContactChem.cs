using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContactChem : MonoBehaviour
{
    public GameObject target;

    void Awake()
    {
        target = GameObject.Find("PlayerSprite");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.layer == 8 && target.transform.GetComponent<Player>().hasChem == true)
       {
         Destroy(this.gameObject);
       }
    }
    
}

