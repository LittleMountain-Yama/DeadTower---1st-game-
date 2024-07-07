using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDLife : MonoBehaviour
{
    public Image lifeUI;
    public Sprite[] lifeBar;
    public Player player;
    public GameObject target;

    private void Awake()
    {
        target = GameObject.Find("PlayerSprite");
    }

    private void Start()
    {
        if (target.GetComponent<Player>().life <= 6)
        {
            lifeUI.sprite = lifeBar[6];
        }
    }
    private void Update()
    {
        if (target.GetComponent<Player>().life <= 6)
        {
            lifeUI.sprite = lifeBar[target.GetComponent<Player>().life];
        }
        else if (target.GetComponent<Player>().life <= 5)
        {
            lifeUI.sprite = lifeBar[target.GetComponent<Player>().life];
        }
        else if (target.GetComponent<Player>().life <= 4)
        {
            lifeUI.sprite = lifeBar[target.GetComponent<Player>().life];
        }
        else if (target.GetComponent<Player>().life <= 3)
        {
            lifeUI.sprite = lifeBar[target.GetComponent<Player>().life];
        }
        else if (target.GetComponent<Player>().life <= 2)
        {
            lifeUI.sprite = lifeBar[target.GetComponent<Player>().life];
        }
        else if (target.GetComponent<Player>().life <= 1)
        {
            lifeUI.sprite = lifeBar[target.GetComponent<Player>().life];
        }
        else if (target.GetComponent<Player>().life <= 0)
        {
            lifeUI.sprite = lifeBar[target.GetComponent<Player>().life];
        }
    }
    
}