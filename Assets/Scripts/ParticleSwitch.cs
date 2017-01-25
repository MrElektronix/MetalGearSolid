using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSwitch : MonoBehaviour {

    private ParticleSystem _pSystem;

	void Start ()
    {
        _pSystem = GetComponent<ParticleSystem>();
        StartCoroutine(ParticleSystemSwitchOnLoad());
    }

    void Update()
    {
        var _psMain = _pSystem.main;
        if (Input.GetKey(KeyCode.M))
        {
            if (!_pSystem.isPlaying)
            {
                _pSystem.Play();
                Debug.Log("no-rip");
            }
            if (_pSystem.isPlaying)
            {
                Debug.Log("renemiesInRangeip");
                _pSystem.Stop();
            }
        }
    }

    IEnumerator ParticleSystemSwitchOnLoad()
    {
        yield return new WaitForSeconds(1);
        if (_pSystem.isPlaying)
        {
            Debug.Log("autorip");
            _pSystem.Stop();
        }
    }

}
