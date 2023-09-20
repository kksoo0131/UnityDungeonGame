using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // ������ ����ϴ� UI�� List�� ��� Enum���� �����ϴ� ����� ���������� ���ϴٴ� �ǵ���� ����


    // ���� �������� ���ϰ� Enum ���� Ȯ���Ѵ��� Enum���� �Է������ �Ǳ� �����ΰ�?

    // List�� �ƴ϶� UIManager�� ������ UI�� ������� �ִ´ٸ� UIManager.Instance.UIName���� �����Ҽ� �ְ�, UI�� �ִ��� Ȯ���� ����(�ڵ��ϼ�)

    // List[UIType.UIName] ���� �����ؾ��� ���  List[UIType.UIName]�� ������ List�� �ִ��� Ȯ���� ���������� �ʴ�?

    // �ᱹ 1. Enum �� Ȯ���ؾߵ� 2.����Ʈ�� ����� �ʱ�ȭ �Ǿ������� ���������� ���� ���� ���� 
    

    // UI�� ���������� Stack���� �װ� ������ ���� �ݴ´�?
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
        // �ٽ� ���� ���� ���̰Ե� UI�� �ʱ�ȭ �ϱ����ؼ�.
    }

    
}
