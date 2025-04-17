using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectionManager : MonoBehaviour
{
    public CharacterData[] characters;

    [Header("Selected Character Panel")]
    public Image selectedPortrait;
    public Text selectedName;
    public Text selectedStats;

    public void SelectCharacter(int index)
    {
        CharacterData c = characters[index];

        selectedPortrait.sprite = c.portrait;
        selectedName.text = c.characterName;
        selectedStats.text = $"STR: {c.strength}  INT: {c.intelligence}\nCHA: {c.charisma}  KNO: {c.knowledge}";
    }
}
