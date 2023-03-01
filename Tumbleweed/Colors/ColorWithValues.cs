using Tumbleweed.Numerics.Fractional;

namespace Tumbleweed.Colors;

public sealed class ColorWithValues : IColor
{
	public ColorWithValues
	(
		IFractional red,
		IFractional green,
		IFractional blue
	)
	{
		Red = red;
		Green = green;
		Blue = blue;
	}
	
	public IFractional Red { get; }
	
	public IFractional Green { get; }
	
	public IFractional Blue { get; }
}