using Tumbleweed.Property.Output.Function.Result;

namespace Tumbleweed.Mathematics.Vector.Planar.Generic.Coordinate.X;

public sealed class Normal<T> : Tumbleweed.Property.Output.Envelope<T>
{
	public Normal(Any<T> point) : base
	(
		new Actual<T>(
			() => point.X)
	)
	{
	}
}