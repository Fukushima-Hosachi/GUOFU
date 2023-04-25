using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif    

[ExecuteInEditMode]
public class AxisDistanceSortCameraHelper : MonoBehaviour
{
    void Start()
    {
        var camera = GetComponent<Camera>();
        camera.transparencySortMode = TransparencySortMode.CustomAxis;
        camera.transparencySortAxis = new Vector3(0.0F, 1.0F, -0.26F);

#if UNITY_EDITOR
        foreach (SceneView sv in SceneView.sceneViews)
        {
            sv.camera.transparencySortMode = TransparencySortMode.CustomAxis;
            sv.camera.transparencySortAxis = new Vector3(0.0F, 1.0F, -0.26F);
        }
#endif      
    }
}