using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XP : MonoBehaviour
{
    public int xpGain;
    Rigidbody2D body;
    Transform posPlayer;
    bool isMagnetized;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isMagnetized)
        {
            body.velocity = ((posPlayer.position - transform.position) * 2);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch(collision.tag)
        {
            case "Player":
                Destroy(gameObject);
                PlayerStats.GainXp(collision.GetComponent<PlayerStats>(), xpGain);
                break;

            case "Magnetic":
                posPlayer = collision.transform;
                isMagnetized = true;
                break;
        }
    }
}
