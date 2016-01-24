using UnityEngine;
using System.Collections;

public class VehicleSpawner : MonoBehaviour {

    public GameObject[] vehiclePrefabs;
    public float heightOffset = 1f;
    public float startOffset = -10f;

    // Use this for initialization
    void Start() {
        Vector3 positionOffset = transform.position;
        positionOffset += heightOffset * Vector3.up;
        positionOffset += startOffset * Vector3.right;
        GameObject vehicleObject = Instantiate(vehiclePrefabs[0]);
        vehicleObject.transform.position = positionOffset;
        vehicleObject.transform.parent = transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
