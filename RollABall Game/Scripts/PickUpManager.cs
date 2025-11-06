using UnityEditor.ShaderGraph.Drawing.Inspector.PropertyDrawers;
using UnityEngine;

public class PickUpManager : MonoBehaviour
{
    public GameObject pickup;
    public GameObject ground;
    public int amount;
    
    void Start()
    {
        float groundSizeX = ground.transform.localScale.x * 1f;
        float groundSizeZ = ground.transform.localScale.z * 1f;

        for(int i=0;i<amount; i++)
        {
            float randomX = Random.Range(-groundSizeX / 2f, groundSizeX / 2f);
            float randomZ = Random.Range(-groundSizeZ / 2f, groundSizeZ / 2f);

            Vector3 location = new Vector3(randomX, 3f,randomZ);
            Instantiate(pickup, location, Quaternion.identity);

        }
    }
}
