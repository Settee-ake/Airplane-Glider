using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;


public class CoinCollection : MonoBehaviour
{
    private int Coin = 5;
// [SerializeField] private AudioClip coinPickUpSound;
// private AudioSource audioSource;
    public TextMeshProUGUI coinText;
    // private void OnTriggerEnter(Collider other)
    // {
    //         Debug.Log(Coin);
    //         Destroy(other.gameObject);
    // }
    private void OnTriggerExit(Collider other)
    {

        if(other.transform.tag == "Coin") {
            // audioSource.clip = coinPickUpSound;
            // audioSource.Play();
            Coin--;
            coinText.text = "Coins Left: " + Coin.ToString();
            Debug.Log(Coin);
            Destroy(other.gameObject);
        } else{
                    SceneManager.LoadSceneAsync(0);
        }

        if(Coin == 0 ){
        SceneManager.LoadSceneAsync(0);

        }

    }

}
