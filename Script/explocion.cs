using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float radioExplosion = 5f;
    public float fuerzaExplosion = 700f;
    public ParticleSystem efectoExplosion; // Asegúrate de asignar este componente en el Inspector

    // Método para activar la explosión
    public void ActivarExplosion()
    {
        // Mostrar el efecto de partículas de la explosión
        Instantiate(efectoExplosion, transform.position, transform.rotation).Play();

        // Detectar objetos dentro del radio de la explosión
        Collider[] objetosAfectados = Physics.OverlapSphere(transform.position, radioExplosion);

        foreach (Collider objetoCercano in objetosAfectados)
        {
            // Intentar obtener el componente Rigidbody del objeto afectado
            Rigidbody rb = objetoCercano.GetComponent<Rigidbody>();
            if (rb != null)
            {
                // Aplicar fuerza de explosión
                rb.AddExplosionForce(fuerzaExplosion, transform.position, radioExplosion);
            }
        }

        // Opcional: Destruir el objeto de la explosión después de un tiempo
        Destroy(gameObject, 2f); // Ajusta el tiempo según sea necesario
    }
}