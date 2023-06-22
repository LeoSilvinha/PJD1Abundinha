using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float veloc = 0.0f ;
    public float entradaHorizontal ;
    public float entradaVertical ;
    public GameObject pftiro1;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start de "+this.name);
        veloc = 12f ;
        transform.position = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Space)){
            Instantiate(pftiro1,transform.position + new Vector3(0,1.04f,0),Quaternion.identity);
        }

       
       
       entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*veloc*entradaHorizontal);

        if ( transform.position.x  > 8.65f) {
            transform.position = new Vector3(-8.65f,transform.position.y,0);
        }

        if ( transform.position.x  < -8.65f  ) {
            transform.position = new Vector3(8.65f,transform.position.y,0);
        
        }

        entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up*Time.deltaTime*veloc*entradaVertical);

        if ( transform.position.y  > 2.96f ) {
            transform.position = new Vector3(transform.position.x,2.96f,0);
        }

        if ( transform.position.y  < -4.39f  ) {
            transform.position = new Vector3(transform.position.x,-4.39f,0);
        }

       
       


    }
}





