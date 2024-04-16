using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class TeclaDeInteracao : MonoBehaviour
{
    // Variável para controlar se o jogador está dentro do alcance da placa
    private bool jogadorPerto = false;

    // Referência para o objeto de diálogo
    public GameObject dialogo;

    // Tecla para interagir
    public KeyCode teclaDeInteracao;

    private void Start()
    {
        teclaDeInteracao = KeyCode.E;
    }

    void Update()
    {
        // Verificar se o jogador está perto e pressionou a tecla de interação
        if (jogadorPerto == true && Input.GetKeyDown(teclaDeInteracao))
        {
            // Exibir o diálogo
            dialogo.SetActive(true);
        }
    }

    // Este método é chamado quando o jogador entra no collider da placa
    private void OnTriggerEnter2D(Collider2D collision)
    {
        jogadorPerto = true;
        Debug.Log("Colidiu");
    }

    // Este método é chamado quando o jogador sai do collider da placa
    private void OnTriggerExit2D(Collider2D collision)
    {
        jogadorPerto = false;
        Debug.Log("Saio Da Colisão");
    }
}
