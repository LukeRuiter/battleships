using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {
    public int size;
    public GameObject oceantile;
    public GameObject missTile;
    public GameObject hitTile;
    private Tile[,] map;

	// Use this for initialization
	void Start () {
        updatemap();
        displaymap();
    }
	

    void displaymap()
    {
        for (int x = 0; x < size; x++)
        {
            for (int z = 0; z < size; z++)
            {
                switch (map[x, z].tileType)
                {
                    case TileType.Ocean:
                        Instantiate(oceantile, new Vector3(x, 0, z), Quaternion.identity);
                        break;
                    case TileType.Hit:
                        Instantiate(hitTile, new Vector3(x, 0, z), Quaternion.identity);
                        break;
                    case TileType.Miss:
                        Instantiate(missTile, new Vector3(x, 0, z), Quaternion.identity);
                        break;
                }

            }
        }
    }

    void updatemap()
    {
        map = new Tile[size, size];
        for (int x = 0; x < size; x++)
        {
            for (int z = 0; z < size; z++)
            {
                Tile t = new Tile();
                if (Random.Range(0, 100) > 80)
                {
                    t.tileType = TileType.Hit;
                }
                else
                {
                    t.tileType = TileType.Ocean;
                }
                map[x, z] = t;
            }
        }
    }
	// Update is called once per frame
	void Update () {
       
    }
}
