using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuCamUI : MonoBehaviour
{
    Button bttn1;
    public GameObject MainCam;
    public GameObject Icon;
    public GameObject MainButton;
    public GameObject OptionsCam;
    public GameObject OptionsMenu;

    // Start is called before the first frame update
    void Start()
    {
        MainCam.SetActive(true);
        Icon.SetActive(true);
        MainButton.SetActive(true);
        OptionsCam.SetActive(false);
        OptionsMenu.SetActive(false);
        UIDocument uid = gameObject.GetComponent<UIDocument>();
        var root = uid.rootVisualElement;
        bttn1 = root.Q<Button>("button_1");

        bttn1.clicked += () => print_message(bttn1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void print_message(Button bttn1) {
        MainCam.SetActive(false);
        Icon.SetActive(false);
        MainButton.SetActive(false);
        OptionsCam.SetActive(true);
        OptionsMenu.SetActive(true);
    }
}
