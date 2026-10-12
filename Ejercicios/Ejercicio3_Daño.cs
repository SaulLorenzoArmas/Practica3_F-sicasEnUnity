using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio3_Daño : MonoBehaviour {
  DatosPersonaje datosPersonaje;
  void OnTriggerEnter(Collider other) {
    datosPersonaje = other.gameObject.GetComponent<DatosPersonaje>();
  }
  void OnTriggerStay(Collider other) {
    datosPersonaje.daño += 0.1f;
  }
  void OnTriggerExit(Collider other) {
    datosPersonaje.daño = 0;
  }
}
