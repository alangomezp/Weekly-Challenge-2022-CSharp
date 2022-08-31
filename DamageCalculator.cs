namespace RetoNo_35;

public class DamageCalculator
{
    private const int DamageBase = 50;
    private readonly double _damageRate;
    private readonly double _effectiveness;
    public string? AtkType { get; }
    public string? DfsType { get; }
    
    public DamageCalculator(string? atkType, string? dfsType, int atk, int dfs)
    {
        AtkType = atkType;
        DfsType = dfsType;
        _damageRate = (double)atk / dfs;
        _effectiveness = this.CalculateEffectiveness();
    }

    public double CalcDamage() => DamageBase * _damageRate * _effectiveness;
}