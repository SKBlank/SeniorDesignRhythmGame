using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboHealth : MonoBehaviour
{
    public GameObject bar;
    public GameObject star;
    public int combo = 0;
    private int health = 50;

    public void IncreaseCombo()
    {
        combo++;
        IncreaseHealth();
        print("Combo: " + combo);
    }

    public void DecreaseHealth()
    {
        health--;

        if (health <= 0)
        {
            health = 0;
            print("Game Over");
        }
    }

    public void ResetCombo()
    {
        combo = 0;
        print("Combo: " + combo);
    }

    public void PlanetHit()
    {
        combo = 0;
        print("Combo: " + combo);
        print("Planet Hit");
    }

    public void IncreaseHealth()
    {
        health++;

        if (health >= 100)
        {
            health = 100;
        }
    }

    void Update()
    {
        bar.transform.localScale = new Vector3(100, health, 100);

        if (health >= 100)
        {
            star.SetActive(true);
        }
        else
        {
            star.SetActive(false);
        }
    }
}
