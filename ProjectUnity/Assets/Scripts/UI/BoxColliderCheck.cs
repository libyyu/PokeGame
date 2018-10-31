using UnityEngine;
using UnityEngine.Events;
using SLua;

[CustomLuaClass]
public class BoxColliderCheck : MonoBehaviour {

    private BoxColliderTriggerEvent onEnter = new BoxColliderTriggerEvent();
    public BoxColliderTriggerEvent onEnterCollider { get { return onEnter; } set { onEnter = value; } }

    void Start() { }

    void Update()
    {
        if (null == Camera.main)
            return;
        if (Input.touchCount > 0 || Input.GetMouseButtonDown(0))
        {
            {
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider != null && hit.collider.gameObject == this.gameObject)
                    {
                        if (onEnterCollider != null)
                        {
                            onEnterCollider.Invoke();
                        }
                        return;
                    }
                }
            }
            
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                if (hit && hit.collider != null && hit.collider.gameObject == this.gameObject)
                {
                    if (onEnterCollider != null)
                    {
                        onEnterCollider.Invoke();
                    }
                    return;
                }
            }

            Collider2D[] col = Physics2D.OverlapPointAll(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            if (col.Length > 0)
            {
                foreach (Collider2D c in col)
                {
                    if (onEnterCollider != null && this.gameObject == c.gameObject)
                    {
                        onEnterCollider.Invoke();
                    }
                }
            }
        }
    }

    [CustomLuaClass]
    public class BoxColliderTriggerEvent : UnityEvent
    {
        public BoxColliderTriggerEvent() { }
    }
}
