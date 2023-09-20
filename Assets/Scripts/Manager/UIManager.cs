using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // 기존에 사용하던 UI를 List에 담고 Enum으로 관리하는 방법은 직관적이지 못하다는 피드백을 받음


    // 직접 접근하지 못하고 Enum 값을 확인한다음 Enum값을 입력해줘야 되기 때문인가?

    // List가 아니라 UIManager가 각각의 UI를 직접들고 있는다면 UIManager.Instance.UIName으로 접근할수 있고, UI가 있는지 확인이 가능(자동완성)

    // List[UIType.UIName] 으로 접근해야할 경우  List[UIType.UIName]이 실제로 List에 있는지 확인이 직관적이지 않다?

    // 결국 1. Enum 값 확인해야됨 2.리스트가 제대로 초기화 되어있을지 직관적이지 못함 등의 문제 
    

    // UI가 켜질때마다 Stack으로 쌓고 위에서 부터 닫는다?
    public static UIManager Instance;

    public Stack<UI> UIStack;

    public UI_Main main;
    public UI_CharacterStatus status;
    public UI_Inventory inventory;

    private void Awake()
    {
        Instance = this;
        UIStack = new Stack<UI>();
    }

    private void Start()
    {
        OpenUI(main);
    }

    public void OpenUI(UI ui)
    {
        ui.OnUI();
        UIStack.Push(ui);
    }

    public void CloseUI()
    {
        UI closeUI = UIStack.Pop();
        closeUI.OffUI();
        UIStack.Peek().OnUI();
        // 다시 가장 위에 보이게될 UI를 초기화 하기위해서.
    }

    
}
