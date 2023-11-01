using Tumbleweed.Property.Output.Function.Result;

namespace Tumbleweed.Mathematics.Vector.Spatial.Generic.Coordinate.Y.Actual;

public sealed class One<T> : Tumbleweed.Property.Output.Envelope<T>
{
	public One(Any<T> point) : base
	(
		new Actual<T>(
			() => point.Y)
	)
	{
	}
}