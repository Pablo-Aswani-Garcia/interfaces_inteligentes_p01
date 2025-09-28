using UnityEngine;

public class script_tarea : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject[] structureObjects;
        structureObjects = GameObject.FindGameObjectsWithTag("structures");
        GameObject[] playerObjects = GameObject.FindGameObjectsWithTag("Player");
        GameObject[] skeletonObjects = GameObject.FindGameObjectsWithTag("skeleton");
        GameObject[] terrainObjects = GameObject.FindGameObjectsWithTag("terrain");
        GameObject[] basicObjects = GameObject.FindGameObjectsWithTag("basic_form");

        foreach (GameObject basicObject in basicObjects)
        {
            Debug.Log(basicObject.transform.position + " " + basicObject.tag);
        }

        foreach (GameObject terrainObject in terrainObjects)
        {
            Debug.Log(terrainObject.transform.position + " " + terrainObject.tag);
        }

        foreach (GameObject structureObject in structureObjects)
        {
            Debug.Log(structureObject.transform.position + " " + structureObject.tag);
        }
        
        foreach (GameObject playerObject in playerObjects)
        {
            Debug.Log(playerObject.transform.position + " " + playerObject.tag);
        }

        foreach (GameObject skeletonObject in skeletonObjects)
        {
            Debug.Log(skeletonObject.transform.position + " " + skeletonObject.tag);
        }
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }
}
