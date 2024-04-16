using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class MovintoPlayer : MonoBehaviour
{
    // velocidade que o personage que vai andar
    float velocidadeAndar = 5f;

    void Update()
    {
        // if que pega a tecla precionada que é o W para mover o personagem para cima (Up)
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate( Vector2.up * velocidadeAndar * Time.deltaTime);
        }
        // if que pega a tecla precionada que é o S para mover o personagem para baixo (Down)
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * velocidadeAndar * Time.deltaTime);
        }
        // if que pega a tecla precionada que é o A para mover o personagem para esquerda (left)
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * velocidadeAndar * Time.deltaTime);
        }
        // if que pega a tecla precionada que é o D para mover o personagem para direita (Right)
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * velocidadeAndar * Time.deltaTime);
        }
    }
}
