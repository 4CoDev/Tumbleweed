using Tumbleweed.Numbers.Real;

namespace Tumbleweed.Colors;

public sealed class ColorWithValues : IColor
{
	public ColorWithValues
	(
		IReal red,
		IReal green,
		IReal blue
	)
	{
		Red = red;
		Green = green;
		Blue = blue;
	}
	
	public IReal Red { get; }
	
	public IReal Green { get; }
	
	public IReal Blue { get; }
}