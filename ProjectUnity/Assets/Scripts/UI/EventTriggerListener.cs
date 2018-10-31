using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using SLua;
[CustomLuaClass]
public class EventTriggerListener : UnityEngine.EventSystems.EventTrigger
{
    public delegate void VoidEventTriggerDelegate(GameObject go);
    public VoidEventTriggerDelegate onClick;
    public VoidEventTriggerDelegate onDown;
    public VoidEventTriggerDelegate onEnter;
    public VoidEventTriggerDelegate onExit;
    public VoidEventTriggerDelegate onUp;
    public VoidEventTriggerDelegate onSelect;
    public VoidEventTriggerDelegate onUpdateSelect;

    static public EventTriggerListener Get(GameObject go)
    {
        EventTriggerListener listener = go.GetComponent<EventTriggerListener>();
        if (listener == null) listener = go.AddComponent<EventTriggerListener>();
        return listener;
    }

    [DoNotToLua]
    public override void OnPointerClick(PointerEventData eventData)
    {
        if (onClick != null) onClick(gameObject);
    }

    [DoNotToLua]
    public override void OnPointerDown(PointerEventData eventData)
    {
        if (onDown != null) onDown(gameObject);
    }

    [DoNotToLua]
    public override void OnPointerEnter(PointerEventData eventData)
    {
        if (onEnter != null) onEnter(gameObject);
    }

    [DoNotToLua]
    public override void OnPointerExit(PointerEventData eventData)
    {
        if (onExit != null) onExit(gameObject);
    }

    [DoNotToLua]
    public override void OnPointerUp(PointerEventData eventData)
    {
        if (onUp != null) onUp(gameObject);
    }

    [DoNotToLua]
    public override void OnSelect(BaseEventData eventData)
    {
        if (onSelect != null) onSelect(gameObject);
    }

    [DoNotToLua]
    public override void OnUpdateSelected(BaseEventData eventData)
    {
        if (onUpdateSelect != null) onUpdateSelect(gameObject);
    }
}


