using Property = Tumbleweed.Property.Output;

using System = System;
using Source = Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Source;

namespace Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Snapshot.Filler.Property.Value.With.Size;

public sealed class System<T> : Property::Envelope<T[,,]>
{
	public System
	(Mathematics.Vector.Spatial.Generic.Any<System::Int32> size,
		Property::Any<T> filler
	) : base
	(
		new Property::Lazy<T[,,]>(
			new Source::Filler.Property.Value.With.Size.System<T>(size, filler))
	)
	{
	}
}