using UnityEngine;
using System.Collections;

public class VehicleSpawner : MonoBehaviour {

    public GameObject[] vehiclePrefabs;
    public float heightOffset = 1f;
    public float startOffset = -10f;
    public float speed = 5.0f;
    public float length = 20.0f;
    public float maxSpawnTime = 10f;

    // Use this for initialization
    void Start() {
        StartCoroutine("Spawn");
	}

    IEnumerator Spawn()
    {
        while (true)
        {
            WaitForSeconds randomWait = new WaitForSeconds(Random.Range(0.5f, maxSpawnTime));
            yield return randomWait;

            int vehicleIndex = Random.Range(0, vehiclePrefabs.Length);
            InstantiateVehicle(vehicleIndex);
        }
    }

    void InstantiateVehicle(int vehicleIndex)
    {
        GameObject vehicleObject = Instantiate(vehiclePrefabs[vehicleIndex]);
        vehicleObject.transform.position = GetPositionOffset();
        vehicleObject.transform.parent = transform;

        Vehicle vehicleComponent = vehicleObject.GetComponent<Vehicle>();
        vehicleComponent.SetPath(speed, length);
    }

    Vector3 GetPositionOffset()
    {
        Vector3 positionOffset = transform.position;
        positionOffset += heightOffset * Vector3.up;
        positionOffset += startOffset * Vector3.right;
        return positionOffset;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
