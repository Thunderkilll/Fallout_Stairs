using UnityEngine;


public class SkyboxChanger : MonoBehaviour
{
    public float RotationPerSecond = 1;
    public Material[] Skyboxes;
   
     int i=0;

    public void Awake()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotationPerSecond);
        
        //var options = Skyboxes.Select(skybox => skybox.name).ToList();
        //_dropdown.AddOptions(options);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))i=0 ;
        if (Input.GetKey(KeyCode.Alpha2)) i = 1;
        if (Input.GetKey(KeyCode.Alpha3)) i = 2;
        if (Input.GetKey(KeyCode.Alpha4)) i = 3;
        if (Input.GetKey(KeyCode.Alpha5)) i = 4;
        
        ChangeSkybox(i);
    }

    public void ChangeSkybox(int i)
    {
        RenderSettings.skybox = Skyboxes[i];
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotationPerSecond);
    }
}