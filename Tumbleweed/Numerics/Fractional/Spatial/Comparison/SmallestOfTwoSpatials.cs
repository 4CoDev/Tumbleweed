using Tumbleweed.Numerics.Fractional.Comparison;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Comparison;

public sealed class SmallestOfTwoSpatials : ISpatial<IFractional>
{
	public SmallestOfTwoSpatials
	(
		ISpatial<IFractional> first,
		ISpatial<IFractional> second
	)
	{
		this.first = first;
		this.second = second;
	}

	public IFractional X =>
		new SmallestOfFractionals(first.X, second.X);

	public IFractional Y =>
		new SmallestOfFractionals(first.Y, second.Y);

	public IFractional Z =>
		new SmallestOfFractionals(first.Z, second.Z);

	private readonly ISpatial<IFractional> first, second;
}