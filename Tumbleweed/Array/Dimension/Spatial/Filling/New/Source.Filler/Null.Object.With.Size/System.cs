using Array = Tumbleweed.Array;
using Nullable = Tumbleweed.Scalar.Nullable;
using Point = Tumbleweed.Point.Spatial;
using System = System;
using SystemSource = Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Source;

namespace Tumbleweed.Array.Dimension.Spatial.Filling.New.Source.Filler.Null.Object.With.Size;

public sealed class System<T> : Array::Envelope<Nullable::Any<T>>
{
	public System
	(
		Point::Any<System::Int32> size
	) : base
	(
		new Array::Dimension.Spatial.From.System<Nullable::Any<T>>(
			new SystemSource::Filler.Null.Object.With.Size.System<T>(
				size))
	)
	{
	}
}