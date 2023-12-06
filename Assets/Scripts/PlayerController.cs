using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*
    - Acessar o Rigidbody 2D
    - Acessar as setinhas do teclado (<, >, /\, \/)
    - Movimentar o Rigidbody de acordo com as setinhas pressionadas
    */

    // Variável: Tipo e Nome
    Rigidbody2D rb;

    // Public -> Unity visualiza e exibe essa variável
    // Float -> Tipo de dado numérico com casas decimais
    // Speed -> Nome da variável
    // 3f -> Valor inicial da variável
    //   Depois que a Unity compilar o script pela primeira vez,
    //    o valor que estiver Unity será usado
    public float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        // Pegamos o componente Rigidbody2D que está no mesmo objeto
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Seta para esquerda, valor do H = -1
        // Seta para direita, valor do H = 1
        var h = Input.GetAxis("Horizontal") * speed;

        // Seta para cima, valor do V = 1
        // Seta para baixo, valor do V = -1
        var v = Input.GetAxis("Vertical") * speed;

        // Movimentamos o Rigidbody alterando sua velocidade
        // A velocidade do Rigidbody possui dois eixos: X (esq/dir) e Y (cima/baixo)
        // Representamos a velocidade X e Y em um Vector2(x, y)
        rb.velocity = new Vector2(h, v);
    }
}
