# Práctica de Unity: Situaciones Físicas

**Autor:** Saúl Lorenzo Armas
**Gmail:** alu0101642468@ull.edu.es

Partiendo de un mismo escenario, se va cambiando la configuración de cada objeto (poniendo y quitando físicas, haciéndolos cinemáticos o Triggers) para comprobar cómo cambia la reacción del motor de Unity ante cada situación.

---

### Situación 1

<img width="2878" height="1558" alt="Ejercicio1 1_Supuestos" src="https://github.com/user-attachments/assets/409a58e2-ac68-4750-ac4d-d0a4bf28db81" />
<img width="2876" height="1556" alt="Ejercicio1 2_supuestos" src="https://github.com/user-attachments/assets/ec402bb0-75b0-4605-9b80-76d2e8c98834" />
<img width="2878" height="1564" alt="Ejercicio1 3_supuestos" src="https://github.com/user-attachments/assets/a821762e-5216-4d16-a607-5edd084d6cca" />



Como el cubo tiene físicas, la gravedad tira de él hasta que choca sobre el plano, que hace la función de suelo. La esfera, en cambio, no tiene físicas y es solo un Collider estático, por lo que se queda flotando en el aire. De forma que, aunque el cubo le caiga encima, la esfera no se moverá.

### Situación 2


Tanto el cubo como la esfera son objetos físicos. Ahora la esfera se ve afectada por la gravedad, es golpeada por el cubo y ambos reaccionan al impacto.

### Situación 3


La esfera se marca como física cinemática. Al hacer esto, el motor de físicas deja de moverla, por lo que se queda clavada flotando en el aire, mientras que el cubo cae con normalidad.

### Situación 4


El plano también es un objeto físico. Al tener los tres objetos `Rigidbody` normal, a todos les afecta la gravedad por igual. Al no haber nada que los aguante, los tres caen al vacío.

### Situación 5


El plano es cinemático, se forma que el motor de físicas no se encarga de moverlo. La esfera vuelve a caer sobre el cubo, pero con 10 veces más masa que al cubo. 

A pesar de ser más pesada, ambos caen a la misma velocidad y llegan al suelo a la vez. Esto se debe a que en Unity, la masa no afecta a la velocidad de caída; sino que afecta cuando hay un impacto, haciendo que la esfera empuje y desplace al cubo mas rápido.

### Situación 6


Igual que en el caso anterior, pero ahora la esfera física tiene 100 veces más masa que el cubo. Por ellos, si chocan, la esfera empuja al cubo con mucha más fuerza y lo desplaza mucho más rápido.

### Situación 7


Suponiendo que el plano vuelve a ser cinemático, ya que si se dejara como un objeto físico sin marcar como cinemático, pasaría lo mismo que en la Situación 4 y todo caería al vacío.

Aplicando material físico a la esfera, se le puede aumentar la fricción. Sin embargo, no se aprecia gran cambio, ya que la esfera para moverse lo que hace es rodar, y la fricción actúa sobre el deslizamiento. Por ello, se incremento el campo `Angular Damping` del Rigidbody de la esfera, que es el que controla la fricción al rodar. Al aumentar este valor, la esfera se frena más rápido y no rueda tanto.

### Situación 8


El plano sigue siendo cinemático. La esfera no es física, pero se configura como `Trigger`. El resultado es que se queda flotando en el aire, sin poder moverse ni chocar contra nada, solo serviría para avisar, mediante mensajes de tipo trigger si algo la atraviesa.

### Situación 9


Igual que en el caso anterior pero la esfera es un objeto físico y `Trigger`. Esta combinación hace que la esfera a la esfera le afecte la gravedad pero no pueda chocar. Por lo que, atraviesa el cubo y el plano, y cae al vacío. Sin embargo, al ser un `Trigger`, puede avisar mediante mensajes de tipo trigger si algo la atraviesa.
