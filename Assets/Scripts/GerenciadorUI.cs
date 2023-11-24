using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerenciadorUI : MonoBehaviour
{
    public void Start()
    {
        transform.position = new Vector2(-730f, 356f);
    }
    public Sprite[] vidas;

    public Image mostrarImagemDasVidas;
    public void AtualizaVidas(int vidasAtuais)
    {
        mostrarImagemDasVidas.sprite = vidas[vidasAtuais];

    }

    public void AtualizaPlacar()
    {




    }

}