using Scalar = Tumbleweed.Scalar.Immutable;
using Nullable = Tumbleweed.Scalar.Nullable;
using Point = Tumbleweed.Point.Spatial;
using System = System;
using Source = Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Source;

namespace Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Snapshot.Filler.Null.Object.With.Size;

public sealed class System<T> : Scalar::Envelope<Nullable::Any<T>[,,]>
{
	public System
	(Point.Spatial.Generic.Any<System::Int32> size
	) : base
	(
		new Scalar::Lazy<Nullable::Any<T>[,,]>(
			new Source::Filler.Null.Object.With.Size.System<T>(size))
	)
	{
	}
}