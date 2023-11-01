using Property = Tumbleweed.Property.Output;

namespace Tumbleweed.Mathematics.Vector.Spatial.Generic.Coordinate.Y.Lazy;

public sealed class One<T> : Property::Envelope<T>
{
	public One(Any<T> point) : base
	(
		new Property::Lazy<T>(
			new Actual.One<T>(point))
	)
	{
	}
}