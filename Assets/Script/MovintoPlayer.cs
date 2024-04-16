using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class MovintoPlayer : MonoBehaviour
{
    // velocidade que o personage que vai andar
    float velocidadeAndar = 5f;

    private void Start()
    {

    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movimentacao = new Vector2 (horizontal, vertical);
        transform.position = movimentacao * velocidadeAndar * Time.deltaTime;
    }
}
