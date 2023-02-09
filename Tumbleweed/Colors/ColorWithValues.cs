using Tumbleweed.Numerics.Decimals;

namespace Tumbleweed.Colors;

public sealed class ColorWithValues : IColor
{
	public ColorWithValues
	(
		IDecimal red,
		IDecimal green,
		IDecimal blue
	)
	{
		Red = red;
		Green = green;
		Blue = blue;
	}
	
	public IDecimal Red { get; }
	
	public IDecimal Green { get; }
	
	public IDecimal Blue { get; }
}