using UnityEngine;
using UnityEngine.UI;

public class Bit : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public bool state = false;
    public Text output;

    void Start()
    {
            spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (state)
        {
            spriteRenderer.color = Color.green;
            output.text = "1";
        }
        else
        {
            spriteRenderer.color = Color.red;
            output.text = "0";
        }
    }
    private void OnMouseUp()
    {
        state = !state;
    }
}
