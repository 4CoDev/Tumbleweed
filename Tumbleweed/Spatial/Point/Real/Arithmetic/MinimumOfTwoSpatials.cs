using Tumbleweed.Number.Real;

namespace Tumbleweed.Spatial.Point.Real.Arithmetic;

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