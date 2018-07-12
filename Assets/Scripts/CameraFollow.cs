using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] const float zOffset = -30f;
    Rocket rocket;

    // Use this for initialization
    void Start()
    {
        rocket = FindObjectOfType<Rocket>();
        float xPos = rocket.transform.position.x;
        float yPos = rocket.transform.position.y;
        transform.position = new Vector3(xPos, yPos, zOffset);
	}
	
	// Update is called once per frame
	void Update()
    {
        float xPos = rocket.transform.position.x;
        float yPos = rocket.transform.position.y;
        transform.position = new Vector3(xPos, yPos, zOffset);
    }
}
