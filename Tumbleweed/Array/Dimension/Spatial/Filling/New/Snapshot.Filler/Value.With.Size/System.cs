using Tumbleweed.Array.Dimension.Multi;
using Array = Tumbleweed.Array;

using System = System;
using SystemSnapshot = Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Snapshot;

namespace Tumbleweed.Array.Dimension.Spatial.Filling.New.Snapshot.Filler.Value.With.Size;

public sealed class System<T> : Envelope<T>
{
	public System
	(Mathematics.Vector.Spatial.Generic.Any<System::Int32> size,
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