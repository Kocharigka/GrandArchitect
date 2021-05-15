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
    public Text pointsInside;
    public int spawnCount = 100;
    public Text clickLabel;
    public Text sandLabel;

    // Start is called before the first frame update
    public void Spawn()
    {
        string[] z =clickLabel.text.Split('/');
        float minX = rend.bounds.center.x - rend.bounds.extents.x;
        float maxX = rend.bounds.center.x + rend.bounds.extents.x;
        float minY = rend.bounds.center.y - rend.bounds.extents.y;
        float maxY = rend.bounds.center.y + rend.bounds.extents.y;
        int  layer = ~(LayerMask.GetMask("Figure"));
        int insideCount = 0;       
        if (int.Parse(z[0]) > 0)
        {

            for (int i = 1; i <= spawnCount; i++)
            {
                float x = Random.Range(minX, maxX);
                float y = Random.Range(minY, maxY);
                Vector3 location = new Vector3(x, y, 0);
                var point = Instantiate(toSpawn, location, Quaternion.identity, pointParent);
                point.GetComponent<SpriteRenderer>().sortingOrder = 3;
                Debug.Log(layer);
                var result1 = new RaycastHit2D[1];
                var result2 = new RaycastHit2D[1];
                var a = new ContactFilter2D();
                a.minDepth = 10f;
                a.maxDepth = 10f;                
                
                a.layerMask = 6;
                int hitUp = Physics2D.Raycast(point.transform.position, Vector2.left,a,result1,Mathf.Infinity);
                int hitDown = Physics2D.Raycast(point.transform.position, Vector2.right, a, result2, Mathf.Infinity);
                Debug.Log(result1[0].collider);
                Debug.Log(result2[0].collider);
                if (result1[0].collider != null && result2[0].collider != null)
                    insideCount += 1;

            }
            pointsAll.text = (int.Parse(pointsAll.text) + spawnCount).ToString();
            pointsInside.text = (int.Parse(pointsInside.text) + insideCount).ToString();
            clickLabel.text = (int.Parse(z[0]) - 1).ToString()+'/'+z[1];
            sandLabel.text = (int.Parse(sandLabel.text)-spawnCount).ToString();
        }

    }
}
