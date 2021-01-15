using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableControler : MonoBehaviour
{
    //player
    public static bool gameStarted = false;
    public static float initialImpulse = 8f;

    //platform and item's spawn
    public static int nInitialPlatforms = 5;
    public static float XRangeSpawn = 2f;
    public static float minYSpawn = 2.3f;
    public static float maxYSpawn = 2.9f;
    public static float platformPositionStart = -1.0f;
    
    public static float alcanceVisao = 0.5f;

    public  int CountCandy = 0;
}




