using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterSelectionManager : MonoBehaviour
{
    public CharacterData[] characters;

    [Header("Selected Character UI")]
    public Image selectedPortrait;
    public TextMeshProUGUI selectedName;
    public TextMeshProUGUI selectedDescriptionText;
    public TextMeshProUGUI selectedStrengthText;
    public TextMeshProUGUI selectedIntelligenceText;
    public TextMeshProUGUI selectedCharismaText;
    public TextMeshProUGUI selectedKnowledgeText;


    public void SelectCharacter(int index)
    {
        CharacterData c = characters[index];

        selectedPortrait.sprite = c.portrait;
        selectedName.text = c.characterName;
        selectedDescriptionText.text = c.description;
        selectedStrengthText.text = "STR: " + c.strength;
        selectedIntelligenceText.text = "INT: " + c.intelligence;
        selectedCharismaText.text = "CHA: " + c.charisma;
        selectedKnowledgeText.text = "KNO: " + c.knowledge;


    }
}
