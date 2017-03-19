using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour {
    private CoinSystem _coinSystem;
    private AudioSource _coinCollectAudio;
    //private int _audioFrequency;
    //private int _audioSamples;
    private Renderer _renderer;
    private CapsuleCollider _collision;
    // Use this for initialization
    void Start () {
        _coinSystem = GameObject.Find("ScoreCounter").GetComponent<CoinSystem>();
        _coinCollectAudio = GetComponent<AudioSource>();
        _renderer = GetComponent<Renderer>();
        _collision = GetComponent<CapsuleCollider>();
        //_audioSamples = _coinCollectAudio.timeSamples;
    }
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter(Collider info)
    {
        _coinCollectAudio.Play();
        _coinSystem.CoinsCollected++;
        _renderer.enabled = false;//disable collision so we won't be able to see the object during audio playtime.
        _collision.enabled = false;//disable collision so we won't be able to collide with object during audio playtime.
        if(this.GetComponentInChildren<Light>() != null)
        this.GetComponentInChildren<Light>().enabled = false;//disable fight so we won't be able to see it during audio playtime.
        Destroy(gameObject, 2);//_audioSamples / _audioFrequency need to wait audio time to delete else audio wont play =(
    }
}
