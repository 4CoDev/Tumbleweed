using Array = Tumbleweed.Array;
using Point = Tumbleweed.Point.Spatial;
using System = System;
using Scalar = Tumbleweed.Scalar.Immutable;
using SystemSnapshot = Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Snapshot;

namespace Tumbleweed.Array.Dimension.Spatial.Filling.New.Snapshot.Filler.Scalar.Value.With.Size;

public sealed class System<T> : Array::Envelope<T>
{
	public System
	(
		Point::Any<System::Int32> size,
		Scalar::Any<T> filler
	) : base
	(
		new Array::Dimension.Spatial.From.System<T>(
			new SystemSnapshot::Filler.Scalar.Value.With.Size.System<T>(
				size,
				filler))
	)
	{
	}
}