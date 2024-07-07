using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDRof : MonoBehaviour
{
    public Image rof;
    public Player player;
    public GameObject target;
    public Sprite[] Rofup;


    private void Awake()
    {
        target = GameObject.Find("PlayerSprite");
    }
    private void Start()
    {
        rof.sprite = Rofup[0];
    }
    private void Update()
    {
        if (target.transform.GetComponent<Player>().rofActive == true)
        {
            rof.sprite = Rofup[1];
        }
        if (target.transform.GetComponent<Player>().rofActive == false)
        {
            rof.sprite = Rofup[0];
        }
    }
}