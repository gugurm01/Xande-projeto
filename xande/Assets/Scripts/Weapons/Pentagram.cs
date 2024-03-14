using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pentagram : MonoBehaviour
{
    BoxCollider2D collisor2D;
    SpriteRenderer spriteRenderer;
    public int notDestroyChance;
    // Start is called before the first frame update
    void Start()
    {
        collisor2D = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Enemy":
                Enemy enemy = collision.GetComponent<Enemy>();
                enemy.TakeDamage(enemy.life);
                break;
            case "XP":
                if (Random.Range(0, 100) <= notDestroyChance)
                {
                    Destroy(collision.gameObject);
                }
                break;
        }
        if(Random.Range(0, 100) <= notDestroyChance)
        {
            Destroy(collision.gameObject);
        }
 
    }

    public void PentagramEnds()
    {
        gameObject.SetActive(false);
    }
}
