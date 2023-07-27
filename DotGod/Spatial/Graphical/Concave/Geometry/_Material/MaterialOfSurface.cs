using DotGod.Spatial.Graphical.Concave.Geometry.Surface;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Function;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Material;

public sealed class MaterialOfSurface : Envelope<Material>
{
	public MaterialOfSurface(ISurface surface) : base
	(
			new Tumbleweed.Scalar.Function.Result<Material>(
				() => surface.Material.Value)
	)
	{
	}
}