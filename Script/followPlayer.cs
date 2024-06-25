using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
    public Transform jugador; // Referencia al jugador
    private Vector3 distancia; // Distancia entre la cámara y el jugador

    void Start()
    {
        // Calcular la distancia inicial entre la cámara y el jugador
        distancia = transform.position - jugador.position;
    }

    void Update()
    {
        // Actualizar la posición de la cámara para seguir al jugador
        transform.position = jugador.position + distancia;
    }
}