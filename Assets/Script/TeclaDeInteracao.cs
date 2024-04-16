using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class TeclaDeInteracao : MonoBehaviour
{
    // Referência para o objeto de diálogo
    public GameObject dialogo;

    // Tecla para interagir
    public KeyCode teclaDeInteracao = KeyCode.E;

    // Variável para controlar se o jogador está dentro do alcance da placa
    private bool jogadorPerto = false;

    void Update()
    {
        // Verificar se o jogador está perto e pressionou a tecla de interação
        if (jogadorPerto && Input.GetKeyDown(teclaDeInteracao))
        {
            // Exibir o diálogo
            dialogo.SetActive(true);
        }
    }

    // Este método é chamado quando o jogador entra no collider da placa
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar se o jogador entrou no collider da placa
        if (other.CompareTag("Player"))
        {
            jogadorPerto = true;
        }
    }

    // Este método é chamado quando o jogador sai do collider da placa
    private void OnTriggerExit2D(Collider2D other)
    {
        // Verificar se o jogador saiu do collider da placa
        if (other.CompareTag("Player"))
        {
            jogadorPerto = false;
        }
    }
}
