using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garlic : MonoBehaviour
{
    float timer;
    public float waveRate;
    List<Enemy> enemies = new List<Enemy>();
    public int dano;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>= waveRate)
        {

        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        enemies.Add(collision.GetComponent<Enemy>());
        if (!enemies[enemies.Count - 1].garliczed)
        {
            enemies[enemies.Count - 1].TakeDamage(dano);
        }
    }
}
