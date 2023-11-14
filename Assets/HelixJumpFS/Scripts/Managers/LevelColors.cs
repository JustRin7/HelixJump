using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class LevelPallete
{
    public Color AxisColor;
    public Color BallColor;
    public Color DefaultSegmentColor;
    public Color TratSegmentColor;
    public Color FinishSegmentColor;
    public Color BackgroundtColor;
    public Color BackgroundtCameraColor;
}

public class LevelColors : MonoBehaviour
{  
    [SerializeField] private LevelPallete[] pallete;

    [SerializeField] private Material axisMaterial;
    [SerializeField] private Material ballMaterial;
    [SerializeField] private Material defaultSegmentMaterial;
    [SerializeField] private Material tratSegmentMaterial;
    [SerializeField] private Material finishSegmentMaterial;
    [SerializeField] private Image backgroundImage;
    [SerializeField] private Camera backgroundCamera;

    public void Start()
    {
        int index = Random.Range(0, pallete.Length);

        axisMaterial.color = pallete[index].AxisColor;
        ballMaterial.color = pallete[index].BallColor;
        defaultSegmentMaterial.color = pallete[index].DefaultSegmentColor;
        tratSegmentMaterial.color = pallete[index].TratSegmentColor;
        finishSegmentMaterial.color = pallete[index].FinishSegmentColor;
        backgroundImage.color = pallete[index].BackgroundtColor;
        backgroundCamera.backgroundColor = pallete[index].BackgroundtCameraColor;
    }
}
