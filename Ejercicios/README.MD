# Práctica de Unity: Ejercicios Físicas
**Autor:** Saúl Lorenzo Armas
**Gmail:** alu0101642468@ull.edu.es

Aquí están los ejercicios realizados usando scripts de C#, donde se utilizan las funciones del motor de física, así como diferentes configuraciones de colisiones, áreas tipo *trigger* y cálculos matemáticos. El objetivo principal es mostrar cómo interactúan los objetos en los distintos ejercicios.

---


### Ejercicio 1: Movimiento con Rigidbody



Se crea un script que permite mover un objeto con `Rigidbody` usando las teclas de dirección o las teclas WASD. Se utiliza `Input.GetAxis("Horizontal")` y `Input.GetAxis("Vertical")` para obtener el movimiento del jugador, y se usa`Rigidbody.MovePosition()`para mover el objeto usando las funciones del motor de física.

Un error común es mover el objeto usando `Transform.Translate()`, ya que una vez el objeto tiene un `Rigidbody`, el motor de física se encarga de moverlo y calcular las colisiones, por lo que si movemos el objeto con `Transform.Translate()`, se pueden producir lo conocido como aberraciones.



### Ejercicio 2: Colisiones y cambio de color


Aquí se prueban las colisiones creando varios objetos con `Rigidbody` dinámico (Rigidbody Collider). Usando la función `OnCollisionEnter()`, el script es capaz de detectar los choques, imprimir por consola el nombre del objeto que se ha golpeado y cambiarle el color del material.

Se puede hacer uso de este tipo de funciones, ya que los objetos que colisionen son todos `Rigidbody` dinámicos, por lo que el motor de física calcula las colisiones y nos permite usar los eventos de colisión.

### Ejercicio 3: Triggers 

En este ejercicio, dejan de ser choques entre objetos físicos y se convierten en colisiones entre un objeto dinámico y las zonas "fantasma". Estas zonas tienen la casilla `Is Trigger` activada, por lo que 
se usan eventos Trigger.

Concretamente, se usó del evento `OnTriggerStay()` para que, mientras el personaje esté en una de estas zonas, cambie de color o reciba daño. Asimismo, los eventos `OnTriggerEnter()` y `OnTriggerExit()` se usan para detectar cuándo el personaje entra y sale de la zona, y restaurar el color o el daño original del personaje.

### Ejercicio 4: La Matriz de Colisiones (Layer Collision Matrix)

En este ejercicio, se configura la *Layer Collision Matrix* para controlar cómo interactúan los objetos entre sí. Para ello, se separan los objetos en tres capas (jugador, enemigos y recolectables) y se configura dicha matriz. 

De esta forma, los personajes pueden interactuar con los enemigos y los recolectables, pero los enemigos no pueden interactuar con los recolectables ni viceversa. Es por eso que, cuando el personaje llega a un recolectable, este muestra un mensaje por consola, pero si lo hace un enemigo, no pasa nada.

### Ejercicio 5: Materiales Físicos y AddForce

Se crean diferentes materiales físicos y se aplican a diferentes objetos para simular diferentes superficies. Al detectar que se pulsa la tecla X con `Input.GetKeyDown(KeyCode.X)`, se les da un golpe a los objetos usando la función `Rigidbody.AddForce()`, con el modo de fuerza `ForceMode.Impulse` para que el golpe sea instantáneo. De esta forma, se puede ver cómo los objetos reaccionan de manera diferente según el material que tengan asignado.

### Ejercicio 6: Movimiento sin físicas

Este ejercicio no se puede hacer siguiendo el enunciado, ya que al no poder usar el rigidbody, no se pueden usar las funciones del motor de físicas para detectar la colicion entre el cilindro y el cubo. El cilindro se mueve con `Transform.Translate()` hacia donde va la esfera, y al llegar a la altura del cubo, lo atraviesa, siguiendo su camino.

Por ello, para conseguir un resultado similar al que se pide, al llegar a la altura del cubo, se cambia el material de este y se atraviesa, dejando que el cilindro siga hacia la esfera.
