using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator _anim;
    private bool _isDead = false;

    public AudioSource SplatSound;
    public AudioSource SquelchSound;

    public bool IsDead
    {
        get { return _isDead; }
        private set
        {
            _isDead = value;
            _anim.SetBool(nameof(IsDead), IsDead);
        }
    }
    
    void Start ()
    {
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
            SplatSound.Play();
        }

        IsDead = true;
    }
}
