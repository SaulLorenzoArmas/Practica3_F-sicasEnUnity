using UnityEngine;

public class Ejercicio2_ColisionesFisicas : MonoBehaviour
{
    Renderer componenteRender;
    void Start() {
        componenteRender = GetComponent<Renderer>();   
    }
    private void OnCollisionEnter(Collision other) {
        Debug.Log(gameObject.name + " colisionó con " + other.gameObject.name);
        componenteRender.material.color = new Color(Random.value, Random.value, Random.value);
    }
}