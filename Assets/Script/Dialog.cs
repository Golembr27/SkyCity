using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    // Vari�vel para controlar se o jogador est� dentro do alcance da placa
    public int jogadorPerto = 0;

    // Tecla para interagir
    public KeyCode teclaDeInteracao;
    // sprite do npc
    public Sprite profile;
    // texto
    public Text speechTxt;
    // nome que aparece com o dialogo
    public Text actorName;
    //outro script
    private Dialogo dc;

    private void Start()
    {
        //chamando outro script pelo nome
        dc = FindObjectOfType<Dialogo>();
        //se clicar E vai abrir o dialogo
        teclaDeInteracao = KeyCode.E;
    }


    void Update()
    {
        // Verificar se o jogador est� perto e pressionou a tecla de intera��o
        if (jogadorPerto == 0 && Input.GetKeyDown(teclaDeInteracao))
        {
            // Exibir o di�logo
            //dc.Speech(profile, speechTxt, actorName);
        }
    }

    // Este m�todo � chamado quando o jogador entra no collider da placa
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //JogadorPerto True
        jogadorPerto = 1;
    }

    // Este m�todo � chamado quando o jogador sai do collider da placa
    private void OnTriggerExit2D(Collider2D collision)
    {
        //JogadorPerto False
        jogadorPerto = 0;
    }
}
