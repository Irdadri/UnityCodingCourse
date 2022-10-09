using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs; //array di oggetti di tipo gameobject
    //vanno trascinati i prefab non gli og!!!!
    //c'era la variabile indice: da mettere manualmente in caso vuoi modificarlo da unity
    //fai il codice una volta soltanto
    //spawna però solo l'animale che hai scelto...
    private float spawnRangeX = 10;
    private float spawnPosZ = 20;
    // Start is called before the first frame update
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    void Start()
    {
        //posso ancor migliorare!
        //spawno a cicli anziche premendo S

        InvokeRepeating("Spawn", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.S)){
            //Spawn();
        //}

        //edit 1: li spawna tutti nella stessa posizione!
        //correggo generando un vettore3 con x randomizzata

        //edit 2: pulisco il codice creando una funzione e chiamandola!!! come in C

        //edit 3: metto lo spawn a tempo!!


    }

    void Spawn(){
        int animalIndex = Random.Range(0, animalPrefabs.Length); //sceglie un animale dell'array random! 
        //esclude il termine di destra immagino?
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        //genera un vettore3 di coordinate X casuali nel range x, 0 fisso per il gioco su y
        //e z per farli partire dalla cima della scena fisso
        //solo x è random!!!!!!!
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        //inserisco in position il vettore creato
    }
}
