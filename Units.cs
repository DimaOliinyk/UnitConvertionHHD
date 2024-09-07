using System;

public class Convertor
{
	private static EUnits? _from = null;
	private static EUnits? _to = null;

	public static Convertor From(EUnits unit) { _from = unit}
	public static Convertor To(EUnits unit) { _to = unit}
	public static double Convert(double value) 
	{
		if (_from is null or _to is null) 
		{
			throw new Exception("Invalid arg");
		}

		return ConvertFrom_At(ConvertTo_AT(value, _from), _to);
	}

	private static double ConvertTo_AT(double value, EUnits unit) 
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
        }
    }

	private static double ConvertFrom_At(double value, EUnits unit)
	{ 
		return unit switch 
		{
            EUnits.AT => value,
            EUnits.KGS_CM2 => value,
			EUnits.N_M2 => value / (9.8 * 10_000),
			EUnits.PA => value / (9.81 * 10_000),
			EUnits.BAR => value / (0.981),
			EUnits.MMRTST => value / (735.56),
		}
	}
}

class enum EUnits 
{
	AT = 0, 
	KGS_CM2 = 1,
	N_M2 = 2,
	PA = 3,
	BAR = 4,
	MMRTST = 5,
}