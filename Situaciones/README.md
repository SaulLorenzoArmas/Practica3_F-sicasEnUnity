# Práctica de Unity: Situaciones Físicas

**Autor:** Saúl Lorenzo Armas
**Gmail:** alu0101642468@ull.edu.es

Partiendo de un mismo escenario, se va cambiando la configuración de cada objeto (poniendo y quitando físicas, haciéndolos cinemáticos o Triggers) para comprobar cómo cambia la reacción del motor de Unity ante cada situación.

---

### Situación 1

<img width="2878" height="1558" alt="Ejercicio1 1_Supuestos" src="https://github.com/user-attachments/assets/409a58e2-ac68-4750-ac4d-d0a4bf28db81" />
---
<img width="2876" height="1556" alt="Ejercicio1 2_supuestos" src="https://github.com/user-attachments/assets/ec402bb0-75b0-4605-9b80-76d2e8c98834" />
---
<img width="2878" height="1564" alt="Ejercicio1 3_supuestos" src="https://github.com/user-attachments/assets/a821762e-5216-4d16-a607-5edd084d6cca" />
---


Como el cubo tiene físicas, la gravedad tira de él hasta que choca sobre el plano, que hace la función de suelo. La esfera, en cambio, no tiene físicas y es solo un Collider estático, por lo que se queda flotando en el aire. De forma que, aunque el cubo le caiga encima, la esfera no se moverá.

### Situación 2

<img width="2878" height="1560" alt="Ejercicio2 1_Supuestos" src="https://github.com/user-attachments/assets/90f752cb-ba9a-4d08-8eca-c8af61b79817" />
---
<img width="2878" height="1554" alt="Ejercicio2 2_Supuestos" src="https://github.com/user-attachments/assets/ddb84abd-f595-4eb2-bc82-07855e775a34" />
---
<img width="2872" height="1556" alt="Ejercicio2 3_Supuestos" src="https://github.com/user-attachments/assets/1eb0af11-15a0-4de0-a6ae-675b6b877bd5" />
---

Tanto el cubo como la esfera son objetos físicos. Ahora la esfera se ve afectada por la gravedad, es golpeada por el cubo y ambos reaccionan al impacto.

### Situación 3

<img width="2878" height="1560" alt="Ejercicio3 1_Supuestos" src="https://github.com/user-attachments/assets/87555522-77a3-4095-9792-a5f52fdc3fd6" />
---
<img width="2876" height="1560" alt="Ejercicio3 2_Supuestos" src="https://github.com/user-attachments/assets/47383849-64f5-46ed-8988-4140fa1ab799" />
---
<img width="2878" height="1560" alt="Ejercicio3 3_Supuestos" src="https://github.com/user-attachments/assets/8adcf179-e218-4bc6-b7c6-5a0f0db04aab" />
---

La esfera se marca como física cinemática. Al hacer esto, el motor de físicas deja de moverla, por lo que se queda clavada flotando en el aire, mientras que el cubo cae con normalidad.

### Situación 4

<img width="2876" height="1562" alt="Ejercicio4 1_Supuestos" src="https://github.com/user-attachments/assets/63712171-755c-4381-9616-51b1d9a37613" />
---
<img width="2872" height="1562" alt="Ejercicio4 2_Supuestos" src="https://github.com/user-attachments/assets/ac027de1-eeba-454c-bb37-311bbac1f936" />
---


El plano también es un objeto físico. Al tener los tres objetos `Rigidbody` normal, a todos les afecta la gravedad por igual. Al no haber nada que los aguante, los tres caen al vacío.

### Situación 5

<img width="2876" height="1560" alt="Ejercicio5 1_Supuestos" src="https://github.com/user-attachments/assets/c4952f97-35ec-4edd-adde-6e1bd1b8c890" />
---
<img width="2874" height="1556" alt="Ejercicio5 2_Supuestos" src="https://github.com/user-attachments/assets/db15fefb-75d6-4003-a3c3-beab5e59a2bc" />
---
<img width="2878" height="1560" alt="Ejercicio5 3_Supuestos" src="https://github.com/user-attachments/assets/00285b54-12dd-4fb1-b6b1-e784101e52a7" />
---



El plano es cinemático, se forma que el motor de físicas no se encarga de moverlo. La esfera vuelve a caer sobre el cubo, pero con 10 veces más masa que al cubo. 

A pesar de ser más pesada, ambos caen a la misma velocidad y llegan al suelo a la vez. Esto se debe a que en Unity, la masa no afecta a la velocidad de caída; sino que afecta cuando hay un impacto, haciendo que la esfera empuje y desplace al cubo mas rápido.

### Situación 6
<img width="2878" height="1556" alt="Ejercicio6 1_Supuestos" src="https://github.com/user-attachments/assets/fdb550ad-64a3-49b3-8475-5b5f3cc51567" />
---
<img width="2868" height="1556" alt="Ejercicio6 2_Supuestos" src="https://github.com/user-attachments/assets/ebbe8802-f840-4743-b469-365544001605" />
---
<img width="2878" height="1560" alt="Ejercicio6 3_Supuestos" src="https://github.com/user-attachments/assets/8236b6ea-c930-4954-981b-e9d58e09e407" />
---
<img width="2878" height="1488" alt="Ejercicio7 2_supuestos" src="https://github.com/user-attachments/assets/eaa6caa7-4c92-47ac-84d8-88585d37d8b8" />
<img width="2876" height="1492" alt="Ejercicio7 1_supuestos" src="https://github.com/user-attachments/assets/862c204d-95fe-48eb-8c07-5ee5cd91073e" />
<img width="2876" height="1492" alt="Ejercicio7 1_supuestos" src="https://github.com/user-attachments/assets/301dca2c-73b8-4121-be62-5a11c15144a8" />
<img width="2878" height="1488" alt="Ejercicio7 2_supuestos" src="https://github.com/user-attachments/assets/7a4057ff-8214-4706-9e6a-37834e7b46df" />


Igual que en el caso anterior, pero ahora la esfera física tiene 100 veces más masa que el cubo. Por ellos, si chocan, la esfera empuja al cubo con mucha más fuerza y lo desplaza mucho más rápido.

### Situación 7


<img width="2876" height="1492" alt="Ejercicio7 1_supuestos" src="https://github.com/user-attachments/assets/9c666448-85c0-4eaf-9039-81a36df78ade" />
---
<img width="2878" height="1488" alt="Ejercicio7 2_supuestos" src="https://github.com/user-attachments/assets/07daf9e4-0b2f-4ce2-9a5e-de03b7c58d6f" />
---

Suponiendo que el plano vuelve a ser cinemático, ya que si se dejara como un objeto físico sin marcar como cinemático, pasaría lo mismo que en la Situación 4 y todo caería al vacío.

Aplicando material físico a la esfera, se le puede aumentar la fricción. Sin embargo, no se aprecia gran cambio, ya que la esfera para moverse lo que hace es rodar, y la fricción actúa sobre el deslizamiento. Por ello, se incremento el campo `Angular Damping` del Rigidbody de la esfera, que es el que controla la fricción al rodar. Al aumentar este valor, la esfera se frena más rápido y no rueda tanto.

### Situación 8

<img width="2870" height="1488" alt="Ejercicio8_Supuestos" src="https://github.com/user-attachments/assets/40805699-4d29-4c9a-b669-5d958bb52a83" />


El plano sigue siendo cinemático. La esfera no es física, pero se configura como `Trigger`. El resultado es que se queda flotando en el aire, sin poder moverse ni chocar contra nada, solo serviría para avisar, mediante mensajes de tipo trigger si algo la atraviesa.

### Situación 9

<img width="2878" height="1500" alt="Ejercicio9_Supuestos" src="https://github.com/user-attachments/assets/57b7f83f-b235-4784-9964-90249834f399" />


Igual que en el caso anterior pero la esfera es un objeto físico y `Trigger`. Esta combinación hace que la esfera a la esfera le afecte la gravedad pero no pueda chocar. Por lo que, atraviesa el cubo y el plano, y cae al vacío. Sin embargo, al ser un `Trigger`, puede avisar mediante mensajes de tipo trigger si algo la atraviesa.
