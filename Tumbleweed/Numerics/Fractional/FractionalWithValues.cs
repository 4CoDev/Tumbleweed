using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.Signed;

namespace Tumbleweed.Numerics.Fractional;

public sealed class FractionalWithValues : IFractional
{
	public FractionalWithValues
	(
		ISignedInteger mantissa,
		ISignedInteger @base,
		ISignedInteger exponent
	)
	{
		Mantissa = mantissa;
		Base = @base;
		Exponent = exponent;
	}
	
	public ISignedInteger Mantissa { get; }
	
	public ISignedInteger Base { get; }
	
	public ISignedInteger Exponent { get; }
}