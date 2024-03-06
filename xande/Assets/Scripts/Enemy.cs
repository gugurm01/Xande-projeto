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

    public void Move()
    {
        rb2d.velocity = (PlayerMoviment.playerPosition.position - transform.position) * speed/10;
    }
}
