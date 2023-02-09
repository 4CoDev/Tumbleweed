using Tumbleweed.Numerics.Decimals;

namespace Tumbleweed.Colors;

public sealed class ColorEnvelope : IColor
{
	public ColorEnvelope(IColor color)
	{
		this.color = color;
	}

	public IDecimal Red
	{
		get => color.Red;
	}

	public IDecimal Green
	{
		get => color.Green;
	}

	public IDecimal Blue
	{
		get => color.Blue;
	}
	
	private readonly IColor color;
}