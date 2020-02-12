using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float movimentoX;
    [SerializeField] float velocidade;  
    Rigidbody _rigidbody;
  public string numeroDoJogador;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movimentoX = Input.GetAxis("Horizontal"+numeroDoJogador);
        _rigidbody.velocity = new Vector3(movimentoX * velocidade, 0, 0);
      //  _rigidbody.position = new Vector3(_rigidbody.position.x, 2, 0);
    }
}
