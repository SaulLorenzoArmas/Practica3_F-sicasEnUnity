using UnityEngine;

public class Ejercicio5_AplicarFuerza : MonoBehaviour {
  Rigidbody componenteRigid;
  public float fuerza;
  void Start() {
    componenteRigid = GetComponent<Rigidbody>();
  }
  void FixedUpdate() {
    if (Input.GetKeyDown(KeyCode.X)) {
      // El impulse es para ue se aplique toda la fuerza de golpe.
      // Y el vector es para la direccion en la que se aplica la fuerza.
      componenteRigid.AddForce(new Vector3(1,0,0) * fuerza, ForceMode.Impulse);  
    }
  }

}
