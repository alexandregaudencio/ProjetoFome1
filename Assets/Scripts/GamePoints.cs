using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePoints : MonoBehaviour
{
    private float ScorePoint = 0.0f;
    
    public Text ScoreText;
    public Transform player;
    public Rigidbody2D playerRB;
    public GameObject UIStartPage;

    public Text CandyScore;
    public int CandyScoreCount = 0;
    


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (VariableControler.gameStarted) {
            gameStart();
        }
        points();

    }


    public void points() {
        if( player.position.y > ScorePoint) {
            ScorePoint = player.position.y;
        }
        ScoreText.text = Mathf.Round(ScorePoint * 2).ToString();
    }

    public void CandyPoints() {
        CandyScoreCount++;
        CandyScore.text = CandyScoreCount.ToString();
        

    }

    public void gameStart() {
        UIStartPage.gameObject.SetActive(false);
    }

    public static void ResetGame() {
        VariableControler.gameStarted = false;
    }











}

