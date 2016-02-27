using UnityEngine;
using System.Collections;

public class FireDestroyer : MonoBehaviour {

	void OnTriggerEnter(Collider collider)
    {
        Destroy(collider.gameObject);
    }
}
