using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPipe : MonoBehaviour
{
    public int columnPipeSize;
    public GameObject columnPrefab;
    public float spawnRate; 
    public float columnMin;
    public float columnMax;

    private GameObject[] columns;
    private Vector2 objectPipe = new Vector2(-15f, -25f);
    private float timeLastSpawned;
    private float spawnXPosition = 10f;
    private int currentColumn = 0;
    // Start is called before the first frame update
    void Start()
    {
        columns = new GameObject [columnPipeSize];
        for(int i = 0; i < columnPipeSize; i++)
        {
            columns[i] = (GameObject)Instantiate(columnPrefab, objectPipe, Quaternion.identity);
        }   
    }

    // Update is called once per frame
    void Update()
    {
        timeLastSpawned += Time.deltaTime;

        if(GameController.instance.gameOver == false && timeLastSpawned >= spawnRate)
        {
            timeLastSpawned = 0;
            float spawnYposition = Random.Range(columnMin, columnMax);
            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYposition);
            currentColumn++;
            if(currentColumn >= columnPipeSize)
            {
                currentColumn = 0;
            }
        }
    }
}
