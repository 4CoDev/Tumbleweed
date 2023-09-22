using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Stereometry.Graphical.Surface.Material;

public sealed class Lazy : Envelope<Godot.Material>
{
	public Lazy(Any surface) : base
	(
		new Tumbleweed.Scalar.Immutable.Lazy<Godot.Material>(
			new Actual(surface))
	)
	{
	}
}