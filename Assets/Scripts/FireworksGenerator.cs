using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworksGenerator : MonoBehaviour
{
    [SerializeField] ParticleSystem fireworks;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnFireworks", 1f, 2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpawnFireworks()
    {
        float randomX = Random.Range(-7f, 7f);
        float randomY = Random.Range(-4f, 4f);
        Instantiate(fireworks, new Vector3(randomX, randomY, 0f), Quaternion.identity);
        fireworks.Play();
    }
}
