using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunksGenerator : MonoBehaviour
{
    public Transform player;
    public Road[] ChunkRoads;
    public Road firstRoad;

    private List<Road> spawnedRoads = new List<Road>();

    void Start()
    {
        spawnedRoads.Add(firstRoad);
    }

    void Update()
    {
        if(player.position.y > spawnedRoads[spawnedRoads.Count - 1].end.position.y - 20)
        {
            SpawnChunk();
        }
    }
    private void SpawnChunk()
    {
        Road newRoad = Instantiate(ChunkRoads[Random.Range(0, ChunkRoads.Length)]);
        newRoad.transform.position = spawnedRoads[spawnedRoads.Count-1].end.position - newRoad.begin.localPosition;
        spawnedRoads.Add(newRoad);

        if(spawnedRoads.Count >= 5)
        {
            Destroy(spawnedRoads[0].gameObject);
            spawnedRoads.RemoveAt(0);
        }
    }
}
