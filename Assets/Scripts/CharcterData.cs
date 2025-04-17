using UnityEngine;

[CreateAssetMenu(menuName = "Character")]
public class CharacterData : ScriptableObject
{
    public string characterName;
    public string description;
    public Sprite portrait;
    public int strength;
    public int intelligence;
    public int charisma;
    public int knowledge;
}
