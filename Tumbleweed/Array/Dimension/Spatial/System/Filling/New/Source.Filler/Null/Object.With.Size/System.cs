using Nullable = Tumbleweed.Property.Nullable;
using Property = Tumbleweed.Property.Output;

using System = System;
using Source = Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Source;

namespace Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Source.Filler.Null.Object.With.Size;

public sealed class System<T> : Property::Envelope<Nullable::Any<T>[,,]>
{
	public System
	(Mathematics.Vector.Spatial.Generic.Any<System::Int32> size
	) : base
	(
		new Source::Filler.Value.With.Size.System<Nullable::Any<T>>(
			size,
			new Nullable::Null<T>())
	)
	{
	}
}