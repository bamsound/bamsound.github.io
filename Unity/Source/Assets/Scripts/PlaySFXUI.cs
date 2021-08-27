using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySFXUI : MonoBehaviour
{
    // Start is called before the first frame update

	public AudioSource audioSource;
	public AudioClip buttonSound;

    public void playSFX()
    {
	audioSource.PlayOneShot(buttonSound);
    }
}
