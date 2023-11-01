using Tumbleweed.Array.Dimension.Multi;
using Array = Tumbleweed.Array;

using System = System;
using Property = Tumbleweed.Property.Output;
using SystemSnapshot = Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Snapshot;

namespace Tumbleweed.Array.Dimension.Spatial.Filling.New.Snapshot.Filler.Property.Value.With.Size;

public sealed class System<T> : Envelope<T>
{
	public System
	(Mathematics.Vector.Spatial.Generic.Any<System::Int32> size,
		Property::Any<T> filler
	) : base
	(
		new Array::Dimension.Spatial.From.System<T>(
			new SystemSnapshot::Filler.Property.Value.With.Size.System<T>(
				size,
				filler))
	)
	{
	}
}