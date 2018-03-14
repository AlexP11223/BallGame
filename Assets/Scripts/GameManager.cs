using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _score = 0;

    public Text ScoreText;

    public GameObject Player;

    public float PlayerSizeIncrement = 0.05f;

    public Text TimeText;
    public float TimeLimit = 60f;

    public Animator UiAnim;

    void Start()
    {
        StartCoroutine(GameOverTimer(TimeLimit));
    }

    IEnumerator GameOverTimer(float timeLimit)
    {
        float timeLeft = timeLimit;

        while (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            TimeText.text = $"Time: {Math.Truncate(timeLeft)}";
            if (timeLeft < 10)
            {
                TimeText.color = new Color32(255, 180, 180, 255);
            }

            yield return null;
        }

        TimeText.text = "Time: 0";
        TimeText.color = new Color32(255, 127, 127, 255);

        OnGameOver();
    }
    void Update()
	{
	    ScoreText.text = $"Score: {_score}";
	}

    public void HandleKill()
    {
        _score++;

        Player.transform.localScale += new Vector3(PlayerSizeIncrement, PlayerSizeIncrement, PlayerSizeIncrement);

    }

    void OnGameOver()
    {
        // freeze player
        Player.GetComponent<Rigidbody>().isKinematic = true;

        UiAnim.SetTrigger("GameOver");
    }
}
