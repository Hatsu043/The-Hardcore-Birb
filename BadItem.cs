using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadItem : MonoBehaviour
{
    public BoxCollider2D gridArea;  //Area where use to random item position

    public float speed = 5f;
    private float leftEdge;  //Position that use to destroy items


    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;  //Set leftEdge = left edge of camera
    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;  //Auto move items to left side 

        if (transform.position.x < leftEdge)  //Destroy items if touch left edge of camera
        {
            RandomizePosition();
        }
    }

    public void RandomizePosition()  //Random area to spawn item in gridArea
    {
        Bounds bounds = this.gridArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D other)  //Decrease score when player hit and then reposiotion item
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<GameManager>().DecreaseScore();
            RandomizePosition();
        }

    }
}
