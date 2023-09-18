using Scalar = Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Point.Spatial.Generic.With.Coordinate.Definition;

public sealed class Uniform<T> : Envelope<T>
{
	public Uniform(T coordinate) : this
	(
		new Scalar::With.Value<T>(coordinate)
	)
	{
	}
	
	public Uniform(Scalar::Any<T> coordinate) : base
	(
		new Unique<T>(
			coordinate,
			coordinate,
			coordinate)
	)
	{
	}
}