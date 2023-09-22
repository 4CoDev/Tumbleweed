using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace DotGod.Geometry.Stereometry.Graphical.Surface.Material;

public sealed class Actual : Envelope<Godot.Material>
{
	public Actual(Any surface) : base
	(
			new Actual<Godot.Material>(
				() => surface.Material.Value)
	)
	{
	}
}