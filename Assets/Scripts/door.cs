using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip doorSound;
    public AudioClip leverSound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.name == "door")
        {
            audioSource.clip = doorSound;
            audioSource.Play();
            StartCoroutine("WaitDoorSound");
        }
        if (collider.gameObject.name == "레버")
        {
            audioSource.clip = leverSound;
            audioSource.Play();
        }
    }

    IEnumerator WaitDoorSound()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Game 2");
    }


}
