using Property = Tumbleweed.Property.Output;
using Vector = Tumbleweed.Mathematics.Vector.Spatial;
using System = System;
using Source = Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Source;

namespace Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Snapshot.Filler.Value.With.Size;

public sealed class System<T> : Property::Envelope<T[,,]>
{
	public System
	(
		Vector::Generic.Any<System::Int32> size,
		T filler
	) : base
	(
		new Property::Lazy<T[,,]>(
			new Source::Filler.Value.With.Size.System<T>(size, filler))
	)
	{
	}
}