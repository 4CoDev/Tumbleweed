using Array = Tumbleweed.Array;
using Nullable = Tumbleweed.Scalar.Nullable;
using Point = Tumbleweed.Mathematics.Geometry.Stereometry.Point;
using System = System;
using SystemSnapshot = Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Snapshot;

namespace Tumbleweed.Array.Dimension.Spatial.Filling.New.Snapshot.Filler.Null.Object.With.Size;

public sealed class System<T> : Array::Envelope<Nullable::Any<T>>
{
	public System
	(Mathematics.Geometry.Stereometry.Point.Generic.Any<System::Int32> size
	) : base
	(
		new Array::Dimension.Spatial.From.System<Nullable::Any<T>>(
			new SystemSnapshot::Filler.Null.Object.With.Size.System<T>(
				size))
	)
	{
	}
}