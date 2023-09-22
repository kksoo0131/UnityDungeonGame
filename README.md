# UnityDungeonGame
전에 만들었던 C# text rpg를 이번에는 Unity로 만들어보자.

## Contributor

김광수

## 선택 과제

스파르타 던전 - Unity  버전!

## 필수 요구 사항

1. 메인 UI 구성
2. Status UI 구성
3. Inventory UI 구성


## [UIManager](https://github.com/kksoo0131/UnityDungeonGame/blob/main/Assets/Scripts/Manager/UIManager.cs)

UI들을 관리하는 싱글톤 클래스로 큰 UI (Scene이나 Popup)들을 관리한다.

현재 열려있는 UI들을 Stack<UI>로 관리한다.

public void OpenUI(UI ui) // UI를 OnUI()시키고 UIStack에 Push()

public void CloseUI() // UIStack에서 UI를 Pop햐서 OffUI() 시키고 Peek()으로 가장 위에 올려진 UI를 최신화 시킨다.

## [UI](https://github.com/kksoo0131/UnityDungeonGame/tree/main/Assets/Scripts/UI)

모든 UI의 최상위 클래스로 싱글톸 클래스인 UIManager를 참조하고 있고 

UI를 키고 끄기위한 OnUI(), OffUI()메서드를 가진다.

## UI_Button : UI

모든 UI_Button의 상위클래스로 ButtonEvent()에 원하는 기능을 구현


## [Stats, Item](https://github.com/kksoo0131/UnityDungeonGame/tree/main/Assets/Scripts/ScriptableObject)

캐릭터의 stats 정보와 item 정보는 ScriptableObject를 사용해서 구현

## Inveotory

인벤토리 클래스는 List<ItemSO>를 가지고 

UI_Inventory는 연결된 Inventory클래스의 정보를 받아와 uiLayout의 하위 계층인 슬롯에 입력한다.

Item의 장착 여부는 ItemSO에서 bool로 관리한다.


