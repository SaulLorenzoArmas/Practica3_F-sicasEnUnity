using UnityEngine;

public class Ejercicio6_AlcanzarCilindro : MonoBehaviour {
    public float velocidad;
    public Material materialNuevo;
    private GameObject cilidroEnemiga;
    private GameObject cuadradoEnemigo;
    private Renderer materialcuadroEnemigo;
    void Start() {
      cilidroEnemiga = GameObject.FindWithTag("CilindroEnemigo");
      cuadradoEnemigo = GameObject.FindWithTag("CuadroEnemigo");
      materialcuadroEnemigo = cuadradoEnemigo.GetComponent<Renderer>();
    }
    void Update() {
      Vector3 vectorDistancia = cilidroEnemiga.transform.position - transform.position;
      // El normalized es para que la velocidad de movimiento del cubo sea "estable" 
      // y no vaya muy rapido cuando este lejos o lento cuando este cerca.
      transform.Translate(vectorDistancia.normalized * velocidad * Time.deltaTime);
      if (Vector3.Distance(transform.position, cuadradoEnemigo.transform.position) < 1) {
        materialcuadroEnemigo.material = materialNuevo;
      }
    }
}
