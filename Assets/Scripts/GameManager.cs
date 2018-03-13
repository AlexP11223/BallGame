using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _score = 0;

    public Text ScoreText;

	void Update()
	{
	    ScoreText.text = $"Score: {_score}";
	}

    public void HandleKill()
    {
        _score++;
    }
}
