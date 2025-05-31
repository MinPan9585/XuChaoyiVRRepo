using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class PuzzleFragment : XRBaseInteractable
{ 
    private Vector3 initialPosition;

    public bool isBeingDragged = false; // 标记物体是否正在被拖拽

    private void Start()
    {
        // 初始化物体的初始位置
        initialPosition = transform.position;
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        isBeingDragged = true; // 当物体被选中时，标记为正在拖拽
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        isBeingDragged = false; // 当物体被释放时，取消拖拽标记
        //transform.position = initialPosition; // 恢复到初始位置
    }

    private void Update()
    {
        if (isBeingDragged && firstInteractorSelecting != null)
        {
            // 获取射线交互器的位置
            Vector3 interactorPosition = firstInteractorSelecting.transform.position;

            // 更新物体的位置，保持 z 轴不变
            transform.position = new Vector3(interactorPosition.x, interactorPosition.y, initialPosition.z);
        }
    }
}