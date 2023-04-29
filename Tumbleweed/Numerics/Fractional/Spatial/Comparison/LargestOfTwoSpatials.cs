using Tumbleweed.Numerics.Fractional.Comparison;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Comparison;

public sealed class LargestOfTwoSpatials : ISpatial<IFractional>
{
	
	public LargestOfTwoSpatials
	(
		ISpatial<IFractional> first,
		ISpatial<IFractional> second
	)
	{
		this.first = first;
		this.second = second;
	}

	public IFractional X =>
		new LargestOfFractionals(first.X, second.X);

	public IFractional Y =>
		new LargestOfFractionals(first.Y, second.Y);

	public IFractional Z =>
		new LargestOfFractionals(first.Z, second.Z);

	private readonly ISpatial<IFractional> first, second;
}