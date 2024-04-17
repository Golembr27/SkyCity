using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class MovintoPlayer : MonoBehaviour
{
    public FixedJoystick moveJoystick;
    // velocidade que o personage que vai andar
    float velocidadeAndar = 5f;


    private void Start()
    {

    }

    void Update()
    {
        Movimentação();
    }

    void Movimentação()
    {
        float horizontal = moveJoystick.Horizontal;
        float vertical = moveJoystick.Vertical;

        Vector2 movimentacao = new Vector2(horizontal, vertical);
        transform.Translate(movimentacao * velocidadeAndar * Time.deltaTime);
    }


}
