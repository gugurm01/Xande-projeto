using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pentagram : MonoBehaviour
{
    BoxCollider2D collisor2D;
    SpriteRenderer spriteRenderer;
    public int destroyChance;
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
        if(Random.Range(0, 100) <= destroyChance)
        {
            Destroy(collisor2D.gameObject);
        }
    }
}
