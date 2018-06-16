using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class LongPressOrClickEventTrigger : UIBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler,
    IPointerClickHandler
{
    [Tooltip("How long must pointer be down on this object to trigger a long press")]
    public float durationThreshold = 5f;


    private bool isPointerDown = false;
    private bool longPressTriggered = false;
    private float timePressStarted;
    public PageName centerName;

    private void Update()
    {
        if (isPointerDown && !longPressTriggered)
            if (Time.time - timePressStarted > durationThreshold)
            {
                longPressTriggered = true;
                PageController.GoTo(centerName);
            }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        timePressStarted = Time.time;
        isPointerDown = true;
        longPressTriggered = false;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPointerDown = false;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isPointerDown = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!longPressTriggered)
            AndroidUtil.Toast("长按5s进入家长中心~~");
    }
}