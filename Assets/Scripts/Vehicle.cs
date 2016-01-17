using UnityEngine;
using System.Collections;

public class Vehicle : MonoBehaviour {

    private float speed;
    private float length;

	// Use this for initialization
	void Start () {
        float lifeSpanTime = length / speed;
        Invoke("Remove", lifeSpanTime);
    }

    void Remove ()
    {
        Destroy(gameObject);
    }

    public void SetPath(float someSpeed, float someLength)
    {
        speed = someSpeed;
        length = someLength;
    }

    void Update ()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
