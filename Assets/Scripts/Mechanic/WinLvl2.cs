using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLvl2 : MonoBehaviour {

    public GameObject target;

    private void Awake()
    {
        target = GameObject.Find("PlayerSprite");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8 && target.transform.GetComponent<Player>().hasChem == true)
        {
            SceneManager.LoadScene("Win2");
        }
    }
}
