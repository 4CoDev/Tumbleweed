using DotGod.Geometrics.Graphical.Surfaces;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Materials;

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