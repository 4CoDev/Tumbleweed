using Tumbleweed.Numerics.Fractional;

namespace Tumbleweed.Colors;

public sealed class ColorEnvelope : IColor
{
	public ColorEnvelope(IColor color)
	{
		this.color = color;
	}

	public IFractional Red => color.Red;

	public IFractional Green => color.Green;

	public IFractional Blue => color.Blue;

	private readonly IColor color;
}