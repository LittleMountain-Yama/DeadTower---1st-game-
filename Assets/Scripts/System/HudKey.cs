using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudKey : MonoBehaviour
{
    public Image keyimage;
    public Player player;
    public GameObject target;
    public Sprite[] keys;


    private void Awake()
    {
        target = GameObject.Find("PlayerSprite");
    }
    private void Start()
    {
        keyimage.sprite = keys[0];
    }
    private void Update()
    {
        if (target.transform.GetComponent<Player>().hasKey == true)
        {
            keyimage.sprite = keys[1];
        }
        if (target.transform.GetComponent<Player>().hasKey == false)
        {
            keyimage.sprite = keys[0];
        }
    }
}