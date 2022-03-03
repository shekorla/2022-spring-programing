using UnityEngine;

public class paddle : MonoBehaviour
{
    float mousePos;
    double offset=-10;
    private Vector3 paddlePos;
    public static bool simulateMouseWithTouches = true;
    void Update()
    {
        mousePos = Input.mousePosition.x / Screen.width * 50;
        paddlePos = new Vector3((float) (mousePos+offset), this.transform.position.y, 0f);
        this.transform.position = paddlePos;
    }

}
