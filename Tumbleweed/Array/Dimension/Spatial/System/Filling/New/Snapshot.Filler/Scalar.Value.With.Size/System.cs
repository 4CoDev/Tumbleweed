using Scalar = Tumbleweed.Scalar.Immutable;
using Point = Tumbleweed.Point.Spatial;
using System = System;
using Source = Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Source;

namespace Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Snapshot.Filler.Scalar.Value.With.Size;

public sealed class System<T> : Scalar::Envelope<T[,,]>
{
	public System
	(Point.Spatial.Generic.Any<System::Int32> size,
		Scalar::Any<T> filler
	) : base
	(
		new Scalar::Lazy<T[,,]>(
			new Source::Filler.Scalar.Value.With.Size.System<T>(size, filler))
	)
	{
	}
}