
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClicHandle : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerClickHandler,  IPointerEnterHandler, IPointerExitHandler
{
    private Image myimage;
    private RectTransform rtrans;
    private Canvas mycanvas;
    private Color curcolor;
    public Transform t;
    private void Awake()
    {
        myimage = GetComponent<Image>();
        rtrans = GetComponent<RectTransform>();
        mycanvas = GetComponentInParent<Canvas>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        rtrans.localScale = new Vector2(1.5f, 1.5f);
    }
    public void OnDrag(PointerEventData eventData)
    {
        rtrans.anchoredPosition += eventData.delta / mycanvas.scaleFactor;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        rtrans.localScale = new Vector2(1f, 1f);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        transform.localRotation = Quaternion.Euler(0f, 0f, Random.Range(15, 60));
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        curcolor = myimage.color;
        myimage.color = new Color(Random.value, Random.value, Random.value);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        myimage.color = curcolor;
    }
}

