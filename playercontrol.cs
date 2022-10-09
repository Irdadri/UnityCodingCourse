using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 20;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //prende l'input e lo assegna alla variabile.
        //lo testo nell'inspector

        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        //keep the player in bounds
        if(transform.position.x < -xRange ){ //se è più piccolo del bordo
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            //sostituisce il vettore vecchio con uno nuovo ma con x fissato
            //tiene il player sul bordo inbound 
        }
        if(transform.position.x > xRange){ //se è più grande del bordo
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //ho guardato la soluzione ma perchè non si capiva!!!!!


        if(Input.GetKeyDown(KeyCode.Space)){
            //launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            //istantiate è una funzione che istanzia una copia dell'oggetto
            //e ne descrive una nuova posizione e orientamento
            //in questo caso, cambia la posizione con quella del player
            //e lascia l'orientamento com'è?
        }

    }
}
