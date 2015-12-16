using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject[] lanePrefabs;
    public float laneWidth;
    public float respawnMargin;
    public GameObject player;

    private float startOffset = 0;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        float playerForwardPosition = player.transform.position.z;
        while (playerForwardPosition > (startOffset - respawnMargin)) 
        {
            int randomLane = Random.Range(0, lanePrefabs.Length);
            print(randomLane);
            Vector3 startPosition = Vector3.zero + Vector3.forward * startOffset;
            Instantiate(lanePrefabs[randomLane], startPosition, Quaternion.identity);
            startOffset += laneWidth;
        }
    }
}
