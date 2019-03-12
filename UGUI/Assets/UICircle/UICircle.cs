using UnityEngine;
using System.Collections;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UICircle : Image
{
    RectTransform m_RectTransform;
    protected UICircle()
    {
        
    }
    protected override void OnPopulateMesh(VertexHelper vh)
    {
        vh.Clear();
    }
    public override bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
    {
        if(m_RectTransform == null)
            m_RectTransform = GetComponent<RectTransform>();
        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(m_RectTransform, screenPoint, eventCamera, out position);
        var w = m_RectTransform.rect.width;
        var h = m_RectTransform.rect.height;
        var x = position.x;
        var y = position.y;
        var radius = Mathf.Min(w, h) / 2;       
        var b = x*x +y*y <=radius*radius;
        Debug.Log(b);
        return b;
    }

#if UNITY_EDITOR
    protected override void Reset()
    {
        base.Reset();
      
    }
#endif
}
#if UNITY_EDITOR
[CustomEditor(typeof(UICircle), true)]
public class UIPolygonInspector : Editor
{
    public override void OnInspectorGUI()
    {
    }
}
#endif