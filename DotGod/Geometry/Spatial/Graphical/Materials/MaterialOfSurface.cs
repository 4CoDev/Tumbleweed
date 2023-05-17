using DotGod.Geometry.Spatial.Graphical.Surfaces;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Materials;

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