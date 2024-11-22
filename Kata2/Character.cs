namespace Kata2;

public class Character
{
    private string _name;
    private int _health;
    
    public Character(string name, int health)
    {
        _name = name;
        _health = health;
    }

    public delegate void CharacterAction(Character target, int amount);

    public delegate void Test();

    public event Action<Character> HealthChanged;
    
    public void Attack(Character target, int amount)
    {
        HealthChanged += OnHealthChange;
        
        Console.WriteLine($"{_name} attacks {target._name} for {amount} damage");

        target._health -= amount;
        
        OnHealthChange(target);
    }
    
    public void OnHealthChange(Character target)
    {
        Console.WriteLine($"[Event] {target._name}'s health changed to {target._health}.");
    }
}