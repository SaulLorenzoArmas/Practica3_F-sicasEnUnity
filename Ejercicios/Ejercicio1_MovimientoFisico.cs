using UnityEngine;

public class Ejercicio1_MovimientoFisico : MonoBehaviour {
    Rigidbody componenteRigidbody;
    public float velocidad; 

    void Start() {
        componenteRigidbody = GetComponent<Rigidbody>();
    } 

    void FixedUpdate() {
        // Se pone en el eje z pq en los juegos 3d  al moverte en vertival no levitas (tipo visto desde arriba)
        Vector3 movimiento = new Vector3 ( Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical")); 
        componenteRigidbody.MovePosition(transform.position + movimiento * Time.fixedDeltaTime * velocidad);
    }
}
