using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] vehiclePrefabs;
	
	// Update is called once per frame
	void Update () {
		foreach (GameObject thisVehicle in vehiclePrefabs) {
			if (isTimeToSpawn (thisVehicle)) {
				Spawn (thisVehicle);
  			}
		}	
	}
	
	void Spawn (GameObject myGameObject) {
		GameObject myVehicle = Instantiate (myGameObject) as GameObject;
		myVehicle.transform.parent = transform;
		myVehicle.transform.position = transform.position;
        myVehicle.GetComponent<Rigidbody>().velocity = transform.forward * 10f;
	}
	
	bool isTimeToSpawn (GameObject vehicleGameObject) {
		Vehicle vehicle = vehicleGameObject.GetComponent<Vehicle>();
		
		float meanSpawnDelay = vehicle.seenEverySeconds;
		float spawnsPerSecond = 1 / meanSpawnDelay;
		
		if (Time.deltaTime > meanSpawnDelay) {
			Debug.LogWarning ("Spwan rate capped by frame rate");
		}
		
		float threshold = spawnsPerSecond * Time.deltaTime;
		
		if (Random.value < threshold) {
			return true;
		} else {
			return false;
		}
	}
}
