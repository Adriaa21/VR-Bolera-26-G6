# VR Bowling

Un juego de bolera para realidad virtual, desarrollado con Unity y el plugin Auto Hand.

- **Interacción Realista con Auto Hand**: Agarra, lanza y suelta la bola con física precisa gracias al plugin *Auto Hand*.
- **Sistema de Retorno de Bola**: Después de cada lanzamiento, una vez la bola alcance el final de la pista, una nueva bola aparece automáticamente en la mesa.
- **Reinicio de Objetos**: Presiona un botón físico para reiniciar la posición de los bolos, las bolas y otros objetos.
- **Bolas con Mecánicas Únicas**:
  - **Bola Normal**: Peso y fricción estándar, comportamiento equilibrado.
  - **Bola Con Rebote**: Alto nivel de rebote gracias a su Physic Material.
  - **Bola Sin Gravedad**: No se ve afectada por la gravedad (Use Gravity = false).
- **Pista de Bolos Física**: Superficie con fricción para un deslizamiento realista.

## Controles (VR)

| Acción | Input |
|--------|-------|
| Agarrar la bola | Gatillo |
| Soltar la bola | Soltar el gatillo |
| Lanzar | Mover la mano con intención y soltar |
| Reiniciar objetos | Presionar botón físico o entrar en zona de reinicio |

## 🛠️ Tecnologías Usadas

- **Unity** (versión 6.0)
- **Auto Hand** (Plugin para interacción VR)
- **Física de Unity** (Rigidbody, Physic Materials, Colliders)
- **Sistema de Eventos** (Triggers, UnityEvents)
