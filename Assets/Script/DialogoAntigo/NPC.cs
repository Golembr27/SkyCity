using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] DialogoController dia;
    [TextArea(5, 8)]
    [SerializeField] string[] pages;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Awake()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            dia?.OpenDialog(pages);
        }
    }

}
