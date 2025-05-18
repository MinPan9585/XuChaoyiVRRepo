using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PuzzleFragment : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;
    private bool isGrabbed = false;
    private Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        // 获取XRGrabInteractable组件
        grabInteractable = GetComponent<XRGrabInteractable>();
        if (grabInteractable == null)
        {
            grabInteractable = gameObject.AddComponent<XRGrabInteractable>();
        }

        // 保存初始位置
        initialPosition = transform.position;

        // 添加事件监听器
        grabInteractable.selectEntered.AddListener(OnGrab);
        grabInteractable.selectExited.AddListener(OnRelease);
    }

    // Update is called once per frame
    void Update()
    {
        // 如果被抓取，则限制Z轴移动
        if (isGrabbed)
        {
            Vector3 newPosition = transform.position;
            newPosition.z = initialPosition.z; // 保持Z轴不变
            transform.position = newPosition;
        }
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        isGrabbed = true;
    }

    private void OnRelease(SelectExitEventArgs args)
    {
        isGrabbed = false;
    }
}