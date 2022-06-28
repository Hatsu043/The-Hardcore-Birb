using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;
    private float leftEdge;  //Position that use to destroy pipes

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;  //Set leftEdge = left edge of camera
    }

    private void Update()  
    {
        transform.position += Vector3.left * speed * Time.deltaTime;  //Auto move pipes to left side 

        if (transform.position.x < leftEdge)  //Destroy pipes if touch left edge of camera
        {
            Destroy(gameObject);
        }
    }
}
