using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 7f;

    public Transform spawnOffset;

    public GameObject[] fruitPrefabs;
    private GameObject currentFruit;
    bool isHoldingFruit;

    private void Start()
    {
        GrabFruit();
    }

    private void GrabFruit()
    {
        isHoldingFruit = true;
        int randomIndex = Random.Range(0, fruitPrefabs.Length);
        var ballPrefab = fruitPrefabs[randomIndex];
        currentFruit = Instantiate(ballPrefab, spawnOffset.position, Quaternion.identity, spawnOffset);
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        
        Vector3 nextPosition = transform.position;
        nextPosition += new Vector3(x, y, 0) * Time.deltaTime * speed;

        // Ajuster la position pour rester entre un minimum et un maximum
        nextPosition.x = Mathf.Clamp(nextPosition.x, -9f, 9f);
        nextPosition.y = Mathf.Clamp(nextPosition.y, 3.5f, 7f);

        transform.position = nextPosition;

        //
        if (Input.GetKeyDown(KeyCode.Space) && isHoldingFruit)
        {
            isHoldingFruit = false;
            currentFruit.transform.parent = null;
            currentFruit.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            Invoke("GrabFruit", 0.5f);
        }
    }
}
