using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TerrainLoaderScript : MonoBehaviour
{
    public List<GameObject> tiles;
    public List<GameObject> shuffledTiles;
    private float loadTime = 2f;
    public float interval;
    public float timeCount;
    public int currentTileIndex = 0;

    public bool done = false;

    public GameObject terrain;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach(TileSpawnerScript t in terrain.transform.GetComponentsInChildren<TileSpawnerScript>())
        {
            tiles.Add(t.gameObject);
        }
        interval = loadTime / tiles.Count;
        shuffledTiles = tiles.OrderBy( x => Random.value ).ToList( );
    }

    // Update is called once per frame
    void Update()
    {
        if (!done)
        {
            timeCount += Time.deltaTime;
            if(timeCount >= loadTime)
            {
                done = true;
            }
            if(timeCount >= interval * currentTileIndex)
            {   
                shuffledTiles[currentTileIndex].SetActive(true);
                shuffledTiles[currentTileIndex].transform.SetPositionAndRotation(new Vector3(shuffledTiles[currentTileIndex].transform.position.x, shuffledTiles[currentTileIndex].transform.position.y-20, shuffledTiles[currentTileIndex].transform.position.z), shuffledTiles[currentTileIndex].transform.rotation);
                shuffledTiles[currentTileIndex].GetComponent<TileSpawnerScript>().Spawn();
                currentTileIndex++;
            }
        }
    }
}
