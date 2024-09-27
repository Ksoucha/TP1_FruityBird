using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FruitType
{
    Apple,
    Banana,
    Kiwi,
    None
}

public class Fruit : MonoBehaviour
{
    public FruitType fruitType;

    public float outOfZone = -10;

    private void Update()
    {
        if (transform.position.y < outOfZone)
        {
            Destroy(gameObject);
        }
    }
}

