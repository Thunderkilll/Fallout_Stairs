using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToolTip : MonoBehaviour
{
    private static ToolTip instance;
    [SerializeField]
    Camera uiCamera;
    public float  PaddingSize = 4f;
    private Text tooltipText;
    private RectTransform backgroundRcTransform;
    private void Awake()
    {
        instance = this;
        backgroundRcTransform = transform.Find("background").GetComponent<RectTransform>();//find the object of tooltip and set the rect transform
        tooltipText = transform.Find("tooltipText").GetComponent<Text>();//get the child of this tooltip text and set the tooltipText variable 
                                                                         //   ShowToolTip("name : type of bear ici   \n Description :description ici  \n Added Score =  0"  );
        HideToolTip_static();
    }
    private void Update()
    {
        Vector2 localPoint;
         
        RectTransformUtility.ScreenPointToLocalPointInRectangle(transform.parent.GetComponent<RectTransform>(),
            Input.mousePosition  , uiCamera , out localPoint); //follow the mouse position
        transform.localPosition = localPoint;
    }
    private void ShowToolTip(string tooltipString)
    {
        gameObject.SetActive(true); //set out tooltip to active
        tooltipText.text = tooltipString ; //set the tooltipText to our text 
        float textPaddingSize = PaddingSize; //padding size of our text to see it clear 
        Vector2 backgroundSize2D = new Vector2(tooltipText.preferredWidth + textPaddingSize *2f, tooltipText.preferredHeight + textPaddingSize * 2f);//calculate the size of our background 
        backgroundRcTransform.sizeDelta = backgroundSize2D; //set the background rect size here 
    }
    private void HideToolTip()
    {
        gameObject.SetActive(false);  //deactivate the tooltip
    }


    public static void ShowToolTip_static(string tooltipString)
    {
        instance.ShowToolTip(tooltipString);
    }
    public static void HideToolTip_static()
    {
        instance.HideToolTip();
    }
}
