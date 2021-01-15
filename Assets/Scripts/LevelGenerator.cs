using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public  class LevelGenerator : MonoBehaviour
{
    public Text CentralText;

    public GameObject player;
    public GameObject platformPrefab;
    private Vector3 spawnPosition = new Vector3();
    public float spawnPositionY = 0f;
    
    public static LevelGenerator instancia; 


    public GameObject itemSpawn;



    private void Awake()
        {
            // evitando instancias duplicadas do jogo
            if (instancia == null) instancia = this;
            else if (instancia != this) Destroy(gameObject);

            // persistencia do jogo
            DontDestroyOnLoad(gameObject);
        }


    void Start()
    {
        spawnPositionY = VariableControler.platformPositionStart;
        spawnPosition = new Vector3(spawnPosition.x, spawnPositionY, 0f);
        for (int i = 0; i < VariableControler.nInitialPlatforms; i++) {
            spawnPlatform();

        }
        spawnItem();



    }


    public  void spawnPlatform() {
        spawnPositionY += Random.Range(VariableControler.minYSpawn, VariableControler.maxYSpawn);
        spawnPosition.y = spawnPositionY;
        spawnPosition.x = Random.Range(-VariableControler.XRangeSpawn, VariableControler.XRangeSpawn);
        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
    }

    public void spawnItem() {
        // spawnPositionY += Random.Range(VariableControler.minYSpawn, VariableControler.maxYSpawn);
        spawnPosition.y = spawnPositionY + 1f ;
        // spawnPosition.x = Random.Range(-VariableControler.XRangeSpawn, VariableControler.XRangeSpawn);
        Instantiate(itemSpawn, spawnPosition, Quaternion.identity);
        spawnPosition.y = -(spawnPositionY + 1f) ;
    }

    void OnTriggerEnter2D( Collider2D other) {
        if (other.gameObject.tag == "Platform") {
            Destroy(other.gameObject);
            spawnPlatform();

        }
        if (other.gameObject.tag == "Item") {
            Destroy(other.gameObject);
            spawnItem();
        }
        if (other.gameObject.tag == "Player") {
            GamePoints.ResetGame();
            SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);

        }
    }

    // bool Perceber(GameObject objeto) {
    //     float proximidade = 0f;
    //     proximidade = Vector3.Distance(player.transform.position, objeto.transform.position);
    //     Debug.Log(proximidade);
    //     if( proximidade <= VariableControler.alcanceVisao) {
    //         return true;
    //     } else {
    //         return false;
    //     }  
    // }

}
