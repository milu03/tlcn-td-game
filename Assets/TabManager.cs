using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabManager : MonoBehaviour
{
    public GameObject[] Tabs;
    public Image[] TabButtons;
    public Sprite InactiveTabBG, ActiveTabBG;
    public Vector2 InactiveTabButtonSize, ActiveTabButtonSize;

    // Thêm biến tham chiếu đến TabsMenu và OptionButton
    public GameObject TabsMenu;
    public Button OptionButton;
    public Button ExitModalButton;

    void Start()
    {
        if (TabsMenu != null)
        {
            TabsMenu.SetActive(false);
        }

        if (OptionButton != null)
        {
            OptionButton.onClick.AddListener(() => ShowTabsMenu());
        }

        if (ExitModalButton != null)
        {
            ExitModalButton.onClick.AddListener(() => CloseTabsMenu());
        }
    }

    public void SwitchToTab(int tabID)
    {
        foreach (GameObject go in Tabs)
        {
            go.SetActive(false);
        }
        Tabs[tabID].SetActive(true);
        foreach (Image im in TabButtons)
        {
            im.sprite = InactiveTabBG;
            im.rectTransform.sizeDelta = InactiveTabButtonSize;
        }
        TabButtons[tabID].sprite = ActiveTabBG;
        TabButtons[tabID].rectTransform.sizeDelta = ActiveTabButtonSize;
    }

    public void ShowTabsMenu()
    {
        if (TabsMenu != null)
        {
            TabsMenu.SetActive(true);
            SwitchToTab(0);
        }
    }

    public void CloseTabsMenu()
    {
        if (TabsMenu != null)
        {
            TabsMenu.SetActive(false);
        }
    }

    void Update()
    {

    }
}
