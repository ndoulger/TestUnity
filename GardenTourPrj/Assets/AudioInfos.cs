using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioInfos : MonoBehaviour
{
    public AudioClip[] aClips;
    public int InfoNum;
    public AudioSource myAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        InfoNum = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlaySound()
    {
        myAudioSource.clip = aClips[InfoNum];
        myAudioSource.Play();
    }
    public void ChangeInfoNum(int NewInfoNum)
    {
        InfoNum = NewInfoNum;
    }
}
