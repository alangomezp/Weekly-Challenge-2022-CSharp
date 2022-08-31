namespace RetoNo_35;

public static class Effectiveness
{
    public static double CalculateEffectiveness(this DamageCalculator calc)
    {
        const double superEffective = 2;
        const double neutral = 1;
        const double notEffective = 0.5;

        return calc.AtkType switch
        {
            Types.Fire when calc.DfsType == Types.Grass => superEffective,
            Types.Fire when calc.DfsType == Types.Water => notEffective,
            Types.Fire when calc.DfsType == Types.Fire => notEffective,
            Types.Water when calc.DfsType == Types.Fire => superEffective,
            Types.Water when calc.DfsType == Types.Grass => notEffective,
            Types.Water when calc.DfsType == Types.Water => notEffective,
            Types.Grass when calc.DfsType == Types.Water => superEffective,
            Types.Grass when calc.DfsType == Types.Fire => notEffective,
            Types.Grass when calc.DfsType == Types.Grass => notEffective,
            Types.Electric when calc.DfsType == Types.Water => superEffective,
            Types.Electric when calc.DfsType == Types.Grass => notEffective,
            Types.Electric when calc.DfsType == Types.Electric => notEffective,
            _ => neutral
        };
    }
}