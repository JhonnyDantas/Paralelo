using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    [SerializeField]
    private float _velocidade;

    [SerializeField]
    private GameObject _ExplosaoDoInimigo;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * _velocidade * Time.deltaTime);

        if (transform.position.y < -6.0f)
        {
            transform.position = new Vector3(Random.Range(-2.3f, 2.3f), 6.0f, 0);

        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(" O objeto " + name + " colidiu com o objeto " + other.name);

        if (other.tag == "Tiro")

        {
            Destroy(other.gameObject);
        }

        if (other.tag == "Nave")

        {
            Player player = other.GetComponent<Player>();

            if (player != null)

            {
                player.DanoAoPlayer();
            }


        }

        Instantiate(_ExplosaoDoInimigo, transform.position, Quaternion.identity);
        Destroy(this.gameObject);



    }

}

