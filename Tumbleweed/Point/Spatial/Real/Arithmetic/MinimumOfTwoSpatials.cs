using Tumbleweed.Number.Real;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic;

public sealed class MinimumOfTwoPoints : Any<Any>
{
	public MinimumOfTwoPoints
	(
		Any<Any> first,
		Any<Any> second
	)
	{
		this.first = first;
		this.second = second;
	}
	
	public Any X => first.X;

	public Any Y => throw new NotImplementedException();

	public Any Z => throw new NotImplementedException();

	private readonly Any<Any> first, second;
}