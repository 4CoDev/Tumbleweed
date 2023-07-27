using Tumbleweed.Number.Integer;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Real.With;

public sealed class Members : Any
{
	public Members
	(
		Integer.Any mantissa,
		Integer.Any @base,
		Integer.Any exponent
	)
	{
		Mantissa = mantissa;
		Base = @base;
		Exponent = exponent;
	}
	
	public Integer.Any Mantissa { get; }
	
	public Integer.Any Base { get; }
	
	public Integer.Any Exponent { get; }
}