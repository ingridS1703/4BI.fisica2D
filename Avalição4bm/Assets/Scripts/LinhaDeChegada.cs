using System;
using UnityEngine;

public class LinhaDeChegada : MonoBehaviour
{
    public GameObject mensagem;
    public GameObject button;
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            mensagem.SetActive(true);
        }
    }
}
