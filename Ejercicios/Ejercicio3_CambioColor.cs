using UnityEngine;

public class Ejercicio3_CambioColor : MonoBehaviour {
  Renderer componenteRenderOther;
  float contador;
  void OnTriggerEnter(Collider other) {
    componenteRenderOther = other.gameObject.GetComponent<Renderer>();
  }

  void OnTriggerStay(Collider other) {
    contador += Time.fixedDeltaTime;
    if (contador >= 0.2) {
        componenteRenderOther.material.color = new Color(Random.value,Random.value,Random.value);
        contador = 0;
    }
  }

  void OnTriggerExit(Collider other) {
    componenteRenderOther.material.color = Color.gray;
    contador = 0;
  }

}
