using Property = Tumbleweed.Property.Output;
using Option = Tumbleweed.Property.Option;
using Vector = Tumbleweed.Mathematics.Vector.Spatial;
using System = System;
using Source = Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Source;

namespace Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Source.Filler.Null.Object.With.Size;

public sealed class System<T> : Property::Envelope<Option::Any<T>[,,]>
{
	public System
	(
		Vector::Generic.Any<System::Int32> size
	) : base
	(
		new Source::Filler.Value.With.Size.System<Option::Any<T>>(
			size,
			new Option::Null<T>())
	)
	{
	}
}