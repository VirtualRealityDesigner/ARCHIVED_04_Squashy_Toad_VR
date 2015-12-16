using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject[] lanePrefabs;
    public float laneWidth = 2f;
    public float spawnHorizon = 500f;
    public GameObject player;
    public Transform parentTransform;

    private float startOffset = 0;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        float playerForwardPosition = player.transform.position.z;
        while (playerForwardPosition > (startOffset - spawnHorizon)) 
        {
            int randomLane = Random.Range(0, lanePrefabs.Length);
            Vector3 startPosition = Vector3.forward * startOffset;
            GameObject newLane = Instantiate(lanePrefabs[randomLane], startPosition, Quaternion.identity) as GameObject;
            newLane.transform.parent = parentTransform;
            startOffset += laneWidth;
        }
    }
}
