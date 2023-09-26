using Nullable = Tumbleweed.Scalar.Nullable;
using Scalar = Tumbleweed.Scalar.Immutable;
using Point = Tumbleweed.Mathematics.Geometry.Stereometry.Point;
using System = System;
using Source = Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Source;

namespace Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Source.Filler.Null.Object.With.Size;

public sealed class System<T> : Scalar::Envelope<Nullable::Any<T>[,,]>
{
	public System
	(Mathematics.Geometry.Stereometry.Point.Generic.Any<System::Int32> size
	) : base
	(
		new Source::Filler.Value.With.Size.System<Nullable::Any<T>>(
			size,
			new Nullable::Null<T>())
	)
	{
	}
}