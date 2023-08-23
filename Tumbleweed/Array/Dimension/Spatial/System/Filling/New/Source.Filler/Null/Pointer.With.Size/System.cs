using Scalar = Tumbleweed.Scalar.Immutable;
using Point = Tumbleweed.Point.Spatial;
using System = System;

namespace Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Source.Filler.Null.Pointer.With.Size;

public sealed class System<T> : Scalar::Envelope<T[,,]>
{
	public System
	(
		Point::Any<System::Int32> size
	) : base
	(
		new Scalar::Function.Result.Actual<T[,,]>(
    () => new T[size.X, size.X, size.Z])
	)
	{
	}
}