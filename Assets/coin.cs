using UnityEngine;

public class coin : MonoBehaviour
{

[SerializeField] private AudioClip coinPickUpSound;
private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
}
