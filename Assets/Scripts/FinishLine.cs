using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float Restartdelay = 1f;
    [SerializeField] ParticleSystem FinishParticles;

    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Player");
        if (collision.gameObject.layer == layerIndex )
        {
            FinishParticles.Play();
            Invoke("ReloadScene", Restartdelay);
        }

    }
    void ReloadScene()
    { SceneManager.LoadScene(0); }
}
