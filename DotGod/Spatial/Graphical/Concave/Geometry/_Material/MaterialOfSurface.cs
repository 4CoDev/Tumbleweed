using DotGod.Spatial.Graphical.Concave.Geometry.Surface;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Material;

public sealed class MaterialOfSurface : ScalarEnvelope<Material>
{
	public MaterialOfSurface(ISurface surface) : base
	(
			new ResultOfFunction<Material>(
				() => surface.Material.Value)
	)
	{
	}
}