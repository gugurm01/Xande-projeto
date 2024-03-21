using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Garlic : MonoBehaviour
{
    float timer;
    public float waveRate;
    [SerializeField]List<Enemy> enemies = new List<Enemy>();
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= waveRate)
        {
            foreach(Enemy enemy in enemies) 
            {
                enemy.TakeDamage(damage);
            }
            timer = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemies.Add(collision.GetComponent<Enemy>());
        if (!enemies[enemies.Count - 1].garliczed)
        {
            enemies[enemies.Count - 1].garliczed = true;
            enemies[enemies.Count - 1].TakeDamage(damage);
        }
        //collision.AddComponent<GarlicEffect>();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        enemies.Remove(collision.GetComponent<Enemy>());
        //Destroy(collision.GetComponent<GarlicEffect>());
    }
    void NullElementRemove()
    {
        for (int i = 0; i < enemies.Count; i++)
        {
            if (enemies[i] == null)
            {
                enemies.RemoveAt(i);
            }
        }
    }
}
