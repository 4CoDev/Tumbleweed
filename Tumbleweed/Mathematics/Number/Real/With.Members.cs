using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Integer;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Real.With;

public sealed class Members : Any
{
	public Members
	(
		Mathematics.Number.Integer.Any mantissa,
		Mathematics.Number.Integer.Any @base,
		Mathematics.Number.Integer.Any exponent
	)
	{
		Mantissa = mantissa;
		Base = @base;
		Exponent = exponent;
	}
	
	public Mathematics.Number.Integer.Any Mantissa { get; }
	
	public Mathematics.Number.Integer.Any Base { get; }
	
	public Mathematics.Number.Integer.Any Exponent { get; }
}