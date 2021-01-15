using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ItensGeneration : MonoBehaviour 
{
    private LevelGenerator _LevelGenerator;    

    private GamePoints _GamePoints;
    


     void OnTriggerEnter2D( Collider2D other) {
        if (other.gameObject.tag == "Player") 
        {
            _LevelGenerator = gameObject.AddComponent<LevelGenerator>();
             _LevelGenerator.itemSpawn = (GameObject)Resources.Load("itemA");
             _LevelGenerator.spawnItem();
            // _LevelGenerator.spawnItem();
            // _GamePoints.CandyPoints();
            Destroy(gameObject);


        }
    }


}
