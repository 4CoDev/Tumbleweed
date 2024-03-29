using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Surface.Material;

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