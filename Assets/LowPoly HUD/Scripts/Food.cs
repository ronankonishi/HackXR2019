using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public int FoodPoints = 20;

    public void OnUse()
    {
        GameManager.Instance.Player.Eat(FoodPoints);

        Destroy(gameObject);
    }
}
