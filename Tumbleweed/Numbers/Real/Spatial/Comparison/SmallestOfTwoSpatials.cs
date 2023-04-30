using Tumbleweed.Numbers.Real.Comparison;
using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Comparison;

public sealed class SmallestOfTwoSpatials : ISpatial<IReal>
{
	public SmallestOfTwoSpatials
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
	)
	{
		this.first = first;
		this.second = second;
	}

	public IReal X =>
		new SmallestOfReals(first.X, second.X);

	public IReal Y =>
		new SmallestOfReals(first.Y, second.Y);

	public IReal Z =>
		new SmallestOfReals(first.Z, second.Z);

	private readonly ISpatial<IReal> first, second;
}