using Tumbleweed.Numerics.Integers;

namespace Tumbleweed.Numerics.Decimals;

public interface IDecimal
{
	IInteger Mantissa { get; }
	
	IInteger Exponent { get; }
}