using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListHandler : MonoBehaviour
{
    [System.Serializable]
    struct RefImages 
    { 
        public List<Sprite> refImages; 
    }

    [SerializeField] RefImages[] refImageContainer;

    [SerializeField] private GameObject previousPanel;
    [SerializeField] private Button[] sectionButtons;
    [SerializeField] private Image[] sectionImages;

    private int countInstance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AcrivateNextButtonSet(int count)
    {
        countInstance = count;
        previousPanel.SetActive(false);
        this.gameObject.SetActive(true);

        for(int i=0; i<count; i++)
        {
            sectionButtons[i].gameObject.SetActive(true);
        }
    }

    public void LoadNextSectionImagesSet(int number)
    {
        switch (number)
        {
            case 1:
                for (int j = 0; j < countInstance; j++)
                {
                    sectionImages[j].sprite = refImageContainer[0].refImages[j];
                }
                break;

            case 2:
                for (int j = 0; j < countInstance; j++)
                {
                    sectionImages[j].sprite = refImageContainer[1].refImages[j];
                }
                break;

            case 3:
                for (int j = 0; j < countInstance; j++)
                {
                    sectionImages[j].sprite = refImageContainer[2].refImages[j];
                }
                break;

            case 4:
                for (int j = 0; j < countInstance; j++)
                {
                    sectionImages[j].sprite = refImageContainer[3].refImages[j];
                }
                break;
        }
        
    }

    public void Back()
    {
        this.gameObject.SetActive(false);
        previousPanel.SetActive(true);
    }

}
