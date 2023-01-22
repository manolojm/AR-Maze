using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laberinto : MonoBehaviour
{

    public int puntos;
    public Puntuacion puntuacion;
    public GameObject explosionFin;
    public GameObject textoCompletado;

    private void OnTriggerEnter(Collider other) {

        // Función para destruir las monedas
        if (other.transform.tag == "Coin") {

            Destroy(other.transform.gameObject);
            puntos = 100;
            puntuacion.SumarPuntos(puntos);

        } else {

            // Función para destruir la bola al salir del laberinto
            if (other.transform.tag == "Exit") {

                Destroy(other.transform.gameObject);
                Instantiate(explosionFin, other.transform.position, other.transform.rotation);
                Destroy(gameObject);

                textoCompletado.active = true;
            }
        } 
    }
}
