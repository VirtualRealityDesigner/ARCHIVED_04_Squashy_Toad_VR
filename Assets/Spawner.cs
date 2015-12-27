using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject[] lanePrefabs;

	// Use this for initialization
	void Start () {
        GameObject lane = lanePrefabs[0];
        Instantiate(lane, Vector3.zero, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
