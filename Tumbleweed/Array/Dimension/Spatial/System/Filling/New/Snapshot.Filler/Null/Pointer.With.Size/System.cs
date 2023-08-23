using Scalar = Tumbleweed.Scalar.Immutable;
using Point = Tumbleweed.Point.Spatial;
using System = System;
using Source = Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Source;

namespace Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Snapshot.Filler.Null.Pointer.With.Size;

public sealed class System<T> : Scalar::Envelope<T[,,]>
{
	public System
	(
		Point::Any<System::Int32> size
	) : base
	(
		new Scalar::Lazy<T[,,]>(
			new Source::Filler.Null.Pointer.With.Size.System<T>(size))
	)
	{
	}
}