using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Assets.SimpleLocalization;

public class HierarchyManager : MonoBehaviour
{
    public static string set_1;

    public static string set_2;

    public static string set_3;

    public static string set_4;

    public static string set_5;

    private int countInstance;

    [SerializeField] private GameObject set_1_Panel;
    [SerializeField] private GameObject set_2_Panel;
    [SerializeField] private GameObject set_3_Panel;
    [SerializeField] private GameObject set_4_Panel;
    [SerializeField] private GameObject set_5_Panel;

    [SerializeField] private GameObject[] set_2_Buttons;
    [SerializeField] private GameObject[] set_3_Buttons;
    [SerializeField] private GameObject[] set_4_Buttons;
    [SerializeField] private GameObject[] set_5_Buttons;

    // Start is called before the first frame update
    void Start()
    {
        set_1 = "";
        set_2 = "";
        set_3 = "";
        set_4 = "";
        set_5 = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Button Set 1-------------------------------
    public void SetupForSet1(string message)
    {
        set_1 = message;
    }

    public void SetupForSet2(string message)
    {
        set_2 = message;
    }

    public void SetupForSet3(string message)
    {
        set_3 = message;
    }

    public void SetupForSet4(string message)
    {
        set_4 = message;
    }

    public void SetupForSet5(string message)
    {
        set_5 = message;
    }

    public void AcrivateNumberOfButtons(int count, GameObject[] arr, GameObject currentPanel, GameObject nextPanel)
    {
        countInstance = count;
        currentPanel.SetActive(false);
        nextPanel.SetActive(true);

        for (int i = 0; i < count; i++)
        {
            arr[i].gameObject.SetActive(true);
        }
    }

    public void ActiveNumberOfButtonsManual()
    {
        switch (HierarchyManager.set_1)
        {
            case "1":
                
                switch (HierarchyManager.set_2)
                {
                    case "1":
                        switch (HierarchyManager.set_3)
                        {
                            case "1":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        //final
                                        break;
                                    case "2":
                                        //final
                                        break;
                                    case "3":
                                        //final
                                        break;
                                    default:
                                        for (int i = 0; i < set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[0].localizationIndex.Count; i++)
                                        {
                                            string key = set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[0].localizationIndex[i];
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                        }
                                        AcrivateNumberOfButtons(3, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            case "2":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        //final
                                        break;
                                    case "2":
                                        //final
                                        break;
                                    default:
                                        for (int i = 0; i < set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[1].localizationIndex.Count; i++)
                                        {
                                            string key = set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[1].localizationIndex[i];
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                        }
                                        AcrivateNumberOfButtons(3, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            case "3":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        //final
                                        break;
                                    case "2":
                                        //final
                                        break;
                                    default:
                                        for (int i = 0; i < set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[2].localizationIndex.Count; i++)
                                        {
                                            string key = set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[2].localizationIndex[i];
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                        }
                                        AcrivateNumberOfButtons(3, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            default:
                                for (int i = 0; i < set_3_Panel.GetComponent<ListHandler>().localizationKeyContainer[0].localizationIndex.Count; i++)
                                {
                                    string key = set_3_Panel.GetComponent<ListHandler>().localizationKeyContainer[0].localizationIndex[i];
                                    set_3_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                    set_3_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                }
                                AcrivateNumberOfButtons(3, set_3_Buttons, set_2_Panel, set_3_Panel);
                                break;
                        }
                        
                        break;

                    case "2":
                        switch (HierarchyManager.set_3)
                        {
                            case "1":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        //final
                                        break;
                                    case "2":
                                        //final
                                        break;
                                    case "3":
                                        //final
                                        break;
                                    case "4":
                                        //final
                                        break;
                                    case "5":
                                        //final
                                        break;
                                    default:
                                        for (int i = 0; i < set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[3].localizationIndex.Count; i++)
                                        {
                                            string key = set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[3].localizationIndex[i];
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                        }
                                        AcrivateNumberOfButtons(5, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            case "2":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        //final
                                        break;
                                    case "2":
                                        //final
                                        break;
                                    case "3":
                                        //final
                                        break;
                                    case "4":
                                        //final
                                        break;
                                    case "5":
                                        //final
                                        break;
                                    default:
                                        for (int i = 0; i < set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[4].localizationIndex.Count; i++)
                                        {
                                            string key = set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[4].localizationIndex[i];
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                        }
                                        AcrivateNumberOfButtons(5, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            case "3":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        //final
                                        break;
                                    case "2":
                                        //final
                                        break;
                                    case "3":
                                        //final
                                        break;
                                    case "4":
                                        //final
                                        break;
                                    case "5":
                                        //final
                                        break;
                                    default:
                                        for (int i = 0; i < set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[5].localizationIndex.Count; i++)
                                        {
                                            string key = set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[5].localizationIndex[i];
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                        }
                                        AcrivateNumberOfButtons(5, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            default:
                                for (int i = 0; i < set_3_Panel.GetComponent<ListHandler>().localizationKeyContainer[1].localizationIndex.Count; i++)
                                {
                                    string key = set_3_Panel.GetComponent<ListHandler>().localizationKeyContainer[1].localizationIndex[i];
                                    set_3_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                    set_3_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                }
                                AcrivateNumberOfButtons(3, set_3_Buttons, set_2_Panel, set_3_Panel);
                                break;
                        }
                        break;

                    case "3":
                        switch (HierarchyManager.set_3)
                        {
                            case "1":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        //final
                                        break;
                                    case "2":
                                        //final
                                        break;
                                    case "3":
                                        //final
                                        break;
                                    case "4":
                                        //final
                                        break;
                                    default:
                                        for (int i = 0; i < set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[6].localizationIndex.Count; i++)
                                        {
                                            string key = set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[6].localizationIndex[i];
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                        }
                                        AcrivateNumberOfButtons(4, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            case "2":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        //final
                                        break;
                                    case "2":
                                        //final
                                        break;
                                    case "3":
                                        //final
                                        break;
                                    case "4":
                                        //final
                                        break;
                                    default:
                                        for (int i = 0; i < set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[7].localizationIndex.Count; i++)
                                        {
                                            string key = set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[7].localizationIndex[i];
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                        }
                                        AcrivateNumberOfButtons(4, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            case "3":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        //final
                                        break;
                                    case "2":
                                        //final
                                        break;
                                    case "3":
                                        //final
                                        break;
                                    case "4":
                                        //final
                                        break;
                                    default:
                                        for (int i = 0; i < set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[8].localizationIndex.Count; i++)
                                        {
                                            string key = set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[8].localizationIndex[i];
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                        }
                                        AcrivateNumberOfButtons(4, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            default:
                                for (int i = 0; i < set_3_Panel.GetComponent<ListHandler>().localizationKeyContainer[2].localizationIndex.Count; i++)
                                {
                                    string key = set_3_Panel.GetComponent<ListHandler>().localizationKeyContainer[2].localizationIndex[i];
                                    set_3_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                    set_3_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                }
                                AcrivateNumberOfButtons(3, set_3_Buttons, set_2_Panel, set_3_Panel);
                                break;
                        }
                        break;

                    case "4":
                        switch (HierarchyManager.set_3)
                        {
                            case "1":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        switch (HierarchyManager.set_5)
                                        {
                                            case "1":
                                                //final
                                                break;
                                            case "2":
                                                //final
                                                break;
                                            case "3":
                                                //final
                                                break;
                                            case "4":
                                                //final
                                                break;
                                           
                                            default:
                                                AcrivateNumberOfButtons(4, set_5_Buttons, set_4_Panel, set_5_Panel);
                                                break;
                                        }
                                        break;
                                    case "2":
                                        switch (HierarchyManager.set_5)
                                        {
                                            case "1":
                                                //final
                                                break;
                                            case "2":
                                                //final
                                                break;
                                            case "3":
                                                //final
                                                break;
                                            case "4":
                                                //final
                                                break;

                                            default:
                                                AcrivateNumberOfButtons(4, set_5_Buttons, set_4_Panel, set_5_Panel);
                                                break;
                                        }
                                        break;
                                    default:
                                        for (int i = 0; i < set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[9].localizationIndex.Count; i++)
                                        {
                                            string key = set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[9].localizationIndex[i];
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                        }
                                        AcrivateNumberOfButtons(2, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            case "2":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        switch (HierarchyManager.set_5)
                                        {
                                            case "1":
                                                //final
                                                break;
                                            case "2":
                                                //final
                                                break;
                                            case "3":
                                                //final
                                                break;
                                            case "4":
                                                //final
                                                break;
                                            case "5":
                                                //final
                                                break;
                                            case "6":
                                                //final
                                                break;
                                            case "7":
                                                //final
                                                break;
                                            case "8":
                                                //final
                                                break;
                                            case "9":
                                                //final
                                                break;
                                            case "10":
                                                //final
                                                break;
                                            case "11":
                                                //final
                                                break;
                                            case "12":
                                                //final
                                                break;
                                            case "13":
                                                //final
                                                break;
                                            case "14":
                                                //final
                                                break;
                                            case "15":
                                                //final
                                                break;
                                            case "16":
                                                //final
                                                break;
                                            case "17":
                                                //final
                                                break;
                                            case "18":
                                                //final
                                                break;
                                            case "19":
                                                //final
                                                break;
                                            case "20":
                                                //final
                                                break;
                                            default:
                                                AcrivateNumberOfButtons(20, set_5_Buttons, set_4_Panel, set_5_Panel);
                                                break;
                                        }
                                        break;
                                    case "2":
                                        switch (HierarchyManager.set_5)
                                        {
                                            case "1":
                                                //final
                                                break;
                                            case "2":
                                                //final
                                                break;
                                            case "3":
                                                //final
                                                break;
                                            case "4":
                                                //final
                                                break;
                                            case "5":
                                                //final
                                                break;
                                            case "6":
                                                //final
                                                break;
                                            case "7":
                                                //final
                                                break;
                                            case "8":
                                                //final
                                                break;
                                            case "9":
                                                //final
                                                break;
                                            case "10":
                                                //final
                                                break;
                                            case "11":
                                                //final
                                                break;
                                            case "12":
                                                //final
                                                break;
                                            case "13":
                                                //final
                                                break;
                                            case "14":
                                                //final
                                                break;
                                            case "15":
                                                //final
                                                break;
                                            case "16":
                                                //final
                                                break;
                                            case "17":
                                                //final
                                                break;
                                            case "18":
                                                //final
                                                break;
                                            case "19":
                                                //final
                                                break;
                                            case "20":
                                                //final
                                                break;
                                            default:
                                                AcrivateNumberOfButtons(20, set_5_Buttons, set_4_Panel, set_5_Panel);
                                                break;
                                        }
                                        break;
                                    default:
                                        for (int i = 0; i < set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[10].localizationIndex.Count; i++)
                                        {
                                            string key = set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[10].localizationIndex[i];
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                        }
                                        AcrivateNumberOfButtons(2, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            default:
                                for (int i = 0; i < set_3_Panel.GetComponent<ListHandler>().localizationKeyContainer[3].localizationIndex.Count; i++)
                                {
                                    string key = set_3_Panel.GetComponent<ListHandler>().localizationKeyContainer[3].localizationIndex[i];
                                    set_3_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                    set_3_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                }
                                AcrivateNumberOfButtons(2, set_3_Buttons, set_2_Panel, set_3_Panel);
                                break;
                        }
                        break;

                    default:
                        for(int i=0; i< set_2_Panel.GetComponent<ListHandler>().localizationKeyContainer[0].localizationIndex.Count; i++)
                        {
                            string key = set_2_Panel.GetComponent<ListHandler>().localizationKeyContainer[0].localizationIndex[i];
                            set_2_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                            set_2_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                        }
                        
                        
                        AcrivateNumberOfButtons(4, set_2_Buttons, set_1_Panel, set_2_Panel);
                        
                        break;
                }
                break;

            case "2":
                
                switch (HierarchyManager.set_2)
                {
                    case "1":
                        switch (HierarchyManager.set_3)
                        {
                            case "1":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        //final
                                        break;
                                    case "2":
                                        //final
                                        break;
                                    case "3":
                                        //final
                                        break;
                                    case "4":
                                        //final
                                        break;
                                    case "5":
                                        //final
                                        break;
                                    case "6":
                                        //final
                                        break;
                                    case "7":
                                        //final
                                        break;
                                    default:
                                        for (int i = 0; i < set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[11].localizationIndex.Count; i++)
                                        {
                                            string key = set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[11].localizationIndex[i];
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                        }
                                        AcrivateNumberOfButtons(7, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            case "2":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        //final
                                        break;
                                    case "2":
                                        //final
                                        break;
                                    case "3":
                                        //final
                                        break;
                                    case "4":
                                        //final
                                        break;
                                    case "5":
                                        //final
                                        break;
                                    case "6":
                                        //final
                                        break;
                                    default:
                                        for (int i = 0; i < set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[12].localizationIndex.Count; i++)
                                        {
                                            string key = set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[12].localizationIndex[i];
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                        }
                                        AcrivateNumberOfButtons(6, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            default:
                                for (int i = 0; i < set_3_Panel.GetComponent<ListHandler>().localizationKeyContainer[4].localizationIndex.Count; i++)
                                {
                                    string key = set_3_Panel.GetComponent<ListHandler>().localizationKeyContainer[4].localizationIndex[i];
                                    set_3_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                    set_3_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                }
                                AcrivateNumberOfButtons(2, set_3_Buttons, set_2_Panel, set_3_Panel);
                                break;
                        }
                        break;

                    case "2":
                        switch (HierarchyManager.set_3)
                        {
                            case "1":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        //final
                                        break;
                                    case "2":
                                        //final
                                        break;
                                    case "3":
                                        //final
                                        break;
                                    case "4":
                                        //final
                                        break;
                                    case "5":
                                        //final
                                        break;
                                    case "6":
                                        //final
                                        break;
                                    case "7":
                                        //final
                                        break;
                                    case "8":
                                        //final
                                        break;
                                    case "9":
                                        //final
                                        break;
                                    case "10":
                                        //final
                                        break;
                                    case "11":
                                        //final
                                        break;
                                    case "12":
                                        //final
                                        break;
                                    case "13":
                                        //final
                                        break;
                                    case "14":
                                        //final
                                        break;
                                    default:
                                        for (int i = 0; i < set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[13].localizationIndex.Count; i++)
                                        {
                                            string key = set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[13].localizationIndex[i];
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                        }
                                        AcrivateNumberOfButtons(14, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            default:
                                for (int i = 0; i < set_3_Panel.GetComponent<ListHandler>().localizationKeyContainer[5].localizationIndex.Count; i++)
                                {
                                    string key = set_3_Panel.GetComponent<ListHandler>().localizationKeyContainer[5].localizationIndex[i];
                                    set_3_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                    set_3_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                }
                                AcrivateNumberOfButtons(1, set_3_Buttons, set_2_Panel, set_3_Panel);
                                break;
                        }
                        break;

                    case "3":
                        switch (HierarchyManager.set_3)
                        {
                            case "1":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        switch (HierarchyManager.set_5)
                                        {
                                            case "1":
                                                //final
                                                break;
                                            case "2":
                                                //final
                                                break;
                                            case "3":
                                                //final
                                                break;
                                            default:
                                                AcrivateNumberOfButtons(3, set_5_Buttons, set_4_Panel, set_5_Panel);
                                                break;
                                        }
                                        break;
                                    case "2":
                                        switch (HierarchyManager.set_5)
                                        {
                                            case "1":
                                                //final
                                                break;
                                            case "2":
                                                //final
                                                break;
                                            default:
                                                AcrivateNumberOfButtons(2, set_5_Buttons, set_4_Panel, set_5_Panel);
                                                break;
                                        }
                                        break;
                                    case "3":
                                        //final
                                        break;
                                    default:
                                        for (int i = 0; i < set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[14].localizationIndex.Count; i++)
                                        {
                                            string key = set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[14].localizationIndex[i];
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                        }
                                        AcrivateNumberOfButtons(3, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            case "2":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        //final
                                        break;
                                    case "2":
                                        //final
                                        break;
                                    case "3":
                                        //final
                                        break;
                                    case "4":
                                        //final
                                        break;
                                    case "5":
                                        //final
                                        break;
                                    case "6":
                                        //final
                                        break;
                                    case "7":
                                        //final
                                        break;
                                    case "8":
                                        //final
                                        break;
                                    case "9":
                                        //final
                                        break;
                                    case "10":
                                        //final
                                        break;
                                    case "11":
                                        //final
                                        break;
                                    case "12":
                                        //final
                                        break;
                                    case "13":
                                        //final
                                        break;
                                    case "14":
                                        //final
                                        break;
                                    case "15":
                                        //final
                                        break;
                                    case "16":
                                        //final
                                        break;
                                    case "17":
                                        //final
                                        break;
                                    case "18":
                                        //final
                                        break;
                                    case "19":
                                        //final
                                        break;
                                    default:
                                        for (int i = 0; i < set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[15].localizationIndex.Count; i++)
                                        {
                                            string key = set_4_Panel.GetComponent<ListHandler>().localizationKeyContainer[15].localizationIndex[i];
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                            set_4_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                        }
                                        AcrivateNumberOfButtons(19, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            default:
                                for (int i = 0; i < set_3_Panel.GetComponent<ListHandler>().localizationKeyContainer[6].localizationIndex.Count; i++)
                                {
                                    string key = set_3_Panel.GetComponent<ListHandler>().localizationKeyContainer[6].localizationIndex[i];
                                    set_3_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                                    set_3_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                                }
                                AcrivateNumberOfButtons(2, set_3_Buttons, set_2_Panel, set_3_Panel);
                                break;
                        }
                        break;

                    default:
                        for (int i = 0; i < set_2_Panel.GetComponent<ListHandler>().localizationKeyContainer[1].localizationIndex.Count; i++)
                        {
                            string key = set_2_Panel.GetComponent<ListHandler>().localizationKeyContainer[1].localizationIndex[i];
                            set_2_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                            set_2_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                        }
                        AcrivateNumberOfButtons(3, set_2_Buttons, set_1_Panel, set_2_Panel);
                        break;
                }
                break;

            case "3":
                
                switch (HierarchyManager.set_2)
                {
                    case "1":
                        switch (HierarchyManager.set_3)
                        {
                            case "1":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        //final
                                        break;
                                    case "2":
                                        //final
                                        break;
                                    case "3":
                                        //final
                                        break;
                                    case "4":
                                        //final
                                        break;
                                    default:
                                        AcrivateNumberOfButtons(4, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            case "2":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        //final
                                        break;
                                    case "2":
                                        //final
                                        break;
                                    case "3":
                                        //final
                                        break;
                                    case "4":
                                        //final
                                        break;
                                    case "5":
                                        //final
                                        break;
                                    default:
                                        AcrivateNumberOfButtons(5, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            case "3":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        //final
                                        break;
                                    case "2":
                                        //final
                                        break;
                                    case "3":
                                        //final
                                        break;
                                    case "4":
                                        //final
                                        break;
                                    case "5":
                                        //final
                                        break;
                                    default:
                                        AcrivateNumberOfButtons(5, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            case "4":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        //final
                                        break;
                                    case "2":
                                        //final
                                        break;
                                    default:
                                        AcrivateNumberOfButtons(2, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            case "5":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        //final
                                        break;
                                    default:
                                        AcrivateNumberOfButtons(1, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            case "6":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        //final
                                        break;
                                    default:
                                        AcrivateNumberOfButtons(1, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            case "7":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        //final
                                        break;
                                    default:
                                        AcrivateNumberOfButtons(1, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            default:
                                AcrivateNumberOfButtons(7, set_3_Buttons, set_2_Panel, set_3_Panel);
                                break;
                        }
                        break;

                    case "2":
                        switch (HierarchyManager.set_3)
                        {
                            case "1":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        switch (HierarchyManager.set_5)
                                        {
                                            case "1":
                                                //final
                                                break;
                                            case "2":
                                                //final
                                                break;
                                            default:
                                                AcrivateNumberOfButtons(2, set_5_Buttons, set_4_Panel, set_5_Panel);
                                                break;
                                        }
                                        break;
                                    case "2":
                                        switch (HierarchyManager.set_5)
                                        {
                                            case "1":
                                                //final
                                                break;
                                            case "2":
                                                //final
                                                break;
                                            case "3":
                                                //final
                                                break;
                                            default:
                                                AcrivateNumberOfButtons(3, set_5_Buttons, set_4_Panel, set_5_Panel);
                                                break;
                                        }
                                        break;
                                    default:
                                        AcrivateNumberOfButtons(2, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            case "2":
                                switch (HierarchyManager.set_4)
                                {
                                    case "1":
                                        //final
                                        break;
                                    case "2":
                                        //final
                                        break;
                                    case "3":
                                        //final
                                        break;
                                    case "4":
                                        //final
                                        break;
                                    default:
                                        AcrivateNumberOfButtons(4, set_4_Buttons, set_3_Panel, set_4_Panel);
                                        break;
                                }
                                break;

                            case "3":
                                //final
                                break;

                            

                            default:
                                AcrivateNumberOfButtons(3, set_3_Buttons, set_2_Panel, set_3_Panel);
                                break;
                        }
                        break;

                    default:
                        for (int i = 0; i < set_2_Panel.GetComponent<ListHandler>().localizationKeyContainer[2].localizationIndex.Count; i++)
                        {
                            string key = set_2_Panel.GetComponent<ListHandler>().localizationKeyContainer[2].localizationIndex[i];
                            set_2_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                            set_2_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                        }
                        AcrivateNumberOfButtons(2, set_2_Buttons, set_1_Panel, set_2_Panel);
                        break;
                }
                break;

            case "4":
                
                switch (HierarchyManager.set_2)
                {
                    case "1":
                        switch (HierarchyManager.set_3)
                        {
                           //final
                        }
                        break;

                    default:
                        for (int i = 0; i < set_2_Panel.GetComponent<ListHandler>().localizationKeyContainer[3].localizationIndex.Count; i++)
                        {
                            string key = set_2_Panel.GetComponent<ListHandler>().localizationKeyContainer[3].localizationIndex[i];
                            set_2_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = LocalizationManager.Localize(key);
                            set_2_Buttons[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().GetComponent<LocalizedText>().LocalizationKey = key;
                        }
                        AcrivateNumberOfButtons(1, set_2_Buttons, set_1_Panel, set_2_Panel);
                        break;
                }

                break;



        }
    }

    public void BackForSet_1()
    {
        set_1 = "";
        set_2 = "";
        set_3 = "";
        set_4 = "";
        set_5 = "";
        set_2_Panel.SetActive(false);
        foreach (GameObject btn in set_2_Buttons)
        {
            btn.gameObject.SetActive(false);
        }
        set_1_Panel.SetActive(true);
    }

    public void BackForSet_2()
    {
        set_2 = "";
        set_3 = "";
        set_4 = "";
        set_5 = "";
        set_3_Panel.SetActive(false);
        foreach (GameObject btn in set_3_Buttons)
        {
            btn.gameObject.SetActive(false);
        }
        set_2_Panel.SetActive(true);
    }

    public void BackForSet_3()
    {
        set_3 = "";
        set_4 = "";
        set_5 = "";
        set_4_Panel.SetActive(false);
        foreach (GameObject btn in set_4_Buttons)
        {
            btn.gameObject.SetActive(false);
        }
        set_3_Panel.SetActive(true);
    }

    public void BackForSet_4()
    {
        set_4 = "";
        set_5 = "";
        set_5_Panel.SetActive(false);
        foreach (GameObject btn in set_5_Buttons)
        {
            btn.gameObject.SetActive(false);
        }
        set_4_Panel.SetActive(true);
    }


}
