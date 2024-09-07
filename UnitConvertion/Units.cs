using System;

public class Convertor
{
	private EUnits _from;
	private EUnits _to;

    public Convertor From(EUnits unit) { _from = unit; return this; }
	public Convertor To(EUnits unit) { _to = unit; return this; }

	public double Convert(double value) 
	{
		return ConvertFrom_At(ConvertTo_AT(value, _from), _to);
	}

	private double ConvertFrom_At(double value, EUnits unit) 
	{
		switch (unit)
		{
			case EUnits.AT:
				return value;
			case EUnits.KGS_CM2:
				return value;
			case EUnits.N_M2:
				return value * 9.8 * 10_000;
            case EUnits.PA:
                return value * 9.81 * 10_000;
            case EUnits.BAR:
                return value * 0.981;
            case EUnits.MMRTST:
                return value * 735.56;
			default:
				return 0.00;
        }
    }

	private static double ConvertTo_AT(double value, EUnits unit)
	{
		return unit switch
		{
			EUnits.AT => value,
			EUnits.KGS_CM2 => value,
			EUnits.N_M2 => value / (9.8 * 10_000),
			EUnits.PA => value / (9.81 * 10_000),
			EUnits.BAR => value / (0.981),
			EUnits.MMRTST => value / (735.56),
			_ => 0.00,
		};
	}
}

public enum EUnits 
{
	AT = 0, 
	KGS_CM2 = 1,
	N_M2 = 2,
	PA = 3,
	BAR = 4,
	MMRTST = 5,
}

public static class EUnitsExtensions
{
	public static string EnumToString(this EUnits unit) 
	{
		return unit switch
		{
            EUnits.AT => "Ат",
            EUnits.KGS_CM2 => "кгс/см^2",
            EUnits.N_M2 => "Н/м^2",
            EUnits.PA => "ПА",
            EUnits.BAR => "Бар",
            EUnits.MMRTST => "мм рт ст",
            _ => "",
        };
	}
}

public static class StringExtensions
{
    public static EUnits ToUnit(this String unit)
    {
        return unit switch
        {
            "Ат" => EUnits.AT,
            "кгс/см^2" => EUnits.KGS_CM2,
            "Н/м^2" => EUnits.N_M2,
            "ПА" => EUnits.PA,
            "Бар" => EUnits.BAR,
            "мм рт ст" => EUnits.MMRTST,
			_ => throw new Exception("Invalid arg"),
        };
    }
}