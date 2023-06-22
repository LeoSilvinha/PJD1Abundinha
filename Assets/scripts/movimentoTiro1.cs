using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoTiro1 : MonoBehaviour
{
    public float veloctiro1 = 12.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector3.up * veloctiro1 * Time.deltaTime);
        if ( transform.position.y > 4.5f ){
            Destroy(this.gameObject);
        }
    }
}
