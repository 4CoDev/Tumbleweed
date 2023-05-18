using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics;

public sealed class MinimumOfTwoPoints : IPoint<IReal>
{
	public MinimumOfTwoPoints
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	)
	{
		this.first = first;
		this.second = second;
	}
	
	public IReal X => first.X;

	public IReal Y => throw new NotImplementedException();

	public IReal Z => throw new NotImplementedException();

	private readonly IPoint<IReal> first, second;
}