using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WeaponTimer : MonoBehaviour
{
    public UnityEvent OnTimerAttack;

    //public GameObject weapon;
    public float timerToActivate;

    float timer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Activate());
    }

    // Update is called once per frame
    void Update()
    {
        /*
        timer += Time.deltaTime;
        if (timer > timerToActivate)
        {
            ActiveWeapon();
            timer = 0;
        }
        */
    }

    IEnumerator Activate()
    {
        yield return new WaitForSeconds(timerToActivate);
        ActiveWeapon();
        StartCoroutine(Activate());
    }

    private void ActiveWeapon()
    {
        OnTimerAttack.Invoke();
        //weapon.SetActive(true);
    }
}
