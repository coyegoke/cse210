public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _completedCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, int completedCount = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _completedCount = completedCount;
    }

    public override int RecordEvent()
    {
        if (_completedCount < _targetCount)
        {
            _completedCount++;
            return _completedCount == _targetCount ? Points + _bonus : Points;
        }
        return 0;
    }

    public override bool IsComplete() => _completedCount >= _targetCount;

    public override string GetStatus() => $"[{(IsComplete() ? "X" : " ")}] {Name} ({Description}) - Completed in {_completedCount}/{_targetCount} times";

    public override string GetSaveString() => $"ChecklistGoal|{Name}|{Description}|{Points}|{_targetCount}|{_bonus}|{_completedCount}";
}