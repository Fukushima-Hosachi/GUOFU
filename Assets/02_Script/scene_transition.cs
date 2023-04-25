using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene_transition : MonoBehaviour
{

    
    readonly float waitTime = 1f;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        StartCoroutine(nameof(Transition));
        
    }

    IEnumerator Transition()
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
