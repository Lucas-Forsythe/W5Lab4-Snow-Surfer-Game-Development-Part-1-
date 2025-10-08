using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float Restartdelay = .05f;
    [SerializeField] ParticleSystem PlayerParticles;
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Floor");
        if (collision.gameObject.layer == layerIndex)
        {
            PlayerParticles.Play();
            Invoke("ReloadScene", Restartdelay);
        }

    }
    void ReloadScene()
    { SceneManager.LoadScene(0); }
}
