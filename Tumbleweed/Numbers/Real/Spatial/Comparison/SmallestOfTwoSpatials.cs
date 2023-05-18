using Tumbleweed.Numbers.Real.Comparison;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Comparison;

public sealed class SmallestOfTwoPoints : IPoint<IReal>
{
	public SmallestOfTwoPoints
	(
		IPoint<IReal> first,
		IPoint<IReal> second
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

	private readonly IPoint<IReal> first, second;
}