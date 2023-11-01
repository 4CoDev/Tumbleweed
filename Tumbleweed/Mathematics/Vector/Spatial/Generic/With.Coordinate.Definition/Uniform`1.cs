using Property = Tumbleweed.Property.Output;

namespace Tumbleweed.Mathematics.Vector.Spatial.Generic.With.Coordinate.Definition;

public sealed class Uniform<T> : Envelope<T>
{
	public Uniform(T coordinate) : this
	(
		new Property::With.Value<T>(coordinate)
	)
	{
	}
	
	public Uniform(Property::Any<T> coordinate) : base
	(
		new Unique<T>(
			coordinate,
			coordinate,
			coordinate)
	)
	{
	}
}