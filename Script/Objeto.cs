using UnityEngine;

public class MoverObjeto : MonoBehaviour
{
    public float velocidad = 5.0f;

    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        float movimientoVertical = Input.GetAxis("Vertical") * velocidad * Time.deltaTime;

        transform.Translate(movimientoHorizontal, 0, movimientoVertical);
    }
}


public class RotarObjeto : MonoBehaviour
{
    public float velocidadRotacion = 100.0f;

    void Update()
    {
        float rotacion = Input.GetAxis("Horizontal") * velocidadRotacion * Time.deltaTime;
        transform.Rotate(0, rotacion, 0);
    }
}


public class DetectarColision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colisión detectada con: " + collision.gameObject.name);
    }
}