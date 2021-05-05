using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnPoints : MonoBehaviour
{
    public GameObject toSpawn;    
    public Renderer rend;
    public Transform pointParent;
    public Text pointsAll;
    public int spawnCount = 100;
    
    // Start is called before the first frame update
    public void Spawn()
    {
        float minX = rend.bounds.center.x - rend.bounds.extents.x;
        float maxX = rend.bounds.center.x + rend.bounds.extents.x;
        float minY= rend.bounds.center.y - rend.bounds.extents.y;
        float maxY = rend.bounds.center.y + rend.bounds.extents.y;        
        
        for (int i=0;i<=spawnCount;i++)
        {
            float x = Random.Range(minX, maxX);
            float y = Random.Range(minY, maxY);            
            Instantiate(toSpawn, new Vector3(x, y, 0), Quaternion.identity,pointParent);
        }
        pointsAll.text=(int.Parse(pointsAll.text)+spawnCount).ToString();
    }
}
