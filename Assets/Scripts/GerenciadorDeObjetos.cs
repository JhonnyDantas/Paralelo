 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDeObjetos : MonoBehaviour
{

    [SerializeField]
    private GameObject _inimigoPrefab;

    [SerializeField]
    private GameObject[] _powerUps;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RotinaGeracaoInimigo());
        StartCoroutine(RotinaGeracaoPowerUps());
    }

    IEnumerator RotinaGeracaoInimigo()
    {
        while (1 == 1)
        {
            Instantiate(_inimigoPrefab, new Vector3(Random.Range(-3.32f, 3.3f), 6.0f, 0), Quaternion.identity);
            yield return new WaitForSeconds(2);
        }

    }

    IEnumerator RotinaGeracaoPowerUps() 
    {
        while (1 == 1)
        {
            int powerUpsAletatorio = Random.Range(0, 3);
            Instantiate(_powerUps[powerUpsAletatorio], new Vector3(Random.Range(-3.40f, 3.5f), 6.0f, 0), Quaternion.identity);
            yield return new WaitForSeconds(6);
        }
    
    }

}
