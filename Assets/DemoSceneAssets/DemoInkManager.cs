using UnityEngine;
using UnityEditor;
using Ink.Runtime;
using System;
using UnityEngine.UI;
using TMPro;

public class DemoInkManager : MonoBehaviour
{

    [SerializeField]
    private TextAsset inkJSONAsset = null;
    public Story story;

    [SerializeField]
    private Canvas canvas;
    [SerializeField]
    private RectTransform convoPanelPrefab = null;
    private RectTransform convoPanelObj;

    // UI Prefabs
    [SerializeField]
    private TMP_Text spkrNamePrefab = null;
    [SerializeField]
    private TMP_Text spkrTextPrefab = null;
    [SerializeField]
    private Button buttonPrefab = null;

    public static event Action<Story> OnCreateStory;

    // Start is called before the first frame update
    private void Awake()
    {
        RemoveChildren(); //clears all UI story elements
        StartStory();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartStory()
    {
        story = new Story(inkJSONAsset.text); //assigns Story varible to text of Ink JSON asset
        if (OnCreateStory != null) OnCreateStory(story);
        RefreshView();
    }
    
    void RefreshView()
    {
        RemoveChildren();
        while (story.canContinue)
        {
            string text = story.Continue(); //Continue gets the next line of the story
            text = text.Trim(); //removes extra white space
            CreateContentView(text); //display on screen
        }

        if (story.currentChoices.Count > 0)
        {
            for (int i = 0; i < story.currentChoices.Count; i++)
            {
                Choice choice = story.currentChoices[i];
                Button button = CreateChoiceView(choice.text.Trim());
                button.onClick.AddListener(delegate
                {
                    OnClickChoiceButton(choice);
                });
            }
        }
        else
        {
            Button choice = CreateChoiceView("End \n Restart?");
            choice.onClick.AddListener(delegate {
                StartStory();
            });
        }
    }
    
    void OnClickChoiceButton(Choice choice)
    {
        story.ChooseChoiceIndex(choice.index);
        RefreshView();
    }
    
    void CreateContentView(string text)
    {
        RectTransform convoPanel = Instantiate(convoPanelPrefab) as RectTransform;
        convoPanel.transform.SetParent(canvas.transform, false);
        convoPanelObj = convoPanel;
        //TMP_Text speakerName = Instantiate(spkrNamePrefab) as TMP_Text;
        TMP_Text speakerText = Instantiate(spkrTextPrefab) as TMP_Text;
        speakerText.text = text;
        speakerText.transform.SetParent(convoPanel, false);
        speakerText.transform.SetSiblingIndex(1);
    }
    
    Button CreateChoiceView(string text)
    {
        Button choice = Instantiate(buttonPrefab) as Button;
        if (convoPanelObj != null)
        {
            choice.transform.SetParent(convoPanelObj, false);
            choice.transform.SetSiblingIndex(2);
        }

        TMP_Text choiceText = choice.GetComponentInChildren<TMP_Text>();
        choiceText.text = text;

        VerticalLayoutGroup choiceLayoutGroup = choice.GetComponentInParent<VerticalLayoutGroup>();
        //choiceLayoutGroup.childForceExpandWidth = true;
        //choiceLayoutGroup.childForceExpandHeight = false;

        return choice;
    }

    void RemoveChildren()
    {
        int childCount = canvas.transform.childCount;
        for (int i = childCount -1; i>= 0; i--)
        {
            Destroy(canvas.transform.GetChild(i).gameObject);
        }
    }
}
