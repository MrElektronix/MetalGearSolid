using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent((typeof(ParticleSystem)))]
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
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (!_pSystem.isPlaying)
            {
                _pSystem.Play();
            }
            else if (_pSystem.isPlaying)
            {
                _pSystem.Stop();
            }
        }
    }

    IEnumerator ParticleSystemSwitchOnLoad()
    {
        yield return new WaitForSeconds(1);
        if (_pSystem.isPlaying)
        {
            _pSystem.Stop();
        }
    }

}
