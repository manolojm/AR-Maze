using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laberinto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        // Funci�n para destruir la bola
        Destroy(other.transform.gameObject);
    }
}
