using Property = Tumbleweed.Property.Output;
using Nullable = Tumbleweed.Property.Nullable;

using System = System;
using Source = Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Source;

namespace Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Snapshot.Filler.Null.Object.With.Size;

public sealed class System<T> : Property::Envelope<Nullable::Any<T>[,,]>
{
	public System
	(
		Mathematics.Vector.Spatial.Generic.Any<System::Int32> size
	) : base
	(
		new Property::Lazy<Nullable::Any<T>[,,]>(
			new Source::Filler.Null.Object.With.Size.System<T>(size))
	)
	{
	}
}