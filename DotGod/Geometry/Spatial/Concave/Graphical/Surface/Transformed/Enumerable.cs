using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Surface.Transformed;

public sealed class Enumerable : Tumbleweed.Enumerable.Envelope<Any>
{
	public Enumerable
	(
		IEnumerable<Any> surfaces,
		Any<Transform3D> transform
	) : base
	(
		new Selected<Any>(
			surfaces,
			surface => new One(surface, transform))
	)
	{
	}
}