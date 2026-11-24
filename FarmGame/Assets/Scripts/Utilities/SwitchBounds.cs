using Cinemachine;
using UnityEngine;

public class SwitchBounds : MonoBehaviour
{
    //TODO:切换场景后更改调用
    void Start()
    {
        SwitchConfinerShape();
    }
    private void SwitchConfinerShape()
    {
        PolygonCollider2D confinerShape = GameObject.FindGameObjectWithTag("BoundsConfiner").GetComponent<PolygonCollider2D>();

        CinemachineConfiner confiner = GetComponent<CinemachineConfiner>();

        confiner.m_BoundingShape2D = confinerShape;

        //每一次切换边界的时候都要调用这个方法来清除缓存
        confiner.InvalidatePathCache();
    }
}
