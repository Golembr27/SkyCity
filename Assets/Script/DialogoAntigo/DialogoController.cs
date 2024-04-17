using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogoController : MonoBehaviour
{
    // tempo por letra
    [SerializeField] float timePerLetter;
    [SerializeField] TextMeshProUGUI textDialog;

    //paginas
    string[] pages;
    //pagian atual
    int currentPages;
    //finalizacao da pagina
    bool finalizePage;
    IEnumerator routineDitar;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            NextPage();
        }
    }

    void NextPage()
    {
        if (finalizePage)
        {
            currentPages++;
            if (currentPages >= pages.Length)
            {
                EndDialog();
                return;
            }
            routineDitar = Ditar();
            StartCoroutine(routineDitar);
        }
        else
        {
            finalizePage = true;
            textDialog.text = pages[currentPages];
            StopCoroutine(routineDitar);
        }
    }

    void EndDialog()
    {
        gameObject.active = false;
        StopCoroutine(routineDitar);
    }

    public void OpenDialog(string[] pages)
    {
        if (gameObject.activeInHierarchy)
        {
            return;
        }
        gameObject.SetActive(true);
        this.pages = pages;
        currentPages = 0;
        finalizePage = false;
        routineDitar = Ditar();
        StartCoroutine(routineDitar);
    }

    IEnumerator Ditar() 
    {
        var page = pages[currentPages];
        textDialog.text = "";
        finalizePage = false;

        foreach (var letter in page)
        {
            textDialog.text += letter;
            yield return new WaitForSeconds(timePerLetter);
        }

        finalizePage = true;
    }

}
