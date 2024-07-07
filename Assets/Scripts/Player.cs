using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int life;
    public float rofTime;   //Duración del RoF
    public bool hasKey;
    public bool hasKeyCard;
    public bool hasChem;
    public bool hasArmor;
    public bool rofActive;       //Rate of Fire
    public GameObject bulletSpawn;
    public Rigidbody2D rb;
    public SpriteRenderer PlayerSprite;
    public Proyectile Bullet;
    private float speedF = 4;     //Foward Speed
    private float speedB = 2.75f; //Backward Speed
    private float speedH = 2;     //Horizontal Speed
    private float speedR = 180;   //Rotation Speed
    private float shootTime = 0.8f;  //Rate of Fire
    private float cooldownTime;     //Tiempo a esperar
    private bool shootCooldown;     //Si el cooldown está activo
    Vector3 BZone = new Vector3(-102,2,0);
    Vector3 AZone = new Vector3(-18.5f, 8, 0);
   
    private void Start()
    {
        life = 6;
    }

    void Update()
    {
        if(life == 0)
        {
            SceneManager.LoadScene("Death");
        }


        cooldownTime += 1 * Time.deltaTime;
        if (cooldownTime>shootTime)
        {
            shootCooldown = false;
        }

        rofTime += 1 * Time.deltaTime;
        if (rofActive == true)
        {
            shootTime = 0.3f;
            if (rofTime > 5.2f)
            {
                rofActive = false;
                shootTime = 0.8f;
            }
        }       
       
        if (Input.GetKey(KeyCode.W))
        {
            MoveFront();
        }
        if (Input.GetKey(KeyCode.S))
        {
            MoveBack();
        }
        if (Input.GetKey(KeyCode.Q))
        {
            MoveLeft();
        }
        if (Input.GetKey(KeyCode.E))
        {
            MoveRight();
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            MoveRotation();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 14 && hasKeyCard == true && hasChem == false)
        {
            this.transform.position = BZone;
        }
        if (collision.gameObject.layer == 15 && hasChem == true)
        {
            this.transform.position = AZone;
        }

    }

    private void MoveFront()
    {
        transform.position += transform.up * speedF * Time.deltaTime;
    }
    void MoveBack()
    {
        transform.position += -transform.up * speedB * Time.deltaTime;
    }
    void MoveRight()
    {
        transform.position += transform.right * speedH * Time.deltaTime;
    }
    void MoveLeft()
    {
        transform.position += -transform.right * speedH * Time.deltaTime;
    }
    void MoveRotation()
    {
        Vector3 PlayerRotation = transform.rotation.eulerAngles;
        PlayerRotation += new Vector3(0, 0, -Input.GetAxis("Horizontal")) * speedR * Time.deltaTime;
        transform.rotation = Quaternion.Euler(PlayerRotation);
    }

    void Shoot()
    {
        if (shootCooldown == false)
        {
            Proyectile bulletTemp = Instantiate(Bullet);
            bulletTemp.transform.position = bulletSpawn.transform.position;
            bulletTemp.transform.rotation = bulletSpawn.transform.rotation;
            shootCooldown = true;
            cooldownTime = 0;
        }
    }
}

