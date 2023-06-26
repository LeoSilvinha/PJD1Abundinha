using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
   public float veloc = 0.0f ;
   public float entradaHorizontal ;
   public float entradaVertical ;
   public GameObject pftiro;
   public float tempoDeDisparo = 1f;
   public float podeDisparar = 0.0f;
    

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
     if ( Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
          Disparo();
        
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

      if ( transform.position.y  < -3.04f  ) {
        transform.position = new Vector3(transform.position.x,-3.04f,0);
      }

          void Disparo(){
        if ( Time.time > podeDisparar ){
             Instantiate(pftiro,transform.position + new Vector3 (0,1.1f,0),Quaternion.identity);
            podeDisparar = Time.time + tempoDeDisparo ;
             }
    }

  }






}







