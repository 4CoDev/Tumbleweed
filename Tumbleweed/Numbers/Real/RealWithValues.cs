using Tumbleweed.Numbers.Integers.Signed;

namespace Tumbleweed.Numbers.Real;

public sealed class RealWithValues : IReal
{
	public RealWithValues
	(
		ISigned mantissa,
		ISigned @base,
		ISigned exponent
	)
	{
		Mantissa = mantissa;
		Base = @base;
		Exponent = exponent;
	}
	
	public ISigned Mantissa { get; }
	
	public ISigned Base { get; }
	
	public ISigned Exponent { get; }
}