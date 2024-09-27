using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ColorBox : MonoBehaviour
{
    public GameObject[] fruitPrefabs;
    public Score scoreCounter;

    public AudioSource positiveSound;
    public AudioSource negativeSound;

    public GameObject currentBox;
    public FruitType acceptedFruitType;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Fruit anyFruit = collision.gameObject.GetComponent<Fruit>();
        if (anyFruit != null)
        {
            Debug.Log("Collision");

            if (anyFruit.fruitType == acceptedFruitType)
            {
                scoreCounter.AddScore(1);
                positiveSound.Play();

                return;
            }
            else
            {
                negativeSound.Play();
            }
        }
    }
}
