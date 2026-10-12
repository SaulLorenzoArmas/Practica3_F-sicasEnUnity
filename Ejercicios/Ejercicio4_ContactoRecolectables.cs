using UnityEngine;

public class Ejercicio4_ContactoRecolectables : MonoBehaviour {
  void OnTriggerEnter(Collider other) {
    Debug.Log(gameObject.name + " ha interactuado con " + other.gameObject.name);
  }

}
