using Tumbleweed.Numbers.Real.Comparison;
using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Comparison;

public sealed class LargestOfTwoSpatials : ISpatial<IReal>
{
	
	public LargestOfTwoSpatials
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
	)
	{
		this.first = first;
		this.second = second;
	}

	public IReal X =>
		new LargestOfReals(first.X, second.X);

	public IReal Y =>
		new LargestOfReals(first.Y, second.Y);

	public IReal Z =>
		new LargestOfReals(first.Z, second.Z);

	private readonly ISpatial<IReal> first, second;
}