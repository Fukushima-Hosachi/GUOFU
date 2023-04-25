using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_change02 : MonoBehaviour
{

    [SerializeField]
    string targetSceneName = "field";
    [SerializeField]
    GameObject transitionPrefab;

    readonly float waitTime = 1f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(nameof(LoadScene));
        }
    }

    IEnumerator LoadScene()
    {
        Instantiate(transitionPrefab);

        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene(targetSceneName);
    }

}