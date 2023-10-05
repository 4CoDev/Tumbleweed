using Array = Tumbleweed.Array;

using System = System;
using Scalar = Tumbleweed.Scalar.Immutable;
using SystemSource = Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Source;

namespace Tumbleweed.Array.Dimension.Spatial.Filling.New.Source.Filler.Value.With.Size;

public sealed class System<T> : Array::Envelope<T>
{
	public System
	(Mathematics.Vector.Spatial.Generic.Any<System::Int32> size,
		T filler
	) : base
	(
		new Array::Dimension.Spatial.From.System<T>(
			new SystemSource::Filler.Value.With.Size.System<T>(
				size,
				filler))
	)
	{
	}
}