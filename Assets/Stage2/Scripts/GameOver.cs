using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject gameOverText;
    [SerializeField] float maxTime = 10f;
    Player2 player;
    float tl;
    //public Image timeBar;
    TimeManager time;

    // Start is called before the first frame update
    void Awake()
    {
        gameOverText.SetActive(false);
        //timeBar = GetComponent<Image>();
        tl=time.timeLeft;
        //timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {

		if(tl<=0||player.health2<=0)
		{
            gameOverText.SetActive(true);
			Time.timeScale = 0;
		}
    }
}
