# Practica3_FísicasEnUnity

**Autor:** Saúl Lorenzo Armas

**Gmail:** alu0101642468@ull.edu.es

En este repositorio están las diferentes situaciones y ejercicios relacionados con las físicas de Unity. La idea es introducir el uso del motor de físicas de Unity con C# para ver cómo interactúan los objetos entre sí. 

El principal componente que se usa para esto es el **Rigidbody**, que permite a los objetos moverse y reaccionar a las fuerzas físicas. Además, se usan **Colliders** para detectar colisiones y **Triggers** para detectar, mediante mensajes, cuando un objeto entra o sale de un área determinada.

Existen dos carpetas principales en el repositorio:

*   [**Ejercicios (`/Ejercicios`)**](./Ejercicios/README.MD)
  Aquí están todos los scripts que resuelven los ejercicios:
    *   Cómo usar los Triggers (`OnTriggerEnter`, `Stay`, `Exit`) para cambiar cosas de otros objetos al tocarlos (quitar vida, cambiar colores, apagar luces).
    *   Cómo usar las capas (Layers) y configurar la Matriz de Colisiones para decidir quién choca con quién (por ejemplo, que los enemigos no se estorben entre ellos).
    *   Uso de Materiales Físicos para hacer superficies que resbalan como el hielo o objetos que reboten bastante.
*   [**Situaciones (`/Situaciones`)**](./Situaciones/README.md)
  Aquí se hacen pruebas con un mismo escenario cambiando la configuración de los objetos (por ejemplo, poniéndole físicas a uno y a otro no) para ver en la práctica cómo reacciona Unity ante cada situación.