using UnityEngine;
using System.Collections;

public class VehicleSpawner : MonoBehaviour {

    public GameObject[] vehiclePrefabs;
    public float heightOffset = 1f;
    public float startOffset = -10f;
    public float speed = 5.0f;

    // Use this for initialization
    void Start() {
        InstantiateVehicle();
	}

    void InstantiateVehicle()
    {
        GameObject vehicleObject = Instantiate(vehiclePrefabs[0]);
        vehicleObject.transform.position = GetPositionOffset();
        vehicleObject.transform.parent = transform;

        Vehicle vehicleComponent = vehicleObject.GetComponent<Vehicle>();
        vehicleComponent.SetSpeed(speed);
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
