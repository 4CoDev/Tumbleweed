using Scalar = Tumbleweed.Scalar.Immutable;
using Point = Tumbleweed.Point.Spatial;
using System = System;
using Specific = Tumbleweed.Array.Dimension.Spatial.System.Filling.Specific;
using Filling = Tumbleweed.Array.Dimension.Spatial.System.Filling;

namespace Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Source.Filler.Value.With.Size;

public sealed class System<T> : Scalar::Envelope<T[,,]>
{
	public System
	(
		Point::Any<System::Int32> size,
		T filler
	) : base
	(
		new Specific::Source.Filler.Value.One<T>(
			new Null.Pointer.With.Size.System<T>(size),
			filler)
	)
	{
	}
}