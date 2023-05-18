using Tumbleweed.Numbers.Real.Comparison;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Comparison;

public sealed class LargestOfTwoPoints : IPoint<IReal>
{
	
	public LargestOfTwoPoints
	(
		IPoint<IReal> first,
		IPoint<IReal> second
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

	private readonly IPoint<IReal> first, second;
}