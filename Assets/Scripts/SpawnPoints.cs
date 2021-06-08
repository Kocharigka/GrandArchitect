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
    public Text bag;

    // Start is called before the first frame update
    public void Spawn()
    {
        string[] z = clickLabel.text.Split('/');
        float minX = rend.bounds.center.x - rend.bounds.extents.x+0.1f;
        float maxX = rend.bounds.center.x + rend.bounds.extents.x-0.1f;
        float minY = rend.bounds.center.y - rend.bounds.extents.y+ 0.1f;
        float maxY = rend.bounds.center.y + rend.bounds.extents.y- 0.1f;
        LayerMask layer = 6;
        int insideCount = 0;
        if (int.Parse(z[0]) > 0)
        {
            if (int.Parse(bag.text) > 0)
            {

                for (int i = 1; i <= spawnCount; i++)
                {
                    float x = Random.Range(minX, maxX);
                    float y = Random.Range(minY, maxY);
                    Vector3 location = new Vector3(x, y, 0);
                    var point = Instantiate(toSpawn, location, Quaternion.identity, pointParent);
                    point.GetComponent<SpriteRenderer>().sortingOrder = 3;
                    RaycastHit2D hitUp = Physics2D.Raycast(point.transform.position, Vector2.left, layer);
                    RaycastHit2D hitDown = Physics2D.Raycast(point.transform.position, Vector2.right, layer);
                    if (hitUp.collider != null && hitDown.collider != null)
                        insideCount += 1;

                }
                pointsAll.text = (int.Parse(pointsAll.text) + spawnCount).ToString();
                pointsInside.text = (int.Parse(pointsInside.text) + insideCount).ToString();
                clickLabel.text = (int.Parse(z[0]) - 1).ToString() + '/' + z[1];
                sandLabel.text = (int.Parse(sandLabel.text) - spawnCount).ToString();
            }
        }
        else clickLabel.color = Color.red;

    }
}