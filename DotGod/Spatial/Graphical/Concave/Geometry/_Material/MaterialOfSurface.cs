using DotGod.Spatial.Graphical.Concave.Geometry.Surface;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Material;

public sealed class MaterialOfSurface : Envelope<Material>
{
	public MaterialOfSurface(ISurface surface) : base
	(
			new Actual<Material>(
				() => surface.Material.Value)
	)
	{
	}
}