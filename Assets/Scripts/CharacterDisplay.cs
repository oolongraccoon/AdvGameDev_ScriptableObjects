using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterDisplay : MonoBehaviour
{
    public CharacterData characterData;

    public Image portraitImage;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI strengthText;
    public TextMeshProUGUI intelligenceText;
    public TextMeshProUGUI charismaText;
    public TextMeshProUGUI knowledgeText;
    public Button selectButton;

    public CharacterSelectionManager selectionManager;
    public int characterIndex;

    void Start()
    {
        if (characterData != null)
        {
            portraitImage.sprite = characterData.portrait;
            nameText.text = characterData.characterName;
            descriptionText.text = characterData.description;

            strengthText.text = "STR: " + characterData.strength;
            intelligenceText.text = "INT: " + characterData.intelligence;
            charismaText.text = "CHA: " + characterData.charisma;
            knowledgeText.text = "KNO: " + characterData.knowledge;
        }

        if (selectButton != null && selectionManager != null)
        {
            selectButton.onClick.AddListener(() =>
            {
                selectionManager.SelectCharacter(characterIndex);
            });
        }
    }
}
