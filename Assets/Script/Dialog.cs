using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    // Variável para controlar se o jogador está dentro do alcance da placa
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
        // Verificar se o jogador está perto e pressionou a tecla de interação
        if (jogadorPerto == 0 && Input.GetKeyDown(teclaDeInteracao))
        {
            // Exibir o diálogo
            //dc.Speech(profile, speechTxt, actorName);
        }
    }

    // Este método é chamado quando o jogador entra no collider da placa
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //JogadorPerto True
        jogadorPerto = 1;
    }

    // Este método é chamado quando o jogador sai do collider da placa
    private void OnTriggerExit2D(Collider2D collision)
    {
        //JogadorPerto False
        jogadorPerto = 0;
    }
}
