using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Dash : MonoBehaviour
{
    // ativacao
    bool usarODash = true;

    //transform do personagem
    int ativacaoDoDash = 0; // 0 sem ativacao 1 com ativasao

    //valocidade que o personagem vai alcansar com o Dash
    public float velocidadeDash;

    // tempo de cowdown de cada dash (tempo minimo de espera pra executar um dash)
    public float dashCowdown = 2;

    
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.LeftShift) && Input.GetKey(KeyCode.W) && usarODash == true)
        {
            transform.Translate(Vector2.down * velocidadeDash);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) && Input.GetKey(KeyCode.S) && usarODash == true)
        {
            transform.Translate(Vector2.down * velocidadeDash);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift) && Input.GetKey(KeyCode.A) && usarODash == true)
        {
            transform.Translate(Vector2.left * velocidadeDash);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift) && Input.GetKey(KeyCode.D) && usarODash == true)
        {
            transform.Translate(Vector2.right * velocidadeDash);
        }

    }
}
