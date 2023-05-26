using DotGod.Geometry.Spatial.Graphical.Surface;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical._Material;

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