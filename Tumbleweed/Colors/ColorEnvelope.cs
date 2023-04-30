using Tumbleweed.Numbers.Real;

namespace Tumbleweed.Colors;

public sealed class ColorEnvelope : IColor
{
	public ColorEnvelope(IColor color)
	{
		this.color = color;
	}

	public IReal Red => color.Red;

	public IReal Green => color.Green;

	public IReal Blue => color.Blue;

	private readonly IColor color;
}