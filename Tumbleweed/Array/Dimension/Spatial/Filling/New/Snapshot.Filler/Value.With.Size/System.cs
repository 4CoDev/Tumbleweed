using Array = Tumbleweed.Array;
using Point = Tumbleweed.Point.Spatial;
using System = System;
using SystemSnapshot = Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Snapshot;

namespace Tumbleweed.Array.Dimension.Spatial.Filling.New.Snapshot.Filler.Value.With.Size;

public sealed class System<T> : Array::Envelope<T>
{
	public System
	(
		Point::Any<System::Int32> size,
		T filler
	) : base
	(
		new Array::Dimension.Spatial.From.System<T>(
			new SystemSnapshot::Filler.Value.With.Size.System<T>(
				size,
				filler))
	)
	{
	}
}