namespace Tumbleweed.Mathematics.Vector.Planar.Generic.Coordinate.X;

public sealed class Lazy<T> : Tumbleweed.Property.Output.Envelope<T>
{
	public Lazy(Any<T> point) : base
	(
		new Tumbleweed.Property.Output.Lazy<T>(
			new Normal<T>(point))
	)
	{
	}
}