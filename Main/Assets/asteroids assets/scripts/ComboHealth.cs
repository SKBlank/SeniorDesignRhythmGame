using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboHealth : MonoBehaviour
{
    public int combo = 0;
    public int health = 3;

    public void IncreaseCombo()
    {
        combo++;
        print("Combo: " + combo);
    }

    public void DecreaseHealth()
    {
        health--;
    }

    public void ResetCombo()
    {
        combo = 0;
        print("Combo: " + combo);
    }
}
