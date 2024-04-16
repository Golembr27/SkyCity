using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class TeclaDeInteracao : MonoBehaviour
{
    // Refer�ncia para o objeto de di�logo
    public GameObject dialogo;

    // Tecla para interagir
    public KeyCode teclaDeInteracao = KeyCode.E;

    // Vari�vel para controlar se o jogador est� dentro do alcance da placa
    private bool jogadorPerto = false;

    void Update()
    {
        // Verificar se o jogador est� perto e pressionou a tecla de intera��o
        if (jogadorPerto && Input.GetKeyDown(teclaDeInteracao))
        {
            // Exibir o di�logo
            dialogo.SetActive(true);
        }
    }

    // Este m�todo � chamado quando o jogador entra no collider da placa
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar se o jogador entrou no collider da placa
        if (other.CompareTag("Player"))
        {
            jogadorPerto = true;
        }
    }

    // Este m�todo � chamado quando o jogador sai do collider da placa
    private void OnTriggerExit2D(Collider2D other)
    {
        // Verificar se o jogador saiu do collider da placa
        if (other.CompareTag("Player"))
        {
            jogadorPerto = false;
        }
    }
}
