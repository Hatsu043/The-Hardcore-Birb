using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;  //Object that spawn in game

    public float spawnRate = 1f;   //Time for respawn pipes
    public float minHeight = -1f;  //Lowest height of pipes
    public float maxHeight = 1f;  //Highest height of pipes

    private void OnEnable()  //Repeat spawn pipes
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()  //Stop spawn pipes in pause mode
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()  //Spawn pipes with different height(from minHeight to maxHeight) 
    {
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}
