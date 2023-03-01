using Tumbleweed.Numerics.Fractional;

namespace Tumbleweed.Colors;

public sealed class ColorEnvelope : IColor
{
	public ColorEnvelope(IColor color)
	{
		this.color = color;
	}

	public IFractional Red
	{
		get => color.Red;
	}

	public IFractional Green
	{
		get => color.Green;
	}

	public IFractional Blue
	{
		get => color.Blue;
	}
	
	private readonly IColor color;
}