using UnityEngine;

public class FantasySpellbook : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        void CastSpell(string spellName)
        {
            Debug.Log("Casting spell: " + spellName);
            int GetManaCost(string spellName)
            {

                return 10;
            }

            int manaCost = GetManaCost("Fireball");
            Debug.Log("Mana cost for Fireball: " + manaCost);
            bool CanCast(string spellName, int currentMana)
            {
                int manaCost = GetManaCost(spellName);
                return currentMana >= manaCost;
            }

            int playerMana = 50;
            if (CanCast("Fireball", playerMana))
            {
                CastSpell("Fireball");
                playerMana -= manaCost;
                Debug.Log("Remaining mana: " + playerMana);
            }
            else
            {
                Debug.Log("Not enough mana to cast Fireball.");
            }
        }

        CastSpell("Fireball");
        Debug.Log("Spell effect for Fireball: " + GetSpellEffect("Fireball"));
        string GetSpellEffect(string spellName)
        {
            if (spellName == "Fireball")
            {
                return "Deals fire damage to a single target.";
            }
            else if (spellName == "Heal")
            {
                return "Restores health to a single target.";
            }
            else
            {
                return "Unknown spell.";
            }
        }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
