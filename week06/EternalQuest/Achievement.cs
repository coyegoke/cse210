public class Achievement
{
    public string Title { get; }
    public string Description { get; }
    public int PointsRequired { get; }

    public Achievement(string title, string description, int pointsRequired)
    {
        Title = title;
        Description = description;
        PointsRequired = pointsRequired;
    }

    public bool IsUnlocked(int currentPoints) => currentPoints >= PointsRequired;

    public override string ToString() => $"🏅 {Title}: {Description} (This is unlocked at {PointsRequired} pts)";
}
