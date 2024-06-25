using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiculoController : MonoBehaviour
{
    public float velocidadMovimiento = 10f;
    public float velocidadRotacion = 100f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Obtener el componente Rigidbody
    }

    void Update()
    {
        // Leer la entrada del usuario
        float movimiento = Input.GetAxis("Vertical") * velocidadMovimiento;
        float rotacion = Input.GetAxis("Horizontal") * velocidadRotacion;

        movimiento *= Time.deltaTime;
        rotacion *= Time.deltaTime;

        // Aplicar movimiento y rotación
        rb.MovePosition(rb.position + this.transform.forward * movimiento);
        rb.MoveRotation(rb.rotation * Quaternion.Euler(0, rotacion, 0));

        // Ejemplo de efecto visual: Cambiar el color al moverse
        if (movimiento != 0)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
    }
}