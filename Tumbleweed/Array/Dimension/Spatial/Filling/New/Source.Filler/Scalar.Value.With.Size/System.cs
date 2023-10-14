using Tumbleweed.Array.Dimension.Multi;
using Array = Tumbleweed.Array;

using System = System;
using Scalar = Tumbleweed.Scalar.Immutable;
using SystemSource = Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Source;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace Tumbleweed.Array.Dimension.Spatial.Filling.New.Source.Filler.Scalar.Value.With.Size;

public sealed class System<T> : Envelope<T>
{
	public System
	(Mathematics.Vector.Spatial.Generic.Any<System::Int32> size,
		Scalar::Any<T> filler
	) : base
	(
		new Array::Dimension.Spatial.From.System<T>(
			new SystemSource::Filler.Scalar.Value.With.Size.System<T>(
				size,
				filler))
	)
	{
	}
}