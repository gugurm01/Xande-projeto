using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]

public abstract class Enemy : MonoBehaviour
{
    public int life;
    public float speed;
    protected Rigidbody2D rb2d;
    public GameObject xp;
    public bool garliczed;

    public void Move()
    {
        rb2d.velocity = (PlayerMoviment.playerPosition.position - transform.position) * speed/10;
    }

    public void TakeDamage(int damage)
    {
        life -= damage;
        if(life <= 0)
        {
            if(Random.Range(0,100) <= 25)
            {
                Instantiate(xp,transform.position, transform.rotation);
            }
            Destroy(gameObject);
        }
    }

}
