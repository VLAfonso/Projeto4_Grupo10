using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro : MonoBehaviour
{
    private float move;
    public float moveSpeed;
    private float rotation;
    public float rotationSpeed;
    public AudioSource buzina; 

    // Start is called before the first frame update
    void Start()
    {
        buzina = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Buzina();
    }

    void Move()
    {
        move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        rotation = Input.GetAxis("Horizontal") * - rotationSpeed * Time.deltaTime;       
    }

    private void LateUpdate() {
        transform.Translate(0f, move, 0f);
        transform.Rotate(0f, 0f, rotation);
    }

    void Buzina()
    {
        if(Input.GetKeyDown(KeyCode.B)){
            buzina.Play();
        }
    }
}
