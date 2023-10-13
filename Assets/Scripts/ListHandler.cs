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

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    



    

    

    

    //public void LoadNextSectionImagesSet(int number)
    //{
    //    switch (number)
    //    {
    //        case 1:
    //            for (int j = 0; j < countInstance; j++)
    //            {
    //                sectionImages[j].sprite = refImageContainer[0].refImages[j];
    //            }
    //            break;

    //        case 2:
    //            for (int j = 0; j < countInstance; j++)
    //            {
    //                sectionImages[j].sprite = refImageContainer[1].refImages[j];
    //            }
    //            break;

    //        case 3:
    //            for (int j = 0; j < countInstance; j++)
    //            {
    //                sectionImages[j].sprite = refImageContainer[2].refImages[j];
    //            }
    //            break;

    //        case 4:
    //            for (int j = 0; j < countInstance; j++)
    //            {
    //                sectionImages[j].sprite = refImageContainer[3].refImages[j];
    //            }
    //            break;
    //    }
        
    //}

    

}
