using Tumbleweed.Array.Dimension.Multi;
using Array = Tumbleweed.Array;
using Nullable = Tumbleweed.Property.Nullable;

using System = System;
using SystemSource = Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Source;

namespace Tumbleweed.Array.Dimension.Spatial.Filling.New.Source.Filler.Null.Object.With.Size;

public sealed class System<T> : Envelope<Nullable::Any<T>>
{
	public System
	(Mathematics.Vector.Spatial.Generic.Any<System::Int32> size
	) : base
	(
		new Array::Dimension.Spatial.From.System<Nullable::Any<T>>(
			new SystemSource::Filler.Null.Object.With.Size.System<T>(
				size))
	)
	{
	}
}