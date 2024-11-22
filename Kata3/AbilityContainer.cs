namespace Kata3;

public class AbilityContainer<T>
{
    private List<T> _abilities = new ();

    public void AddAbility(T name, T effect)
    {
        Console.WriteLine($"- Added {name}: {effect}");
        _abilities.Add(name);
    }

    public void RemoveAbility( T name, T effect)
    {
        Console.WriteLine($"- Removed {name}: {effect}");
        _abilities.Remove(name);
    }

    public void ShowAbility()
    {
        foreach (var name in _abilities)
        {
            Console.WriteLine($"- {name}");
        }
    }
}