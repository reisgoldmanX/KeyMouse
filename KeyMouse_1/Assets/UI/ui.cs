
using UnityEngine;
using UnityEngine.UIElements;

public class ui : MonoBehaviour
{

    public bool ui_state = false;
    private void OnEnable()
    {
        build_ui();
    }
    
    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(ui_state == true)
            {
                show_ui(false);
                
            }
            else
            {
                
                show_ui(true);
                Time.timeScale = 0;
            }
        }
        
    }
    private void build_ui()
    {
        ui_state = true;
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        Button start_btn = root.Q<Button>("start_btn");
        start_btn.clicked += () => start_btn_event();
        root.style.display = DisplayStyle.Flex;
    }
    private void show_ui(bool state)
    {
        ui_state = state;
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        if (ui_state == false)
        {
            root.style.display = DisplayStyle.None;
        }
        else
        {
            root.style.display = DisplayStyle.Flex;
        }
    }
    private void start_btn_event()
    {
        Time.timeScale = 1;
        show_ui(false);
    }
}
