using UnityEngine;
using System.Collections;

public class CarSpawner : MonoBehaviour {

    public GameObject[] vehiclePrefab;
    public float startHeight = 1.0f;
    public float startOffset = -500.0f;
    public float finishOffset = 500.0f;
    public float laneSpeed = 5.0f;
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
            InstantiateVehicle(0);
        }
    }

    void InstantiateVehicle(int index)
    {
        float width = finishOffset - startOffset;

        GameObject vehicleObject = (GameObject)Instantiate(vehiclePrefab[0], SpawnPosition(), transform.rotation);
        vehicleObject.transform.parent = transform;

        Vehicle vehicle = vehicleObject.GetComponent<Vehicle>();
        vehicle.SetPath(laneSpeed, width);
    }

    Vector3 SpawnPosition()
    {
        Vector3 startPosition = transform.position;
        startPosition -= Vector3.left * startOffset;
        startPosition += Vector3.up * startHeight;
        return startPosition;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
