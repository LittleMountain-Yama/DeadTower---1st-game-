using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudShield : MonoBehaviour
{
    public Image shield;
    public Player player;
    public GameObject target;
    public Sprite[] shieldup;


    private void Awake()
    {
        target = GameObject.Find("PlayerSprite");
    }
    private void Start()
    {
        shield.sprite = shieldup[0];
    }
    private void Update()
    {
        if (target.transform.GetComponent<Player>().hasArmor == true)
        {
            shield.sprite = shieldup[1];
        }
        if (target.transform.GetComponent<Player>().hasArmor == false)
        {
            shield.sprite = shieldup[0];
        }
    }
}