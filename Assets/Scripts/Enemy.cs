using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator _anim;
    private bool _isDead = false;

    private GameManager _gameManager;

    public AudioSource SplatSound;
    public AudioSource SquelchSound;

    public bool IsDead
    {
        get { return _isDead; }
        private set
        {
            if (_isDead == value)
            {
                return;
            }

            _isDead = value;
            _anim.SetBool(nameof(IsDead), IsDead);
        }
    }
    
    void Start ()
    {
        _gameManager = FindObjectOfType<GameManager>();

        _anim = GetComponentInParent<Animator>();
    }
	
	void Update () {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (IsDead)
        {
            SquelchSound.Play();
        }
        else
        {
            _gameManager.HandleKill();

            SplatSound.Play();
        }

        IsDead = true;
    }
}
