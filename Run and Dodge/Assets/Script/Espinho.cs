using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espinho : MonoBehaviour
{
    private Rigidbody2D espinhoRb;
    private int atrito;
    public int atritoMax;
    public Vector3 posicao;
    public GameObject espinhoPrefab;

    // Start is called before the first frame update
    void Start()
    {
        espinhoRb = GetComponent<Rigidbody2D>();

        atrito = Random.Range(1, atritoMax);

        espinhoRb.drag = atrito;

        posicao = transform.position;
    }

    private void OnBecameInvisible()
    {
        Instantiate(espinhoPrefab, posicao, transform.localRotation);
        Pontuacao.pontos += 1;
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == "espinho")
        {
            print("Espinho principal");
        }
    }
}
