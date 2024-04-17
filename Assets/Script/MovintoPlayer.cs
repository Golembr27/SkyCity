using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class MovintoPlayer : MonoBehaviour
{
    public FixedJoystick moveJoystick;
    // velocidade que o personage que vai andar
    float velocidadeAndar = 5f;
    float horizontal;
    float vertical;

    private void Start()
    {

    }

    void Update()
    {
        
    }

    void Movimentação()
    {
        horizontal = moveJoystick.Horizontal;
        vertical = moveJoystick.Vertical;

        Vector3 movimentacao = new Vector3(horizontal,0, vertical);
        transform.Translate(movimentacao * velocidadeAndar * Time.deltaTime);
    }
}
