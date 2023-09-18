using Godot;
using Tumbleweed.Enumerable.Function;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;
using Enumerable = DotGod.Geometry.Spatial.Graphical.Surface.Transformed.Enumerable;

namespace DotGod.Geometry.Spatial.Graphical.Mesh.Transformed;

public sealed class One : Envelope
{
	public One
	(
		Any mesh,
		Transform3D transform
	) : this
	(
		mesh,
		new Value<Transform3D>(transform)
	)
	{
	}
	
	public One
	(
		Any mesh,
		Any<Transform3D> transform
	) : base
	(
		new With.Surfaces.One(
			new Enumerable(
				new Result<Graphical.Surface.Any>(
					() => mesh.Surfaces),
				transform))
	)
	{
	}
}