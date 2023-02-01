using Tumbleweed.Numerics.Integers;

namespace Tumbleweed.Numerics.Decimals;

public sealed class DecimalWithValues : IDecimal
{
	public DecimalWithValues(IInteger mantissa, IInteger exponent)
	{
		Mantissa = mantissa;
		Exponent = exponent;
	}
	
	public IInteger Mantissa { get; }
	
	public IInteger Exponent { get; }
}