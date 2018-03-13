using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _score = 0;

    public Text ScoreText;

    public GameObject Player;

    public float PlayerSizeIncrement = 0.05f;

	void Update()
	{
	    ScoreText.text = $"Score: {_score}";
	}

    public void HandleKill()
    {
        _score++;

        Player.transform.localScale += new Vector3(PlayerSizeIncrement, PlayerSizeIncrement, PlayerSizeIncrement);
    }
}
