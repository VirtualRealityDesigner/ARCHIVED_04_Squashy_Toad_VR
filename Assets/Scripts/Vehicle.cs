using UnityEngine;
using System.Collections;

public class Vehicle : MonoBehaviour {

    private float speed;
    private float length;

	// Use this for initialization
	void Start () {
        float lifeTime = length / speed;
        Invoke("Remove", lifeTime);
	}

    void Remove()
    {
        Destroy(gameObject);
    }

    public void SetPath(float someSpeed, float someLength)
    {
        speed = someSpeed;
        length = someLength;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.right * speed * Time.deltaTime;
	}
}
