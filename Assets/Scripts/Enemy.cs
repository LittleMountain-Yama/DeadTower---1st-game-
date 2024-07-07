using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int life;
    public int damage;
    public GameObject target;
    public Rigidbody2D rb;
    public SpriteRenderer EnemySprite;
    public float speed;
    public float attackTime;
    private float range;
    private float cooldownTime;
    private bool attackCooldown;
    Transform player;
   
    private void Awake()
    {
        range = 0.50f;
        target = GameObject.Find("PlayerSprite");
    }

    void Update ()
    {
        if (life == 0)
        {
            Destroy(this.gameObject);
        }
        cooldownTime += 1 * Time.deltaTime;
        if (cooldownTime > attackTime)
        {
            attackCooldown = false;
            range = 0.5f;
        }
        float distance = Vector3.Distance(transform.position, target.transform.position);
        if (range < distance)
        {
            Vector3 direction = target.transform.position - transform.position;
            transform.position += direction.normalized * speed * Time.deltaTime;
        }               
            Vector3 dir = target.transform.position - transform.position;
            dir.Normalize();
            float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
            transform.rotation = Quaternion.Euler(0, 0, zAngle);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            life--;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (attackCooldown == false && collision.gameObject.layer == 8)
        {
            if (target.transform.GetComponent<Player>().hasArmor == false)
            {
                target.transform.GetComponent<Player>().life = target.transform.GetComponent<Player>().life - damage;
            }
            if (target.transform.GetComponent<Player>().hasArmor == true)
            {
                target.transform.GetComponent<Player>().hasArmor = false;
            }
            attackCooldown = true;
            cooldownTime = 0;
            range = 5f;
        }
    }
}
