using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HierarchyManager : MonoBehaviour
{
    public static string set_1;

    public static string set_2;

    private int countInstance;

    [SerializeField] private GameObject set_1_Panel;
    [SerializeField] private GameObject set_2_Panel;
    [SerializeField] private GameObject set_3_Panel;
    [SerializeField] private GameObject set_4_Panel;

    [SerializeField] private GameObject[] set_2_Buttons;

    // Start is called before the first frame update
    void Start()
    {
        set_1 = "";
        set_2 = "";
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(HierarchyManager.set_1 + "---------" + HierarchyManager.set_2);
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

    public void AcrivateNumberOfButtons(int count, GameObject[] arr)
    {
        countInstance = count;
        set_1_Panel.SetActive(false);
        set_2_Panel.SetActive(true);

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

                        break;

                    case "2":

                        break;

                    case "3":

                        break;

                    case "4":

                        break;

                    default:
                        AcrivateNumberOfButtons(5, set_2_Buttons);
                        break;


                }
                break;

            case "2":
                
                switch (HierarchyManager.set_2)
                {
                    case "1":

                        break;

                    case "2":

                        break;

                    case "3":

                        break;

                    case "4":

                        break;

                    default:
                        AcrivateNumberOfButtons(10, set_2_Buttons);
                        break;
                }
                break;

            case "3":
                
                switch (HierarchyManager.set_2)
                {
                    case "1":

                        break;

                    case "2":

                        break;

                    case "3":

                        break;

                    case "4":

                        break;

                    default:
                        AcrivateNumberOfButtons(1, set_2_Buttons);
                        break;
                }
                break;

            case "4":
                
                switch (HierarchyManager.set_2)
                {
                    case "1":

                        break;

                    case "2":

                        break;

                    case "3":

                        break;

                    case "4":

                        break;

                    default:
                        AcrivateNumberOfButtons(3, set_2_Buttons);
                        break;
                }

                break;



        }
    }

    public void Back()
    {
        set_2_Panel.SetActive(false);
        foreach (GameObject btn in set_2_Buttons)
        {
            btn.gameObject.SetActive(false);
        }
        set_1_Panel.SetActive(true);
    }


}
